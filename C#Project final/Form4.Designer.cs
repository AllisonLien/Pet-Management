namespace Pet_Adoption_and_Shelter_Management_System
{
    partial class FormPet
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
            LblName = new Label();
            LblAge = new Label();
            LblSpecies = new Label();
            LblBreed = new Label();
            LblGender = new Label();
            LblLocation = new Label();
            LblD = new Label();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClear = new Button();
            TxtName = new TextBox();
            CBoxSpecies = new ComboBox();
            TxtBreed = new TextBox();
            TxtAge = new TextBox();
            GBoxSex = new GroupBox();
            RBtnFemale = new RadioButton();
            RBtnMale = new RadioButton();
            CBoxLocation = new ComboBox();
            TxtD = new TextBox();
            LblView = new Label();
            LblCuser = new Label();
            BtnHome = new Button();
            BtnView = new Button();
            dataGridView1 = new DataGridView();
            BtnUpdate = new Button();
            TxtID = new TextBox();
            GBoxSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(332, 32);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Pet Management";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblName.Location = new Point(57, 94);
            LblName.Name = "LblName";
            LblName.Size = new Size(56, 21);
            LblName.TabIndex = 1;
            LblName.Text = "Name";
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblAge.Location = new Point(57, 141);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(40, 21);
            LblAge.TabIndex = 2;
            LblAge.Text = "Age";
            // 
            // LblSpecies
            // 
            LblSpecies.AutoSize = true;
            LblSpecies.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblSpecies.Location = new Point(280, 94);
            LblSpecies.Name = "LblSpecies";
            LblSpecies.Size = new Size(69, 21);
            LblSpecies.TabIndex = 3;
            LblSpecies.Text = "Species";
            // 
            // LblBreed
            // 
            LblBreed.AutoSize = true;
            LblBreed.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblBreed.Location = new Point(528, 94);
            LblBreed.Name = "LblBreed";
            LblBreed.Size = new Size(55, 21);
            LblBreed.TabIndex = 4;
            LblBreed.Text = "Breed";
            LblBreed.Click += label5_Click;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblGender.Location = new Point(528, 143);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(67, 21);
            LblGender.TabIndex = 5;
            LblGender.Text = "Gender";
            // 
            // LblLocation
            // 
            LblLocation.AutoSize = true;
            LblLocation.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblLocation.Location = new Point(280, 146);
            LblLocation.Name = "LblLocation";
            LblLocation.Size = new Size(77, 21);
            LblLocation.TabIndex = 6;
            LblLocation.Text = "Location";
            // 
            // LblD
            // 
            LblD.AutoSize = true;
            LblD.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblD.Location = new Point(57, 191);
            LblD.Name = "LblD";
            LblD.Size = new Size(100, 21);
            LblD.TabIndex = 7;
            LblD.Text = "Description";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnAdd.Location = new Point(172, 272);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(108, 36);
            BtnAdd.TabIndex = 8;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnEdit.Location = new Point(286, 272);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(108, 36);
            BtnEdit.TabIndex = 9;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnDelete.Location = new Point(514, 272);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(108, 36);
            BtnDelete.TabIndex = 10;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnClear.Location = new Point(628, 272);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(108, 36);
            BtnClear.TabIndex = 11;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtName.Location = new Point(121, 90);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 29);
            TxtName.TabIndex = 12;
            // 
            // CBoxSpecies
            // 
            CBoxSpecies.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            CBoxSpecies.FormattingEnabled = true;
            CBoxSpecies.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit", "Bird", "Other" });
            CBoxSpecies.Location = new Point(362, 91);
            CBoxSpecies.Name = "CBoxSpecies";
            CBoxSpecies.Size = new Size(121, 29);
            CBoxSpecies.TabIndex = 13;
            // 
            // TxtBreed
            // 
            TxtBreed.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtBreed.Location = new Point(600, 90);
            TxtBreed.Name = "TxtBreed";
            TxtBreed.Size = new Size(131, 29);
            TxtBreed.TabIndex = 14;
            // 
            // TxtAge
            // 
            TxtAge.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtAge.Location = new Point(121, 138);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(100, 29);
            TxtAge.TabIndex = 15;
            // 
            // GBoxSex
            // 
            GBoxSex.Controls.Add(RBtnFemale);
            GBoxSex.Controls.Add(RBtnMale);
            GBoxSex.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            GBoxSex.Location = new Point(601, 141);
            GBoxSex.Name = "GBoxSex";
            GBoxSex.Size = new Size(199, 56);
            GBoxSex.TabIndex = 16;
            GBoxSex.TabStop = false;
            GBoxSex.Text = "Sex";
            // 
            // RBtnFemale
            // 
            RBtnFemale.AutoSize = true;
            RBtnFemale.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            RBtnFemale.Location = new Point(88, 27);
            RBtnFemale.Name = "RBtnFemale";
            RBtnFemale.Size = new Size(84, 25);
            RBtnFemale.TabIndex = 1;
            RBtnFemale.TabStop = true;
            RBtnFemale.Text = "Female";
            RBtnFemale.UseVisualStyleBackColor = true;
            // 
            // RBtnMale
            // 
            RBtnMale.AutoSize = true;
            RBtnMale.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            RBtnMale.Location = new Point(16, 27);
            RBtnMale.Name = "RBtnMale";
            RBtnMale.Size = new Size(66, 25);
            RBtnMale.TabIndex = 0;
            RBtnMale.TabStop = true;
            RBtnMale.Text = "Male";
            RBtnMale.UseVisualStyleBackColor = true;
            // 
            // CBoxLocation
            // 
            CBoxLocation.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            CBoxLocation.FormattingEnabled = true;
            CBoxLocation.Items.AddRange(new object[] { "London", "Paris", "Taiwan", "Canada", "USA", "Other" });
            CBoxLocation.Location = new Point(363, 143);
            CBoxLocation.Name = "CBoxLocation";
            CBoxLocation.Size = new Size(121, 29);
            CBoxLocation.TabIndex = 17;
            // 
            // TxtD
            // 
            TxtD.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtD.Location = new Point(57, 215);
            TxtD.Multiline = true;
            TxtD.Name = "TxtD";
            TxtD.Size = new Size(679, 45);
            TxtD.TabIndex = 18;
            // 
            // LblView
            // 
            LblView.AutoSize = true;
            LblView.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblView.Location = new Point(57, 326);
            LblView.Name = "LblView";
            LblView.Size = new Size(112, 21);
            LblView.TabIndex = 19;
            LblView.Text = "View All Pets";
            // 
            // LblCuser
            // 
            LblCuser.AutoSize = true;
            LblCuser.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCuser.ForeColor = Color.DarkCyan;
            LblCuser.Location = new Point(588, 41);
            LblCuser.Name = "LblCuser";
            LblCuser.Size = new Size(58, 21);
            LblCuser.TabIndex = 21;
            LblCuser.Text = "label3";
            // 
            // BtnHome
            // 
            BtnHome.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHome.Location = new Point(93, 26);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(142, 36);
            BtnHome.TabIndex = 22;
            BtnHome.Text = "Home Page";
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // BtnView
            // 
            BtnView.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnView.Location = new Point(49, 272);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(117, 36);
            BtnView.TabIndex = 23;
            BtnView.Text = "View Pets";
            BtnView.UseVisualStyleBackColor = true;
            BtnView.Click += BtnView_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 355);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(671, 150);
            dataGridView1.TabIndex = 24;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(408, 272);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(100, 36);
            BtnUpdate.TabIndex = 25;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(121, 61);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 26;
            TxtID.Visible = false;
            // 
            // FormPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 516);
            Controls.Add(TxtID);
            Controls.Add(BtnUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(BtnView);
            Controls.Add(BtnHome);
            Controls.Add(LblCuser);
            Controls.Add(LblView);
            Controls.Add(TxtD);
            Controls.Add(CBoxLocation);
            Controls.Add(GBoxSex);
            Controls.Add(TxtAge);
            Controls.Add(TxtBreed);
            Controls.Add(CBoxSpecies);
            Controls.Add(TxtName);
            Controls.Add(BtnClear);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(LblD);
            Controls.Add(LblLocation);
            Controls.Add(LblGender);
            Controls.Add(LblBreed);
            Controls.Add(LblSpecies);
            Controls.Add(LblAge);
            Controls.Add(LblName);
            Controls.Add(label1);
            Name = "FormPet";
            Text = "Manage Pet ";
            Load += FormPet_Load;
            GBoxSex.ResumeLayout(false);
            GBoxSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblName;
        private Label LblAge;
        private Label LblSpecies;
        private Label LblBreed;
        private Label LblGender;
        private Label LblLocation;
        private Label LblD;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClear;
        private TextBox TxtName;
        private ComboBox CBoxSpecies;
        private TextBox TxtBreed;
        private TextBox TxtAge;
        private GroupBox GBoxSex;
        private RadioButton RBtnFemale;
        private RadioButton RBtnMale;
        private ComboBox CBoxLocation;
        private TextBox TxtD;
        private Label LblView;
        private Label LblCuser;
        private Button BtnHome;
        private Button BtnView;
        private DataGridView dataGridView1;
        private Button BtnUpdate;
        private TextBox TxtID;
    }
}