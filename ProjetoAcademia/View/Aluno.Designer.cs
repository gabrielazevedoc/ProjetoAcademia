namespace ProjetoAcademia.View
{
    partial class Aluno
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
            btn_sair = new Button();
            label1 = new Label();
            listView1 = new ListView();
            label2 = new Label();
            listView2 = new ListView();
            btn_logout = new Button();
            SuspendLayout();
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(30, 533);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(74, 28);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 7;
            label1.Text = "Dados pessoais";
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F);
            listView1.Location = new Point(12, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(875, 152);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 9;
            label2.Text = "Treino";
            // 
            // listView2
            // 
            listView2.Font = new Font("Segoe UI", 12F);
            listView2.Location = new Point(12, 219);
            listView2.Name = "listView2";
            listView2.Size = new Size(875, 220);
            listView2.TabIndex = 10;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Black;
            btn_logout.Font = new Font("Segoe UI", 12F);
            btn_logout.ForeColor = Color.Transparent;
            btn_logout.Location = new Point(806, 484);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(81, 29);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // Aluno
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gray;
            ClientSize = new Size(899, 525);
            Controls.Add(btn_logout);
            Controls.Add(listView2);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(btn_sair);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Aluno";
            Text = "Treino";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_sair;
        private Label label1;
        private ListView listView1;
        private Label label2;
        private ListView listView2;
        private Button btn_logout;
    }
}