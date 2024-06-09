using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoAcademia.View
{
    public partial class Professor_treino : Form
    {
        private string connectionString =
          System.Configuration.ConfigurationManager
          .ConnectionStrings["MySqlConnectionString"]
          .ConnectionString;
        public Professor_treino()
        {
            InitializeComponent();
            LoadDataTreino();
        }

        private void LoadDataTreino()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapterTreino = new
                        MySqlDataAdapter("SELECT * FROM tb_treino", conn);
                    DataTable tableTreino = new DataTable();
                    adapterTreino.Fill(tableTreino);
                    gv_treinos.DataSource = tableTreino;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn_showtreino_Click(object sender, EventArgs e)
        {
            Professor_aluno professor_Aluno = new Professor_aluno();
            professor_Aluno.Show();
            this.Hide();
        }
    }
}
