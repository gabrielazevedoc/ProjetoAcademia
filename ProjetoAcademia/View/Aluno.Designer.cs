﻿namespace ProjetoAcademia.View
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
            label1 = new Label();
            label2 = new Label();
            lv_treino = new ListView();
            btn_logout = new Button();
            lv_aluno = new ListView();
            SuspendLayout();
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
            // lv_treino
            // 
            lv_treino.Font = new Font("Segoe UI", 12F);
            lv_treino.Location = new Point(12, 219);
            lv_treino.Name = "lv_treino";
            lv_treino.Size = new Size(875, 220);
            lv_treino.TabIndex = 10;
            lv_treino.UseCompatibleStateImageBehavior = false;
            lv_treino.View = System.Windows.Forms.View.Details;
            lv_treino.Columns.Add("Objetivo", 150, HorizontalAlignment.Left);
            lv_treino.Columns.Add("Intensidade", 150, HorizontalAlignment.Left);
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Transparent;
            btn_logout.Font = new Font("Segoe UI", 12F);
            btn_logout.ForeColor = Color.Black;
            btn_logout.Location = new Point(806, 484);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(81, 29);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // lv_aluno
            // 
            lv_aluno.FullRowSelect = true;
            lv_aluno.Location = new Point(12, 33);
            lv_aluno.Name = "lv_aluno";
            lv_aluno.Size = new Size(875, 162);
            lv_aluno.TabIndex = 12;
            lv_aluno.UseCompatibleStateImageBehavior = false;
            lv_aluno.View = System.Windows.Forms.View.Details;
            lv_aluno.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lv_aluno.Columns.Add("CPF", 150, HorizontalAlignment.Left);
            lv_aluno.Columns.Add("Idade", 150, HorizontalAlignment.Left);
            lv_aluno.Columns.Add("Plano", 150, HorizontalAlignment.Left);
            lv_aluno.Columns.Add("Sexo", 150, HorizontalAlignment.Left);
            // 
            // Aluno
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gray;
            ClientSize = new Size(899, 525);
            Controls.Add(lv_aluno);
            Controls.Add(btn_logout);
            Controls.Add(lv_treino);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Aluno";
            Text = "Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ListView lv_treino;
        private Button btn_logout;
        public ListView lv_aluno;
    }
}