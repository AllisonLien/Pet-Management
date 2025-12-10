using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class FormLogin : Form
    {
        public Database MYDB;
        public MySqlConnection mySqlConnection;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LlblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ComRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your role.");
                return;
            }

            string selectedRole = ComRole.Text;
            mySqlConnection = MYDB.Connect();

            try
            {
                mySqlConnection.Open();

                string sql = "SELECT * FROM users WHERE  username=@u AND password=@p AND role=@r";
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                cmd.Parameters.AddWithValue("@u", TxtName.Text);
                cmd.Parameters.AddWithValue("@p", TxtPass.Text);
                cmd.Parameters.AddWithValue("@r", selectedRole);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Username, password, or role is not correct!");
                    return;
                }

                int userID = Convert.ToInt32(reader["idusers"]);
                string username = reader["username"].ToString();
                string role = reader["role"].ToString();

                MessageBox.Show("Login Successfully!");

                FormHome main = new FormHome(userID, username, role);
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            MYDB = new Database("localhost", "root", "admin", "petdb", "3306");

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
