namespace ProjetoAcademia
{
    partial class Login
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
            Logo = new PictureBox();
            label_nome = new Label();
            input_name = new TextBox();
            label_CPF = new Label();
            btn_login = new Button();
            panel1 = new Panel();
            input_CPF = new TextBox();
            label1 = new Label();
            btn_logout = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.FItness;
            Logo.Location = new Point(30, 72);
            Logo.Margin = new Padding(4, 3, 4, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(159, 166);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Font = new Font("Segoe UI", 8.25F);
            label_nome.ForeColor = SystemColors.Info;
            label_nome.Location = new Point(222, 267);
            label_nome.Margin = new Padding(4, 0, 4, 0);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(37, 13);
            label_nome.TabIndex = 1;
            label_nome.Text = "Nome";
            label_nome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_name
            // 
            input_name.Location = new Point(222, 290);
            input_name.Margin = new Padding(4, 3, 4, 3);
            input_name.Name = "input_name";
            input_name.Size = new Size(268, 26);
            input_name.TabIndex = 2;
            // 
            // label_CPF
            // 
            label_CPF.AutoSize = true;
            label_CPF.Font = new Font("Segoe UI", 8.25F);
            label_CPF.ForeColor = SystemColors.Info;
            label_CPF.Location = new Point(222, 326);
            label_CPF.Margin = new Padding(4, 0, 4, 0);
            label_CPF.Name = "label_CPF";
            label_CPF.Size = new Size(26, 13);
            label_CPF.TabIndex = 1;
            label_CPF.Text = "CPF";
            label_CPF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.MenuText;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ControlLightLight;
            btn_login.Location = new Point(325, 445);
            btn_login.Margin = new Padding(4, 3, 4, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(69, 33);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(input_CPF);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(label_nome);
            panel1.Controls.Add(label_CPF);
            panel1.Controls.Add(input_name);
            panel1.Location = new Point(221, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 564);
            panel1.TabIndex = 5;
            // 
            // input_CPF
            // 
            input_CPF.Location = new Point(222, 349);
            input_CPF.Name = "input_CPF";
            input_CPF.Size = new Size(268, 26);
            input_CPF.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(284, 158);
            label1.Name = "label1";
            label1.Size = new Size(160, 80);
            label1.TabIndex = 5;
            label1.Text = "FITNESS \r\nACADEMIA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = SystemColors.MenuText;
            btn_logout.Font = new Font("Segoe UI", 8.25F);
            btn_logout.ForeColor = SystemColors.ControlLightLight;
            btn_logout.Location = new Point(80, 447);
            btn_logout.Margin = new Padding(4, 3, 4, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(63, 33);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(899, 525);
            Controls.Add(btn_logout);
            Controls.Add(panel1);
            Controls.Add(Logo);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness Academia";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Logo;
        private Label label_nome;
        private TextBox input_name;
        private Label label_CPF;
        private Button btn_login;
        private Panel panel1;
        private Label label1;
        private Button btn_logout;
        private TextBox input_CPF;
    }
}
