namespace ProjetoAcademia.View
{
    partial class Aluno_screen
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
            panel1 = new Panel();
            label1 = new Label();
            btn_showtreino = new Button();
            btn_imc = new Button();
            button3 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_sair = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(365, 33);
            label1.Name = "label1";
            label1.Size = new Size(234, 37);
            label1.TabIndex = 0;
            label1.Text = "Área do Aluno";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_showtreino
            // 
            btn_showtreino.Location = new Point(44, 146);
            btn_showtreino.Name = "btn_showtreino";
            btn_showtreino.Size = new Size(199, 37);
            btn_showtreino.TabIndex = 1;
            btn_showtreino.Text = "Visualizar treino";
            btn_showtreino.UseVisualStyleBackColor = true;
            // 
            // btn_imc
            // 
            btn_imc.Location = new Point(44, 213);
            btn_imc.Name = "btn_imc";
            btn_imc.Size = new Size(199, 37);
            btn_imc.TabIndex = 2;
            btn_imc.Text = "Calcular IMC";
            btn_imc.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(44, 279);
            button3.Name = "button3";
            button3.Size = new Size(199, 54);
            button3.TabIndex = 3;
            button3.Text = "Calcular Taxa de metabolismo basal";
            button3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(313, 146);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(573, 351);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(44, 460);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(82, 37);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            // 
            // Aluno_screen
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(929, 547);
            Controls.Add(btn_sair);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button3);
            Controls.Add(btn_imc);
            Controls.Add(btn_showtreino);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Aluno_screen";
            Text = "Treino";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_showtreino;
        private Button btn_imc;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_sair;
    }
}