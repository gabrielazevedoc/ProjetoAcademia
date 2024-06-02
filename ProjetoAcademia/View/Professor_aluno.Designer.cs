namespace ProjetoAcademia.View
{
    partial class Professor_aluno
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
            btn_cadastrar = new Button();
            label2 = new Label();
            input_nome = new TextBox();
            input_CPF = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            input_treino = new TextBox();
            label9 = new Label();
            input_sexo = new ComboBox();
            btn_imc = new Button();
            btn_showtreino = new Button();
            btn_deletar = new Button();
            btn_logout = new Button();
            input_plano = new ComboBox();
            gv_alunos = new DataGridView();
            input_data = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)gv_alunos).BeginInit();
            SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrar.Location = new Point(12, 440);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(92, 37);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // input_nome
            // 
            input_nome.Location = new Point(12, 96);
            input_nome.Name = "input_nome";
            input_nome.Size = new Size(190, 26);
            input_nome.TabIndex = 10;
            // 
            // input_CPF
            // 
            input_CPF.Location = new Point(12, 152);
            input_CPF.Name = "input_CPF";
            input_CPF.Size = new Size(190, 26);
            input_CPF.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 13;
            label4.Text = "CPF";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 188);
            label6.Name = "label6";
            label6.Size = new Size(162, 19);
            label6.TabIndex = 17;
            label6.Text = "Data de Nascimento";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 19;
            label7.Text = "Plano";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(12, 303);
            label8.Name = "label8";
            label8.Size = new Size(48, 19);
            label8.TabIndex = 21;
            label8.Text = "Sexo";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // input_treino
            // 
            input_treino.Location = new Point(12, 383);
            input_treino.Name = "input_treino";
            input_treino.Size = new Size(190, 26);
            input_treino.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(12, 361);
            label9.Name = "label9";
            label9.Size = new Size(57, 19);
            label9.TabIndex = 23;
            label9.Text = "Treino";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // input_sexo
            // 
            input_sexo.FormattingEnabled = true;
            input_sexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            input_sexo.Location = new Point(12, 325);
            input_sexo.Name = "input_sexo";
            input_sexo.Size = new Size(190, 26);
            input_sexo.TabIndex = 25;
            // 
            // btn_imc
            // 
            btn_imc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_imc.Location = new Point(154, 12);
            btn_imc.Name = "btn_imc";
            btn_imc.Size = new Size(132, 27);
            btn_imc.TabIndex = 28;
            btn_imc.Text = "Cadastrar treino";
            btn_imc.UseVisualStyleBackColor = true;
            // 
            // btn_showtreino
            // 
            btn_showtreino.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_showtreino.Location = new Point(12, 12);
            btn_showtreino.Name = "btn_showtreino";
            btn_showtreino.Size = new Size(136, 27);
            btn_showtreino.TabIndex = 27;
            btn_showtreino.Text = "Cadastrar aluno";
            btn_showtreino.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            btn_deletar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deletar.Location = new Point(110, 440);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(92, 37);
            btn_deletar.TabIndex = 29;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(826, 483);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(61, 30);
            btn_logout.TabIndex = 30;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // input_plano
            // 
            input_plano.FormattingEnabled = true;
            input_plano.Items.AddRange(new object[] { "Fitness Basic", "Fitness Plus", "Fitness Master" });
            input_plano.Location = new Point(12, 269);
            input_plano.Name = "input_plano";
            input_plano.Size = new Size(190, 26);
            input_plano.TabIndex = 32;
            // 
            // gv_alunos
            // 
            gv_alunos.BackgroundColor = SystemColors.ButtonHighlight;
            gv_alunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_alunos.Location = new Point(229, 96);
            gv_alunos.Name = "gv_alunos";
            gv_alunos.Size = new Size(658, 381);
            gv_alunos.TabIndex = 33;
            // 
            // input_data
            // 
            input_data.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_data.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_data.Location = new Point(12, 210);
            input_data.Name = "input_data";
            input_data.Size = new Size(190, 25);
            input_data.TabIndex = 34;
            // 
            // Professor_aluno
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(899, 525);
            Controls.Add(input_data);
            Controls.Add(gv_alunos);
            Controls.Add(input_plano);
            Controls.Add(btn_logout);
            Controls.Add(btn_deletar);
            Controls.Add(btn_imc);
            Controls.Add(btn_showtreino);
            Controls.Add(input_sexo);
            Controls.Add(input_treino);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(input_CPF);
            Controls.Add(label4);
            Controls.Add(input_nome);
            Controls.Add(label2);
            Controls.Add(btn_cadastrar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Professor_aluno";
            Text = "Professor_screen";
            Load += Professor_aluno_Load;
            ((System.ComponentModel.ISupportInitialize)gv_alunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_cadastrar;
        private Label label2;
        private TextBox input_nome;
        private TextBox input_CPF;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox input_treino;
        private Label label9;
        private ComboBox input_sexo;
        private Button btn_imc;
        private Button btn_showtreino;
        private Button btn_deletar;
        private Button btn_logout;
        private ComboBox input_plano;
        private DataGridView gv_alunos;
        private DateTimePicker input_data;
    }
}