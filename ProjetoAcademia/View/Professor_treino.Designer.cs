namespace ProjetoAcademia.View
{
    partial class Professor_treino
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
            btn_logout = new Button();
            btn_deletar = new Button();
            btn_cadTreino = new Button();
            btn_cadAluno = new Button();
            label4 = new Label();
            label2 = new Label();
            btn_cadastrar = new Button();
            btn_atualizar = new Button();
            gv_treinos = new DataGridView();
            cb_objetivo = new ComboBox();
            cb_intensidade = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gv_treinos).BeginInit();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(826, 483);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(61, 30);
            btn_logout.TabIndex = 48;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.Tomato;
            btn_deletar.Location = new Point(15, 237);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(82, 37);
            btn_deletar.TabIndex = 47;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_cadTreino
            // 
            btn_cadTreino.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadTreino.Location = new Point(444, 12);
            btn_cadTreino.Name = "btn_cadTreino";
            btn_cadTreino.Size = new Size(132, 27);
            btn_cadTreino.TabIndex = 46;
            btn_cadTreino.Text = "Cadastrar treino";
            btn_cadTreino.UseVisualStyleBackColor = true;
            // 
            // btn_cadAluno
            // 
            btn_cadAluno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadAluno.Location = new Point(302, 12);
            btn_cadAluno.Name = "btn_cadAluno";
            btn_cadAluno.Size = new Size(136, 27);
            btn_cadAluno.TabIndex = 45;
            btn_cadAluno.Text = "Cadastrar aluno";
            btn_cadAluno.UseVisualStyleBackColor = true;
            btn_cadAluno.Click += btn_showtreino_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 35;
            label4.Text = "Intensidade";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 33;
            label2.Text = "Objetivo";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.LimeGreen;
            btn_cadastrar.Location = new Point(15, 194);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(82, 37);
            btn_cadastrar.TabIndex = 32;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Location = new Point(15, 280);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(82, 37);
            btn_atualizar.TabIndex = 51;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // gv_treinos
            // 
            gv_treinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_treinos.Location = new Point(216, 96);
            gv_treinos.Name = "gv_treinos";
            gv_treinos.Size = new Size(671, 381);
            gv_treinos.TabIndex = 52;
            // 
            // cb_objetivo
            // 
            cb_objetivo.FormattingEnabled = true;
            cb_objetivo.Items.AddRange(new object[] { "Emagrecer", "Fortalescimento Muscular", "Hipertrofia Muscular", "Desenvolver área específica" });
            cb_objetivo.Location = new Point(12, 96);
            cb_objetivo.Name = "cb_objetivo";
            cb_objetivo.Size = new Size(193, 23);
            cb_objetivo.TabIndex = 53;
            // 
            // cb_intensidade
            // 
            cb_intensidade.FormattingEnabled = true;
            cb_intensidade.Items.AddRange(new object[] { "Alta", "Média", "Baixa" });
            cb_intensidade.Location = new Point(12, 152);
            cb_intensidade.Name = "cb_intensidade";
            cb_intensidade.Size = new Size(193, 23);
            cb_intensidade.TabIndex = 54;
            // 
            // Professor_treino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(899, 525);
            Controls.Add(cb_intensidade);
            Controls.Add(cb_objetivo);
            Controls.Add(gv_treinos);
            Controls.Add(btn_atualizar);
            Controls.Add(btn_logout);
            Controls.Add(btn_deletar);
            Controls.Add(btn_cadTreino);
            Controls.Add(btn_cadAluno);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btn_cadastrar);
            Name = "Professor_treino";
            Text = "Professor_treino";
            ((System.ComponentModel.ISupportInitialize)gv_treinos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_logout;
        private Button btn_deletar;
        private Button btn_cadTreino;
        private Button btn_cadAluno;
        private ComboBox comboBox1;
        private TextBox textBox8;
        private Label label9;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox3;
        private Label label4;
        private Label label2;
        private Button btn_cadastrar;
        private Button btn_atualizar;
        private DataGridView gv_treinos;
        private ComboBox cb_objetivo;
        private ComboBox cb_intensidade;
    }
}