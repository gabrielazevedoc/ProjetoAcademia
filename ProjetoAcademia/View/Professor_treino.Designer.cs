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
            listView1 = new ListView();
            btn_logout = new Button();
            btn_deletar = new Button();
            btn_imc = new Button();
            btn_showtreino = new Button();
            label4 = new Label();
            input_equipamento = new TextBox();
            label2 = new Label();
            btn_cadastrar = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(208, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(679, 381);
            listView1.TabIndex = 49;
            listView1.UseCompatibleStateImageBehavior = false;
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
            btn_deletar.Location = new Point(110, 440);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(92, 37);
            btn_deletar.TabIndex = 47;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_imc
            // 
            btn_imc.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_imc.Location = new Point(154, 12);
            btn_imc.Name = "btn_imc";
            btn_imc.Size = new Size(132, 27);
            btn_imc.TabIndex = 46;
            btn_imc.Text = "Cadastrar treino";
            btn_imc.UseVisualStyleBackColor = true;
            // 
            // btn_showtreino
            // 
            btn_showtreino.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_showtreino.Location = new Point(12, 12);
            btn_showtreino.Name = "btn_showtreino";
            btn_showtreino.Size = new Size(136, 27);
            btn_showtreino.TabIndex = 45;
            btn_showtreino.Text = "Cadastrar aluno";
            btn_showtreino.UseVisualStyleBackColor = true;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 35;
            label4.Text = "Repetições";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // input_equipamento
            // 
            input_equipamento.Location = new Point(12, 96);
            input_equipamento.Name = "input_equipamento";
            input_equipamento.Size = new Size(190, 23);
            input_equipamento.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 33;
            label2.Text = "Equipamento";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(12, 440);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(92, 37);
            btn_cadastrar.TabIndex = 32;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // Professor_treino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(899, 525);
            Controls.Add(listView1);
            Controls.Add(btn_logout);
            Controls.Add(btn_deletar);
            Controls.Add(btn_imc);
            Controls.Add(btn_showtreino);
            Controls.Add(label4);
            Controls.Add(input_equipamento);
            Controls.Add(label2);
            Controls.Add(btn_cadastrar);
            Name = "Professor_treino";
            Text = "Professor_treino";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btn_logout;
        private Button btn_deletar;
        private Button btn_imc;
        private Button btn_showtreino;
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
        private TextBox input_equipamento;
        private Label label2;
        private Button btn_cadastrar;
    }
}