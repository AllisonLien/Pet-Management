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
using System.Data;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class FormRegister : Form
    {
        public Database MYDB;
        public MySqlConnection mySqlConnection;
        public FormRegister()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = TxtName.Text;
            string password = TxtPass.Text;
            string confirm = TxtCpass.Text;
            string role = "Adopter";



            if (username == "" || password == "" || confirm=="")
            {
                MessageBox.Show("Please fill in all fields.");
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

                    string insertSql = "INSERT INTO users (username, password, role) VALUES (@u, @p, @r)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@u", username);
                    insertCmd.Parameters.AddWithValue("@p", password);
                    insertCmd.Parameters.AddWithValue("@r", role);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            MYDB = new Database("localhost", "root", "admin", "petdb", "3306");

            ComRole.Text = "Adopter";
            ComRole.Enabled = false;
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure?", "Calcel registeration", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
