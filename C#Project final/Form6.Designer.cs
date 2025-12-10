namespace Pet_Adoption_and_Shelter_Management_System
{
    partial class FormAdoptionRequest
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
            LblTitle = new Label();
            LblCuser = new Label();
            BtnHome = new Button();
            dataGridView1 = new DataGridView();
            LblRequestId = new Label();
            LblPetName = new Label();
            LblAdopterName = new Label();
            LblStatus = new Label();
            TxtRequestId = new TextBox();
            TxtPetName = new TextBox();
            TxtAdopterName = new TextBox();
            CBoxStatus = new ComboBox();
            BtnApprove = new Button();
            BtnReject = new Button();
            BtnClear = new Button();
            BtnView = new Button();
            BtnUpdateStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = SystemColors.Highlight;
            LblTitle.Location = new Point(234, 30);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(378, 32);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "MANAGE ADOPTION REQUESTS";
            // 
            // LblCuser
            // 
            LblCuser.AutoSize = true;
            LblCuser.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCuser.ForeColor = Color.DarkCyan;
            LblCuser.Location = new Point(323, 85);
            LblCuser.Name = "LblCuser";
            LblCuser.Size = new Size(38, 21);
            LblCuser.TabIndex = 1;
            LblCuser.Text = "List";
            // 
            // BtnHome
            // 
            BtnHome.BackColor = SystemColors.ControlLight;
            BtnHome.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHome.Location = new Point(748, 78);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(130, 35);
            BtnHome.TabIndex = 2;
            BtnHome.Text = "Home Page";
            BtnHome.UseVisualStyleBackColor = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(680, 328);
            dataGridView1.TabIndex = 3;
            // 
            // LblRequestId
            // 
            LblRequestId.AutoSize = true;
            LblRequestId.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblRequestId.Location = new Point(-273, 313);
            LblRequestId.Name = "LblRequestId";
            LblRequestId.Size = new Size(104, 21);
            LblRequestId.TabIndex = 4;
            LblRequestId.Text = "Request ID: ";
            LblRequestId.Visible = false;
            // 
            // LblPetName
            // 
            LblPetName.AutoSize = true;
            LblPetName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblPetName.Location = new Point(-273, 353);
            LblPetName.Name = "LblPetName";
            LblPetName.Size = new Size(90, 21);
            LblPetName.TabIndex = 5;
            LblPetName.Text = "Pet Name:";
            LblPetName.Visible = false;
            // 
            // LblAdopterName
            // 
            LblAdopterName.AutoSize = true;
            LblAdopterName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblAdopterName.Location = new Point(-273, 393);
            LblAdopterName.Name = "LblAdopterName";
            LblAdopterName.Size = new Size(128, 21);
            LblAdopterName.TabIndex = 6;
            LblAdopterName.Text = "Adopter Name:";
            LblAdopterName.Visible = false;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblStatus.Location = new Point(-273, 433);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(68, 21);
            LblStatus.TabIndex = 7;
            LblStatus.Text = "Status: ";
            LblStatus.Visible = false;
            // 
            // TxtRequestId
            // 
            TxtRequestId.Enabled = false;
            TxtRequestId.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtRequestId.Location = new Point(-150, 313);
            TxtRequestId.Name = "TxtRequestId";
            TxtRequestId.Size = new Size(160, 29);
            TxtRequestId.TabIndex = 8;
            TxtRequestId.Visible = false;
            // 
            // TxtPetName
            // 
            TxtPetName.Enabled = false;
            TxtPetName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtPetName.Location = new Point(-150, 353);
            TxtPetName.Name = "TxtPetName";
            TxtPetName.Size = new Size(160, 29);
            TxtPetName.TabIndex = 9;
            TxtPetName.Visible = false;
            // 
            // TxtAdopterName
            // 
            TxtAdopterName.Enabled = false;
            TxtAdopterName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtAdopterName.Location = new Point(-150, 393);
            TxtAdopterName.Name = "TxtAdopterName";
            TxtAdopterName.Size = new Size(160, 29);
            TxtAdopterName.TabIndex = 10;
            TxtAdopterName.Visible = false;
            // 
            // CBoxStatus
            // 
            CBoxStatus.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            CBoxStatus.FormattingEnabled = true;
            CBoxStatus.Items.AddRange(new object[] { "Pending", "Approved", "Rejected" });
            CBoxStatus.Location = new Point(-150, 433);
            CBoxStatus.Name = "CBoxStatus";
            CBoxStatus.Size = new Size(160, 29);
            CBoxStatus.TabIndex = 11;
            CBoxStatus.Visible = false;
            // 
            // BtnApprove
            // 
            BtnApprove.BackColor = Color.FromArgb(128, 255, 128);
            BtnApprove.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnApprove.Location = new Point(748, 177);
            BtnApprove.Name = "BtnApprove";
            BtnApprove.Size = new Size(130, 40);
            BtnApprove.TabIndex = 12;
            BtnApprove.Text = "Approve";
            BtnApprove.UseVisualStyleBackColor = false;
            BtnApprove.Click += BtnApprove_Click;
            // 
            // BtnReject
            // 
            BtnReject.BackColor = Color.FromArgb(255, 128, 128);
            BtnReject.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnReject.Location = new Point(748, 258);
            BtnReject.Name = "BtnReject";
            BtnReject.Size = new Size(130, 40);
            BtnReject.TabIndex = 13;
            BtnReject.Text = "Reject";
            BtnReject.UseVisualStyleBackColor = false;
            BtnReject.Click += BtnReject_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = SystemColors.ControlLight;
            BtnClear.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnClear.Location = new Point(-14, 459);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(130, 40);
            BtnClear.TabIndex = 14;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Visible = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnView
            // 
            BtnView.BackColor = SystemColors.ControlLight;
            BtnView.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnView.Location = new Point(122, 462);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(150, 35);
            BtnView.TabIndex = 15;
            BtnView.Text = "Refresh List";
            BtnView.UseVisualStyleBackColor = false;
            BtnView.Visible = false;
            BtnView.Click += BtnView_Click;
            // 
            // BtnUpdateStatus
            // 
            BtnUpdateStatus.BackColor = Color.LightYellow;
            BtnUpdateStatus.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnUpdateStatus.Location = new Point(290, 462);
            BtnUpdateStatus.Name = "BtnUpdateStatus";
            BtnUpdateStatus.Size = new Size(130, 40);
            BtnUpdateStatus.TabIndex = 16;
            BtnUpdateStatus.Text = "Update Status";
            BtnUpdateStatus.UseVisualStyleBackColor = false;
            BtnUpdateStatus.Visible = false;
            BtnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // FormAdoptionRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1000, 485);
            Controls.Add(BtnUpdateStatus);
            Controls.Add(BtnView);
            Controls.Add(BtnClear);
            Controls.Add(BtnReject);
            Controls.Add(BtnApprove);
            Controls.Add(CBoxStatus);
            Controls.Add(TxtAdopterName);
            Controls.Add(TxtPetName);
            Controls.Add(TxtRequestId);
            Controls.Add(LblStatus);
            Controls.Add(LblAdopterName);
            Controls.Add(LblPetName);
            Controls.Add(LblRequestId);
            Controls.Add(dataGridView1);
            Controls.Add(BtnHome);
            Controls.Add(LblCuser);
            Controls.Add(LblTitle);
            Name = "FormAdoptionRequest";
            Text = "Adoption Request Management";
            Load += FormAdoptionRequest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitle;
        private Label LblCuser;
        private Button BtnHome;
        private DataGridView dataGridView1;
        private Label LblRequestId;
        private Label LblPetName;
        private Label LblAdopterName;
        private Label LblStatus;
        private TextBox TxtRequestId;
        private TextBox TxtPetName;
        private TextBox TxtAdopterName;
        private ComboBox CBoxStatus;
        private Button BtnApprove;
        private Button BtnReject;
        private Button BtnClear;
        private Button BtnView;
        private Button BtnUpdateStatus;
    }
}