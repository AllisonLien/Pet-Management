namespace Pet_Adoption_and_Shelter_Management_System
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            BtnPets = new Button();
            BtnUser = new Button();
            BtnRequest = new Button();
            BtnView = new Button();
            Btnout = new Button();
            LblWelcome = new Label();
            LblCuser = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(296, 64);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 0;
            label1.Text = "Pet Adoption System";
            // 
            // BtnPets
            // 
            BtnPets.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            BtnPets.Location = new Point(167, 172);
            BtnPets.Name = "BtnPets";
            BtnPets.Size = new Size(241, 31);
            BtnPets.TabIndex = 1;
            BtnPets.Text = "Manage Pets";
            BtnPets.UseVisualStyleBackColor = true;
            BtnPets.Click += BtnPets_Click;
            // 
            // BtnUser
            // 
            BtnUser.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            BtnUser.Location = new Point(167, 228);
            BtnUser.Name = "BtnUser";
            BtnUser.Size = new Size(241, 31);
            BtnUser.TabIndex = 2;
            BtnUser.Text = "Manage Users";
            BtnUser.UseVisualStyleBackColor = true;
            BtnUser.Click += BtnUser_Click;
            // 
            // BtnRequest
            // 
            BtnRequest.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            BtnRequest.Location = new Point(424, 172);
            BtnRequest.Name = "BtnRequest";
            BtnRequest.Size = new Size(260, 31);
            BtnRequest.TabIndex = 3;
            BtnRequest.Text = "Adoption Requests";
            BtnRequest.UseVisualStyleBackColor = true;
            BtnRequest.Click += BtnView_Click;
            // 
            // BtnView
            // 
            BtnView.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            BtnView.Location = new Point(424, 228);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(260, 31);
            BtnView.TabIndex = 4;
            BtnView.Text = "Make and View Requests";
            BtnView.UseVisualStyleBackColor = true;
            BtnView.Click += BtnRequest_Click;
            // 
            // Btnout
            // 
            Btnout.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            Btnout.Location = new Point(362, 300);
            Btnout.Name = "Btnout";
            Btnout.Size = new Size(96, 31);
            Btnout.TabIndex = 5;
            Btnout.Text = "Logout";
            Btnout.UseVisualStyleBackColor = true;
            Btnout.Click += Btnout_Click;
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            LblWelcome.Location = new Point(201, 121);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(82, 21);
            LblWelcome.TabIndex = 6;
            LblWelcome.Text = "Welcome";
            // 
            // LblCuser
            // 
            LblCuser.AutoSize = true;
            LblCuser.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCuser.ForeColor = Color.DarkCyan;
            LblCuser.Location = new Point(308, 121);
            LblCuser.Name = "LblCuser";
            LblCuser.Size = new Size(58, 21);
            LblCuser.TabIndex = 8;
            LblCuser.Text = "label3";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(LblCuser);
            Controls.Add(LblWelcome);
            Controls.Add(Btnout);
            Controls.Add(BtnView);
            Controls.Add(BtnRequest);
            Controls.Add(BtnUser);
            Controls.Add(BtnPets);
            Controls.Add(label1);
            Name = "FormHome";
            Text = "Home Page";
            Load += FormHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnPets;
        private Button BtnUser;
        private Button BtnRequest;
        private Button BtnView;
        private Button Btnout;
        private Label LblWelcome;
        private Label LblCuser;
    }
}