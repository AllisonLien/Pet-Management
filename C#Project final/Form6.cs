using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class FormAdoptionRequest : Form
    {
        public Database MYDB;
        public MySqlConnection mySqlConnection;
        private int currentUserID;
        private string currentUser;
        private string currentRole;

        public FormAdoptionRequest()
        {
            InitializeComponent();
        }

        public FormAdoptionRequest(int userID, string user, string role)
        {
            InitializeComponent();
            currentUserID = userID;
            currentUser = user;
            currentRole = role;
        }

        private void FormAdoptionRequest_Load(object sender, EventArgs e)
        {
            MYDB = new Database("localhost", "root", "admin", "petdb", "3306");

            Label userLabel = this.Controls.Find("LblCuser", true).FirstOrDefault() as Label;
            if (userLabel != null)
            {
                userLabel.Text = $"Hi, {currentUser}，Role: {currentRole}";
            }

            // --- START OF FIX ---
            bool isManager = (currentRole == "Admin" || currentRole == "Staff");

            if (!isManager) // If the role is Adopter
            {
                BtnApprove.Visible = false;
                BtnReject.Visible = false;
                BtnUpdateStatus.Visible = false;
                BtnClear.Visible = false;

                LblRequestId.Visible = false;
                LblPetName.Visible = false;
                LblAdopterName.Visible = false;
                LblStatus.Visible = false;
                TxtRequestId.Visible = false;
                TxtPetName.Visible = false;
                TxtAdopterName.Visible = false;
                CBoxStatus.Visible = false;

                // Adjust DataGridView position for Adopter role
                dataGridView1.Location = new Point(12, 110);
                dataGridView1.Size = new Size(976, 328);
                BtnView.Location = new Point(12, 444);
            }
            // --- END OF FIX ---

            dataGridView1.CellClick += dataGridView1_CellClick;

            LoadRequests();
        }

        private void LoadRequests()
        {
            using (MySqlConnection conn = MYDB.Connect())
            {
                if (conn == null) return;
                try
                {
                    conn.Open();
                    string sql = "SELECT ar.request_id AS ID, p.petname AS PetName, u.username AS AdopterName, ar.request_date AS RequestDate, ar.status AS Status, p.idpets AS PetID " +
                                 "FROM adoption_requests ar " +
                                 "JOIN pets p ON ar.pet_id = p.idpets " +
                                 "JOIN users u ON ar.user_id = u.idusers";

                    if (currentRole == "Adopter")
                    {
                        sql += " WHERE u.username = @username";
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (currentRole == "Adopter")
                    {
                        cmd.Parameters.AddWithValue("@username", currentUser);
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;

                    if (dataGridView1.Columns.Contains("PetID"))
                    {
                        dataGridView1.Columns["PetID"].Visible = false;
                    }

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading adoption requests: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (currentRole == "Admin" || currentRole == "Staff"))
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TxtRequestId.Text = row.Cells["ID"].Value.ToString();
                TxtPetName.Text = row.Cells["PetName"].Value.ToString();
                TxtAdopterName.Text = row.Cells["AdopterName"].Value.ToString();
                CBoxStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormHome homeForm = new FormHome(currentUserID, currentUser, currentRole);
            homeForm.Show();
            this.Hide();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (currentRole != "Admin" && currentRole != "Staff") return;

            if (dataGridView1.CurrentRow == null || string.IsNullOrEmpty(TxtRequestId.Text) || string.IsNullOrEmpty(CBoxStatus.Text))
            {
                MessageBox.Show("Select a request and choose a status to update.", "Selection Required");
                return;
            }

            if (!int.TryParse(TxtRequestId.Text, out int requestId))
            {
                MessageBox.Show("Invalid Request ID.", "Error");
                return;
            }

            string newStatus = CBoxStatus.Text;

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE adoption_requests SET status = @status WHERE request_id = @requestId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@requestId", requestId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Status updated to {newStatus} successfully!");
                    LoadRequests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtRequestId.Clear();
            TxtPetName.Clear();
            TxtAdopterName.Clear();
            CBoxStatus.Text = "";
            CBoxStatus.SelectedIndex = -1;
        }

        private void RejectRequest(int requestId)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to reject request ID {requestId}?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();
                    string updateRequestSql = "UPDATE adoption_requests SET status = 'Rejected' WHERE request_id = @requestId";
                    MySqlCommand updateRequestCmd = new MySqlCommand(updateRequestSql, conn);
                    updateRequestCmd.Parameters.AddWithValue("@requestId", requestId);
                    updateRequestCmd.ExecuteNonQuery();

                    MessageBox.Show("Adoption request rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRequests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error rejecting request: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if (currentRole != "Admin" && currentRole != "Staff") return;

            if (dataGridView1.CurrentRow == null || string.IsNullOrEmpty(TxtRequestId.Text))
            {
                MessageBox.Show("Select a request to approve.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TxtRequestId.Text, out int requestId) || !int.TryParse(dataGridView1.CurrentRow.Cells["PetID"].Value.ToString(), out int petId))
            {
                MessageBox.Show("Invalid Request or Pet ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView1.CurrentRow.Cells["Status"].Value.ToString().Equals("Approved", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("This request is already approved.", "Status Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to approve request ID {requestId} and mark the pet as adopted?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string updateRequestSql = "UPDATE adoption_requests SET status = 'Approved' WHERE request_id = @requestId";
                        MySqlCommand updateRequestCmd = new MySqlCommand(updateRequestSql, conn, transaction);
                        updateRequestCmd.Parameters.AddWithValue("@requestId", requestId);
                        updateRequestCmd.ExecuteNonQuery();

                        string updatePetSql = "UPDATE pets SET status = 'Adopted' WHERE idpets = @petId AND status != 'Adopted'";
                        MySqlCommand updatePetCmd = new MySqlCommand(updatePetSql, conn, transaction);
                        updatePetCmd.Parameters.AddWithValue("@petId", petId);
                        updatePetCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Adoption request approved and pet marked as adopted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRequests();
                    }
                    catch (Exception innerEx)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Operation failed. Changes were reverted. Error: " + innerEx.Message, "Database Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (currentRole != "Admin" && currentRole != "Staff") return;

            if (dataGridView1.CurrentRow == null || string.IsNullOrEmpty(TxtRequestId.Text))
            {
                MessageBox.Show("Select a request to reject.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(TxtRequestId.Text, out int requestId))
            {
                RejectRequest(requestId);
            }
            else
            {
                MessageBox.Show("Invalid Request ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}