using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class FormPet : Form
    {
        public Database MYDB;
        public MySqlConnection mySqlConnection;

        private int currentUserID;
        private string currentUser;
        private string currentRole;
        public FormPet()
        {
            InitializeComponent();
        }
        public FormPet(int userID,string user, string role)
        {
            InitializeComponent();
            currentUserID = userID;
            currentUser = user;
            currentRole = role;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormPet_Load(object sender, EventArgs e)
        {
            LblCuser.Text = $"Hi, {currentUser}，Role: {currentRole}";
            MYDB = new Database("localhost", "root", "admin", "petdb", "3306");


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string species = CBoxSpecies.Text;
            string breed = TxtBreed.Text;
            string age = TxtAge.Text.Trim();
            string gender = RBtnMale.Checked ? "Male" : "Female";
            string location = CBoxLocation.Text;
            string description = TxtD.Text.Trim();

            if (name == "" || species == "" || breed == "" || age == "" || gender == "" || location == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string sql = @"INSERT INTO pets 
                           (petname, species, breed, age, gender, location, decription)
                           VALUES (@name, @species, @breed, @age, @gender, @location, @desc)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@species", species);
                    cmd.Parameters.AddWithValue("@breed", breed);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@desc", description);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pet added successfully!");

                    ClearFields(); 
                    LoadPets();   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding pet: " + ex.Message);
                }
            }
        }
        private void ClearFields()
        {
            TxtName.Clear();
            CBoxSpecies.SelectedIndex = -1;
            TxtBreed.Clear();
            TxtAge.Clear();
            RBtnMale.Checked = false;
            RBtnFemale.Checked = false;
            CBoxLocation.SelectedIndex = -1;
            TxtD.Clear();
            TxtID.Text = "";

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

            ClearFields();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a pet to delete.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this pet?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string sql = "DELETE FROM pets WHERE idpets=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pet deleted successfully!");
                    LoadPets();    
                    ClearFields();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete error: " + ex.Message);
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a pet to edit.");
                return;
            }
            DataGridViewRow row = dataGridView1.CurrentRow;
            TxtID.Text = row.Cells["ID"].Value.ToString();
            TxtName.Text = row.Cells["Name"].Value.ToString();
            CBoxSpecies.Text = row.Cells["Species"].Value.ToString();
            TxtBreed.Text = row.Cells["Breed"].Value.ToString();
            TxtAge.Text = row.Cells["Age"].Value.ToString();

            string gender = row.Cells["Gender"].Value.ToString();
            if (gender == "Male")
                RBtnMale.Checked = true;
            else
                RBtnFemale.Checked = true;

            CBoxLocation.Text = row.Cells["Location"].Value.ToString();
            TxtD.Text = row.Cells["Description"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome(currentUserID, currentUser, currentRole);
            home.Show();
            this.Hide();
        }

        private void BtnView_Click(object sender, EventArgs e)
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Please select a pet to edit first.");
                return;
            }

            int id = int.Parse(TxtID.Text);

            string name = TxtName.Text.Trim();
            string species = CBoxSpecies.Text;
            string breed = TxtBreed.Text.Trim();
            string age = TxtAge.Text.Trim();
            string gender = RBtnMale.Checked ? "Male" : "Female";
            string location = CBoxLocation.Text;
            string description = TxtD.Text.Trim();

            using (MySqlConnection conn = MYDB.Connect())
            {
                try
                {
                    conn.Open();

                    string sql = @"UPDATE pets SET petname=@name, species=@species, breed=@breed,age=@age, gender=@gender,location=@location, decription=@desc  WHERE idpets=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@species", species);
                    cmd.Parameters.AddWithValue("@breed", breed);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pet updated successfully!");

                    LoadPets();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update error: " + ex.Message);
                }
            }
        }
    }
}
