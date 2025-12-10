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
    public partial class FormHome : Form
    {
        private int currentUserID;
        private string currentUsername;
        private string currentRole;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            LblCuser.Text = $"Hi, {currentUsername}，Role: {currentRole}";

            Permissions();
        }


        public FormHome(int userID, string username, string role)
        {
            InitializeComponent();
            currentUserID = userID;
            currentUsername = username;
            currentRole = role;
        }

        private void Permissions()
        {
            if (currentRole == "Admin")
            {
            }
            else if (currentRole == "Staff")
            {
                BtnUser.Enabled = false;
            }
            else if (currentRole == "Adopter")
            {
                BtnUser.Enabled = false;
                BtnPets.Enabled = false;
                BtnRequest.Enabled = false;
                BtnView.Enabled = true;
            }
        }

        private void Btnout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(" Are you Sure to Log out?", "Log Out", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnPets_Click(object sender, EventArgs e)
        {
            FormPet petForm = new FormPet(currentUserID, currentUsername, currentRole);
            petForm.Show();
            this.Hide();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            UserManageForm usersForm = new UserManageForm(currentUserID, currentUsername, currentRole);
            usersForm.Show();
            this.Hide();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            FormAdoptionRequest manageRequestsForm = new FormAdoptionRequest(currentUserID, currentUsername, currentRole);
            manageRequestsForm.Show();
            this.Hide();
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {
            FormViewRequests viewRequestsForm = new FormViewRequests(currentUserID,currentUsername, currentRole);
            viewRequestsForm.Show();
            this.Hide();
        }
    }
}