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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            btn_imc = new Button();
            btn_showtreino = new Button();
            btn_deletar = new Button();
            btn_logout = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(12, 440);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(92, 37);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
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
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 26);
            textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 26);
            textBox3.TabIndex = 14;
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
            // textBox5
            // 
            textBox5.Location = new Point(12, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(190, 26);
            textBox5.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 188);
            label6.Name = "label6";
            label6.Size = new Size(48, 19);
            label6.TabIndex = 17;
            label6.Text = "Peso";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 269);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(190, 26);
            textBox6.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
            label7.TabIndex = 19;
            label7.Text = "Altura";
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
            // textBox8
            // 
            textBox8.Location = new Point(12, 383);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(190, 26);
            textBox8.TabIndex = 24;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino" });
            comboBox1.Location = new Point(12, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 26);
            comboBox1.TabIndex = 25;
            // 
            // btn_imc
            // 
            btn_imc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_imc.Location = new Point(154, 12);
            btn_imc.Name = "btn_imc";
            btn_imc.Size = new Size(132, 27);
            btn_imc.TabIndex = 28;
            btn_imc.Text = "Cadastrar treino";
            btn_imc.UseVisualStyleBackColor = true;
            // 
            // btn_showtreino
            // 
            btn_showtreino.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_showtreino.Location = new Point(12, 12);
            btn_showtreino.Name = "btn_showtreino";
            btn_showtreino.Size = new Size(136, 27);
            btn_showtreino.TabIndex = 27;
            btn_showtreino.Text = "Cadastrar aluno";
            btn_showtreino.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            btn_deletar.Location = new Point(110, 440);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(92, 37);
            btn_deletar.TabIndex = 29;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(826, 483);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(61, 30);
            btn_logout.TabIndex = 30;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(208, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(679, 381);
            listView1.TabIndex = 31;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Professor_aluno
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(899, 525);
            Controls.Add(listView1);
            Controls.Add(btn_logout);
            Controls.Add(btn_deletar);
            Controls.Add(btn_imc);
            Controls.Add(btn_showtreino);
            Controls.Add(comboBox1);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btn_cadastrar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Professor_aluno";
            Text = "Professor_screen";
            Load += Professor_screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_cadastrar;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private ComboBox comboBox1;
        private Button btn_imc;
        private Button btn_showtreino;
        private Button btn_deletar;
        private Button btn_logout;
        private ListView listView1;
    }
}