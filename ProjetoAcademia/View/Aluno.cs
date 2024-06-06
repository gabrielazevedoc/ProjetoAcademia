using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoAcademia.View
{
    public partial class Aluno : Form
    {
        private string connectionString =
            System.Configuration.ConfigurationManager
            .ConnectionStrings["MySqlConnectionString"]
            .ConnectionString;

        private int AlunoId;
        public Aluno(int AlunoId)
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(connectionString);
            this.AlunoId = AlunoId;
            LoadAlunoData();
        }

        private void LoadAlunoData()
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT nome, cpf, plano FROM tb_alunos WHERE id=@AlunoId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AlunoId", AlunoId);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string nomeAluno = reader.GetString("nome");
                        string cpfAluno = reader.GetString("cpf");
                        string planoAluno = reader.GetString("plano");

                        ListViewItem item = new ListViewItem(nomeAluno);
                        item.SubItems.Add(cpfAluno);
                        item.SubItems.Add(planoAluno);

                        lv_aluno.Items.Add(item);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}
