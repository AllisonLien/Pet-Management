namespace Pet_Adoption_and_Shelter_Management_System
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LblName = new Label();
            LblPass = new Label();
            LblRole = new Label();
            BtnLogin = new Button();
            TxtName = new TextBox();
            TxtPass = new TextBox();
            ComRole = new ComboBox();
            LblRegister = new Label();
            LlblRegister = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(193, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 32);
            label1.TabIndex = 0;
            label1.Text = "Pet Adoption System-Login";
            label1.Click += label1_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LblName.Location = new Point(178, 104);
            LblName.Margin = new Padding(4, 0, 4, 0);
            LblName.Name = "LblName";
            LblName.Size = new Size(94, 21);
            LblName.TabIndex = 1;
            LblName.Text = "User Name:";
            // 
            // LblPass
            // 
            LblPass.AutoSize = true;
            LblPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LblPass.Location = new Point(178, 172);
            LblPass.Margin = new Padding(4, 0, 4, 0);
            LblPass.Name = "LblPass";
            LblPass.Size = new Size(83, 21);
            LblPass.TabIndex = 2;
            LblPass.Text = "Password:";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LblRole.Location = new Point(178, 231);
            LblRole.Margin = new Padding(4, 0, 4, 0);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(47, 21);
            LblRole.TabIndex = 3;
            LblRole.Text = "Role:";
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BtnLogin.Location = new Point(339, 288);
            BtnLogin.Margin = new Padding(4);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(96, 32);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TxtName.Location = new Point(330, 101);
            TxtName.Margin = new Padding(4);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(127, 29);
            TxtName.TabIndex = 6;
            // 
            // TxtPass
            // 
            TxtPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TxtPass.Location = new Point(330, 164);
            TxtPass.Margin = new Padding(4);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(127, 29);
            TxtPass.TabIndex = 7;
            // 
            // ComRole
            // 
            ComRole.FormattingEnabled = true;
            ComRole.Items.AddRange(new object[] { "admin", "staff", "adopter" });
            ComRole.Location = new Point(330, 228);
            ComRole.Name = "ComRole";
            ComRole.Size = new Size(127, 29);
            ComRole.TabIndex = 8;
            // 
            // LblRegister
            // 
            LblRegister.AutoSize = true;
            LblRegister.Location = new Point(178, 342);
            LblRegister.Name = "LblRegister";
            LblRegister.Size = new Size(129, 21);
            LblRegister.TabIndex = 9;
            LblRegister.Text = "Not Registered?";
            // 
            // LlblRegister
            // 
            LlblRegister.AutoSize = true;
            LlblRegister.LinkColor = Color.Blue;
            LlblRegister.Location = new Point(330, 342);
            LlblRegister.Name = "LlblRegister";
            LlblRegister.Size = new Size(116, 21);
            LlblRegister.TabIndex = 10;
            LlblRegister.TabStop = true;
            LlblRegister.Text = "Register Here!";
            LlblRegister.LinkClicked += LlblRegister_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(734, 396);
            Controls.Add(LlblRegister);
            Controls.Add(LblRegister);
            Controls.Add(ComRole);
            Controls.Add(TxtPass);
            Controls.Add(TxtName);
            Controls.Add(BtnLogin);
            Controls.Add(LblRole);
            Controls.Add(LblPass);
            Controls.Add(LblName);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblName;
        private Label LblPass;
        private Label LblRole;
        private Button BtnLogin;
        private TextBox TxtName;
        private TextBox TxtPass;
        private ComboBox ComRole;
        private Label LblRegister;
        private LinkLabel LlblRegister;
    }
}
