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
            label_senha = new Label();
            input_password = new MaskedTextBox();
            btn_login = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btn_logout = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.FItness;
            Logo.Location = new Point(70, 228);
            Logo.Margin = new Padding(4, 3, 4, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(256, 166);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            Logo.Click += pictureBox1_Click;
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nome.Location = new Point(100, 276);
            label_nome.Margin = new Padding(4, 0, 4, 0);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(45, 20);
            label_nome.TabIndex = 1;
            label_nome.Text = "Nome";
            label_nome.TextAlign = ContentAlignment.MiddleCenter;
            label_nome.Click += label1_Click;
            // 
            // input_name
            // 
            input_name.Location = new Point(100, 299);
            input_name.Margin = new Padding(4, 3, 4, 3);
            input_name.Name = "input_name";
            input_name.Size = new Size(352, 26);
            input_name.TabIndex = 2;
            // 
            // label_senha
            // 
            label_senha.AutoSize = true;
            label_senha.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_senha.Location = new Point(100, 345);
            label_senha.Margin = new Padding(4, 0, 4, 0);
            label_senha.Name = "label_senha";
            label_senha.Size = new Size(48, 20);
            label_senha.TabIndex = 1;
            label_senha.Text = "Senha";
            label_senha.TextAlign = ContentAlignment.MiddleCenter;
            label_senha.Click += label1_Click;
            // 
            // input_password
            // 
            input_password.Location = new Point(100, 368);
            input_password.Margin = new Padding(4, 3, 4, 3);
            input_password.Name = "input_password";
            input_password.Size = new Size(352, 26);
            input_password.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.MenuText;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ControlLightLight;
            btn_login.Location = new Point(219, 447);
            btn_login.Margin = new Padding(4, 3, 4, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(122, 33);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(input_password);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(label_nome);
            panel1.Controls.Add(label_senha);
            panel1.Controls.Add(input_name);
            panel1.Location = new Point(396, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 574);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Font = new Font("Elephant", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(163, 156);
            label1.Name = "label1";
            label1.Size = new Size(233, 82);
            label1.TabIndex = 5;
            label1.Text = "FITNESS \r\nACADEMIA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = SystemColors.MenuText;
            btn_logout.FlatStyle = FlatStyle.Popup;
            btn_logout.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = SystemColors.ControlLightLight;
            btn_logout.Location = new Point(142, 447);
            btn_logout.Margin = new Padding(4, 3, 4, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(122, 33);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(927, 573);
            Controls.Add(btn_logout);
            Controls.Add(panel1);
            Controls.Add(Logo);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness Academia";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Logo;
        private Label label_nome;
        private TextBox input_name;
        private Label label_senha;
        private MaskedTextBox input_password;
        private Button btn_login;
        private Panel panel1;
        private Label label1;
        private Button btn_logout;
    }
}
