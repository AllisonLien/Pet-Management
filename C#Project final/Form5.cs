using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class UserManageForm : Form
    {
        public Database MYDB;
        public MySqlConnection mySqlConnection;

        public UserManageForm()
        {
            InitializeComponent();
        }
        private int currentUserID;
        private string currentUser;
        private string currentRole;

        public UserManageForm(int userID, string user, string role)
        {
            InitializeComponent();
            currentUserID = userID;
            currentUser = user;
            currentRole = role;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a user to edit.");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;
            TxtID.Text = row.Cells["ID"].Value.ToString();
            TxtName.Text = row.Cells["Username"].Value.ToString();
            TxtPass.Text = row.Cells["PassWord"].Value.ToString();
            CBoxRole.Text = row.Cells["Role"].Value.ToString();
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            LblCuser.Text = $"Hi, {currentUser}，Role: {currentRole}";
            MYDB = new Database("localhost", "root", "admin", "petdb", "3306");

        }
        private void ClearUserFields()
        {
            TxtID.Text = "";
            TxtName.Clear();
            TxtPass.Clear();
            CBoxRole.SelectedIndex = -1;
        }
        private void LoadUsers()
        {
            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT idusers AS 'ID', username AS 'Username',  password AS 'Password', role AS 'Role' from users";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearUserFields();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome(currentUserID, currentUser, currentRole);
            home.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string username = TxtName.Text.Trim();
            string password = TxtPass.Text.Trim();
            string role = CBoxRole.Text;

            if (username == "" || password == "" || role == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string checkSql = "SELECT * FROM users WHERE username=@u";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@u", username);

                    MySqlDataReader reader = checkCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("This username already exists!");
                        return;
                    }
                    reader.Close();

                    if (role == "Admin")
                    {
                        MessageBox.Show("You can't create an Admin account.");
                        return;
                    }
                    string insertSql = "INSERT INTO users (username, password, role) VALUES (@u, @p, @r)";
                    MySqlCommand cmd = new MySqlCommand(insertSql, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@r", role);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User added successfully!");

                    LoadUsers();
                    ClearUserFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user: " + ex.Message);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Select a user to edit.");
                return;
            }

            int id = int.Parse(TxtID.Text);
            string username = TxtName.Text;
            string password = TxtPass.Text;
            string role = CBoxRole.Text;

            if (username == "" || role == "" || password == "")
            {
                MessageBox.Show("Each columns are required.");
                return;
            }

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string checkSql = "SELECT * FROM users WHERE username=@u AND idusers!=@id";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@u", username);
                    checkCmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = checkCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("This username is already used by another user.");
                        return;
                    }
                    reader.Close();


                    string sql = "UPDATE users SET username=@u, password=@p, role=@r WHERE idusers=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.Parameters.AddWithValue("@id", id);

                    if (password != "")
                        cmd.Parameters.AddWithValue("@p", password);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User updated successfully!");

                    LoadUsers();
                    ClearUserFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a user to delete.");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string username = row.Cells["Username"].Value.ToString();
            string role = row.Cells["Role"].Value.ToString().Trim().ToLower();

            if (role == "admin")
            {
                MessageBox.Show("Admin accounts cannot be deleted.");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string sql = "delete from users WHERE idusers=@id AND role!='Admin'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User deleted successfully!");

                    LoadUsers();       
                    ClearUserFields(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
