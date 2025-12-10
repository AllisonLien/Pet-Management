using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class FormViewRequests : Form
    {
        public Database MYDB;

        private int currentUserID;

        private string currentUser;
        private string currentRole;

        public FormViewRequests()
        {
            InitializeComponent();

        }

        public FormViewRequests(int userID, string username, string role)
        {
            InitializeComponent();
            currentUserID = userID;
            currentUser = username;
            currentRole = role;
            if (currentRole == "Admin")
            {
                BtnRequest.Enabled = false;
            }
            else if (currentRole == "Staff")
            {
                BtnRequest.Enabled = false;
            }
        }
    
        private void FormViewRequests_Load(object sender, EventArgs e)
        {
            MYDB = new Database("localhost", "root", "admin", "petdb", "3306");

            Label userLabel = this.Controls.Find("LblCuser", true).FirstOrDefault() as Label;
            if (userLabel != null)
            {
                userLabel.Text = $"Hi, {currentUser}，Role: {currentRole}";
            }

            if (CBoxFilterStatus != null)
            {
                CBoxFilterStatus.Items.Add("Show All");
                CBoxFilterStatus.Items.Add("Pending");
                CBoxFilterStatus.Items.Add("Approved");
                CBoxFilterStatus.Items.Add("Rejected");
                CBoxFilterStatus.SelectedIndex = 0;
            }

            SetupManagerControls();
            //LoadRequests();
        }

        private void SetupManagerControls()
        {
            bool isManager = (currentRole == "Admin" || currentRole == "Staff");

            if (this.Controls.Find("BtnApprove", true).FirstOrDefault() is Button btnApprove)
            {
                btnApprove.Visible = isManager;
            }
            if (this.Controls.Find("BtnReject", true).FirstOrDefault() is Button btnReject)
            {
                btnReject.Visible = isManager;
            }
            if (this.Controls.Find("dataGridView1", true).FirstOrDefault() is DataGridView dgv)
            {
                dgv.ReadOnly = !isManager;
            }
        }

        private void CBoxFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void LoadRequests()
        {
            string selectedStatus = CBoxFilterStatus.SelectedItem?.ToString();

            int userId = (currentRole == "Adopter") ? MYDB.GetUserIdByUsername(currentUser) : -1;

            using (MySqlConnection conn = MYDB.Connect())
            {
                if (conn == null)
                {
                    return;
                }

                try
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            ar.request_id AS 'ID', 
                            p.petname AS 'Pet Name', 
                            u.username AS 'Adopter Name', 
                            ar.request_date AS 'Request Date', 
                            ar.status AS 'Status',
                            ar.pet_id AS 'Pet ID',
                            ar.user_id
                        FROM adoption_requests ar
                        JOIN pets p ON ar.pet_id = p.idpets 
                        JOIN users u ON ar.user_id = u.idusers
                        WHERE 1=1";

                    if (currentRole == "Adopter")
                    {
                        if (userId == -1) return;
                        sql += $" AND ar.user_id = {userId}";
                    }

                    if (selectedStatus != "Show All" && !string.IsNullOrEmpty(selectedStatus))
                    {
                        sql += " AND ar.status = @status";
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    if (selectedStatus != "Show All" && !string.IsNullOrEmpty(selectedStatus))
                    {
                        cmd.Parameters.AddWithValue("@status", selectedStatus);
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (this.Controls.Find("dataGridView1", true).FirstOrDefault() is DataGridView dgv)
                    {
                        dgv.DataSource = dt;
                        dgv.AllowUserToAddRows = false;

                        if (dgv.Columns.Contains("Pet ID"))
                        {
                            dgv.Columns["Pet ID"].Visible = false;
                            dgv.Columns["user_id"].Visible = false;
                        }

                        dgv.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading adoption requests: " + ex.Message, "SQL Execution Error");
                }
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            UpdateRequestStatus("Approved");
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            UpdateRequestStatus("Rejected");
        }

        private void UpdateRequestStatus(string newStatus)
        {
            if (currentRole != "Admin" && currentRole != "Staff") return;

            if (this.Controls.Find("dataGridView1", true).FirstOrDefault() is DataGridView dgv && dgv.CurrentRow != null)
            {
                if (!int.TryParse(dgv.CurrentRow.Cells["ID"].Value?.ToString(), out int requestId))
                {
                    MessageBox.Show("Could not read Request ID.", "Error");
                    return;
                }

                if (!int.TryParse(dgv.CurrentRow.Cells["Pet ID"].Value?.ToString(), out int petId))
                {
                    MessageBox.Show("Could not read Pet ID. Ensure the Pet ID is selected in the SQL query.", "Error");
                    return;
                }

                DialogResult confirm = MessageBox.Show($"Are you sure you want to set Request ID {requestId} status to '{newStatus}'?", "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.No) return;

                using (MySqlConnection conn = MYDB.Connect())
                {
                    try
                    {
                        conn.Open();

                        string updateRequestSql = "UPDATE adoption_requests SET status = @status WHERE request_id = @id";
                        MySqlCommand cmdRequest = new MySqlCommand(updateRequestSql, conn);
                        cmdRequest.Parameters.AddWithValue("@status", newStatus);
                        cmdRequest.Parameters.AddWithValue("@id", requestId);
                        cmdRequest.ExecuteNonQuery();

                        if (newStatus == "Approved")
                        {
                            string updatePetSql = "UPDATE pets SET status = 'Adopted' WHERE idpets = @petId";
                            MySqlCommand cmdPet = new MySqlCommand(updatePetSql, conn);
                            cmdPet.Parameters.AddWithValue("@petId", petId);
                            cmdPet.ExecuteNonQuery();

                            string rejectOthersSql = "UPDATE adoption_requests SET status = 'Rejected' WHERE pet_id = @petId AND status = 'Pending' AND request_id != @id";
                            MySqlCommand cmdRejectOthers = new MySqlCommand(rejectOthersSql, conn);
                            cmdRejectOthers.Parameters.AddWithValue("@petId", petId);
                            cmdRejectOthers.Parameters.AddWithValue("@id", requestId);
                            cmdRejectOthers.ExecuteNonQuery();
                        }

                        MessageBox.Show($"Request {requestId} status updated to {newStatus}!");
                        LoadRequests();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating status: {ex.Message}", "Database Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request to process.", "Selection Required");
            }
        }

        private void BtnViewPet_Click(object sender, EventArgs e)
        {
            LoadPets();
        }
        private void LoadPets()
        {
            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT idpets AS 'ID',petname AS 'Name', species AS 'Species', breed AS 'Breed', age AS 'Age', gender AS 'Gender', location AS 'Location', decription AS 'Description', status AS 'Status' FROM pets";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading pets: " + ex.Message);
                }
            }
        }
        private void BtnRequest_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a pet to request.");
                return;
            }

            //int petID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idpets"].Value);
            int petID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string petStatus = dataGridView1.CurrentRow.Cells["status"].Value.ToString();

            if (petStatus != "Available")
            {
                MessageBox.Show($"This pet is currently '{petStatus}' and cannot be requested.");
                return;
            }

            if (currentUserID <= 0)
            {
                MessageBox.Show("User ID is missing. Please log in again.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Submit adoption request for this pet?",
                "Confirm Request",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string sql = @"INSERT INTO adoption_requests 
                           (pet_id, user_id, request_date, status)
                           VALUES (@pet, @user, NOW(), 'Pending')";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@pet", petID);
                    cmd.Parameters.AddWithValue("@user", currentUserID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adoption request submitted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnViewRequest_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormHome homeForm = new FormHome(currentUserID, currentUser, currentRole);
            homeForm.Show();
            this.Hide();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}