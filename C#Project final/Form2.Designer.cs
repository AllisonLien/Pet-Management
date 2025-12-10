namespace Pet_Adoption_and_Shelter_Management_System
{
    partial class FormRegister
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
            LblPass = new Label();
            LblCpass = new Label();
            LblRole = new Label();
            TxtName = new TextBox();
            TxtPass = new TextBox();
            TxtCpass = new TextBox();
            ComRole = new ComboBox();
            BtnRegister = new Button();
            BtnCancle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(326, 36);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 0;
            label1.Text = "Register New User";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblName.Location = new Point(238, 105);
            LblName.Name = "LblName";
            LblName.Size = new Size(97, 21);
            LblName.TabIndex = 1;
            LblName.Text = "User Name";
            // 
            // LblPass
            // 
            LblPass.AutoSize = true;
            LblPass.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblPass.Location = new Point(238, 158);
            LblPass.Name = "LblPass";
            LblPass.Size = new Size(85, 21);
            LblPass.TabIndex = 2;
            LblPass.Text = "Password";
            // 
            // LblCpass
            // 
            LblCpass.AutoSize = true;
            LblCpass.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblCpass.Location = new Point(238, 210);
            LblCpass.Name = "LblCpass";
            LblCpass.Size = new Size(154, 21);
            LblCpass.TabIndex = 3;
            LblCpass.Text = "Confirm Password";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            LblRole.Location = new Point(238, 260);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(45, 21);
            LblRole.TabIndex = 4;
            LblRole.Text = "Role";
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtName.Location = new Point(411, 102);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 29);
            TxtName.TabIndex = 5;
            // 
            // TxtPass
            // 
            TxtPass.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtPass.Location = new Point(411, 158);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(100, 29);
            TxtPass.TabIndex = 6;
            // 
            // TxtCpass
            // 
            TxtCpass.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            TxtCpass.Location = new Point(411, 210);
            TxtCpass.Name = "TxtCpass";
            TxtCpass.Size = new Size(100, 29);
            TxtCpass.TabIndex = 7;
            // 
            // ComRole
            // 
            ComRole.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            ComRole.FormattingEnabled = true;
            ComRole.Items.AddRange(new object[] { "Adopter" });
            ComRole.Location = new Point(411, 260);
            ComRole.Name = "ComRole";
            ComRole.Size = new Size(121, 29);
            ComRole.TabIndex = 8;
            // 
            // BtnRegister
            // 
            BtnRegister.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnRegister.Location = new Point(265, 315);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(96, 37);
            BtnRegister.TabIndex = 9;
            BtnRegister.Text = "Register ";
            BtnRegister.UseVisualStyleBackColor = true;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // BtnCancle
            // 
            BtnCancle.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            BtnCancle.Location = new Point(486, 315);
            BtnCancle.Name = "BtnCancle";
            BtnCancle.Size = new Size(96, 37);
            BtnCancle.TabIndex = 10;
            BtnCancle.Text = "Cancel";
            BtnCancle.UseVisualStyleBackColor = true;
            BtnCancle.Click += BtnCancle_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCancle);
            Controls.Add(BtnRegister);
            Controls.Add(ComRole);
            Controls.Add(TxtCpass);
            Controls.Add(TxtPass);
            Controls.Add(TxtName);
            Controls.Add(LblRole);
            Controls.Add(LblCpass);
            Controls.Add(LblPass);
            Controls.Add(LblName);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "Register ";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblName;
        private Label LblPass;
        private Label LblCpass;
        private Label LblRole;
        private TextBox TxtName;
        private TextBox TxtPass;
        private TextBox TxtCpass;
        private ComboBox ComRole;
        private Button BtnRegister;
        private Button BtnCancle;
    }
}