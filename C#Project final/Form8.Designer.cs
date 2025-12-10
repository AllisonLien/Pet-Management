namespace Pet_Adoption_and_Shelter_Management_System
{
    partial class FormViewRequests
    {
        private System.ComponentModel.IContainer components = null;
        private Label LblTitle;
        private Label LblCuser;
        private DataGridView dataGridView1;
        private Button BtnRefresh;
        private Button BtnViewPet;
        private Button BtnRequest;
        private Button BtnViewRequest;
        private Button BtnHome;
        private ComboBox CBoxFilterStatus;
        private Label LblFilter;
        private Button BtnApprove;
        private Button BtnReject;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            LblTitle = new Label();
            LblCuser = new Label();
            dataGridView1 = new DataGridView();
            BtnRefresh = new Button();
            BtnViewPet = new Button();
            BtnRequest = new Button();
            BtnViewRequest = new Button();
            BtnHome = new Button();
            CBoxFilterStatus = new ComboBox();
            LblFilter = new Label();
            BtnApprove = new Button();
            BtnReject = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = SystemColors.Highlight;
            LblTitle.Location = new Point(352, 23);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(312, 32);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Make and View REQUESTS";
            LblTitle.Click += LblTitle_Click;
            // 
            // LblCuser
            // 
            LblCuser.AutoSize = true;
            LblCuser.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCuser.ForeColor = Color.DarkCyan;
            LblCuser.Location = new Point(705, 35);
            LblCuser.Name = "LblCuser";
            LblCuser.Size = new Size(34, 19);
            LblCuser.TabIndex = 1;
            LblCuser.Text = "List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(976, 300);
            dataGridView1.TabIndex = 8;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnRefresh.Location = new Point(270, 130);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(100, 35);
            BtnRefresh.TabIndex = 11;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // BtnViewPet
            // 
            BtnViewPet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnViewPet.Location = new Point(100, 75);
            BtnViewPet.Name = "BtnViewPet";
            BtnViewPet.Size = new Size(150, 45);
            BtnViewPet.TabIndex = 2;
            BtnViewPet.Text = "View Pet";
            BtnViewPet.UseVisualStyleBackColor = true;
            BtnViewPet.Click += BtnViewPet_Click;
            // 
            // BtnRequest
            // 
            BtnRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnRequest.Location = new Point(270, 75);
            BtnRequest.Name = "BtnRequest";
            BtnRequest.Size = new Size(150, 45);
            BtnRequest.TabIndex = 3;
            BtnRequest.Text = "Request";
            BtnRequest.UseVisualStyleBackColor = true;
            BtnRequest.Click += BtnRequest_Click;
            // 
            // BtnViewRequest
            // 
            BtnViewRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnViewRequest.Location = new Point(440, 75);
            BtnViewRequest.Name = "BtnViewRequest";
            BtnViewRequest.Size = new Size(150, 45);
            BtnViewRequest.TabIndex = 4;
            BtnViewRequest.Text = "View Request";
            BtnViewRequest.UseVisualStyleBackColor = true;
            BtnViewRequest.Click += BtnViewRequest_Click;
            // 
            // BtnHome
            // 
            BtnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnHome.Location = new Point(610, 75);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(150, 45);
            BtnHome.TabIndex = 5;
            BtnHome.Text = "Home";
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // CBoxFilterStatus
            // 
            CBoxFilterStatus.FormattingEnabled = true;
            CBoxFilterStatus.Location = new Point(110, 137);
            CBoxFilterStatus.Name = "CBoxFilterStatus";
            CBoxFilterStatus.Size = new Size(150, 23);
            CBoxFilterStatus.TabIndex = 7;
            CBoxFilterStatus.Text = "Show All";
            CBoxFilterStatus.SelectedIndexChanged += CBoxFilterStatus_SelectedIndexChanged;
            // 
            // LblFilter
            // 
            LblFilter.AutoSize = true;
            LblFilter.Location = new Point(12, 140);
            LblFilter.Name = "LblFilter";
            LblFilter.Size = new Size(87, 15);
            LblFilter.TabIndex = 6;
            LblFilter.Text = "Filter by Status:";
            // 
            // BtnApprove
            // 
            BtnApprove.BackColor = Color.LightGreen;
            BtnApprove.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnApprove.Location = new Point(1015, 75);
            BtnApprove.Name = "BtnApprove";
            BtnApprove.Size = new Size(150, 35);
            BtnApprove.TabIndex = 9;
            BtnApprove.Text = "Approve";
            BtnApprove.UseVisualStyleBackColor = false;
            BtnApprove.Visible = false;
            BtnApprove.Click += BtnApprove_Click;
            // 
            // BtnReject
            // 
            BtnReject.BackColor = Color.LightCoral;
            BtnReject.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnReject.Location = new Point(1055, 100);
            BtnReject.Name = "BtnReject";
            BtnReject.Size = new Size(150, 35);
            BtnReject.TabIndex = 10;
            BtnReject.Text = "Reject";
            BtnReject.UseVisualStyleBackColor = false;
            BtnReject.Visible = false;
            BtnReject.Click += BtnReject_Click;
            // 
            // FormViewRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1037, 485);
            Controls.Add(BtnReject);
            Controls.Add(BtnApprove);
            Controls.Add(CBoxFilterStatus);
            Controls.Add(LblFilter);
            Controls.Add(BtnHome);
            Controls.Add(BtnViewRequest);
            Controls.Add(BtnRequest);
            Controls.Add(BtnViewPet);
            Controls.Add(BtnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(LblCuser);
            Controls.Add(LblTitle);
            Name = "FormViewRequests";
            Text = "View Adoption Requests";
            Load += FormViewRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}