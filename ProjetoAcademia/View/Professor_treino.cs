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
using ProjetoAcademia.Models;

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

        private void CreateDataTreino()
        {
            try
            {
                if (cb_objetivo.Text.Equals("") || cb_intensidade.Text.Equals(""))
                {
                    MessageBox.Show("Por favor, preencha todos os dados.");
                }
                else
                {
                    string objetivo = cb_objetivo.Text;
                    string intensidade = cb_intensidade.Text;

                    // Inserindo no banco de dados
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_treino (objetivo, intensidade) VALUES (@objetivo, @intensidade)", conn);
                        cmd.Parameters.AddWithValue("@objetivo", objetivo);
                        cmd.Parameters.AddWithValue("@intensidade", intensidade);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadDataTreino();

                    MessageBox.Show("Treino cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void DeleteData()
        {
            try
            {

                if (gv_treinos.SelectedRows.Count > 0)
                {
                    int treino_id = Convert.ToInt32(gv_treinos.SelectedRows[0].Cells["id"].Value);


                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_treino WHERE id=@treino_id", conn);
                        cmd.Parameters.AddWithValue("@treino_id", treino_id);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadDataTreino();

                    MessageBox.Show("Treino deletado do sistema com sucesso!");

                }
                else
                {
                    MessageBox.Show("Por favor, selecione um treino.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void gv_alunos_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_treinos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gv_treinos.SelectedRows[0];
                cb_objetivo.Text = row.Cells["objetivo"].Value.ToString();
                cb_intensidade.Text = row.Cells["intensidade"].ToString();
            }
        }

        private void UpdateData()
        {
            try
            {
                if (gv_treinos.SelectedRows.Count > 0)
                {
                    int treino_id = Convert.ToInt32(gv_treinos.SelectedRows[0].Cells["id"].Value);

                    if (cb_objetivo.Text.Equals("") && cb_intensidade.Text.Equals(""))
                    {
                        MessageBox.Show("Por favor, preencha todos os dados.");
                    }
                    else
                    {
                        string objetivo = cb_objetivo.Text;
                        string intensidade = cb_intensidade.Text;

                        // Inserindo no banco de dados
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("UPDATE tb_treino SET objetivo=@objetivo, intensidade=@intendidade WHERE id=@treino_id", conn);
                            cmd.Parameters.AddWithValue("@objetivo", objetivo);
                            cmd.Parameters.AddWithValue("@intensidade", intensidade);

                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        LoadDataTreino();

                        MessageBox.Show("Treino atualizado com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um treino para atualizar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void EraseFields()
        {
            cb_objetivo.Text = string.Empty;
            cb_intensidade.Text = string.Empty;
        }

        private void btn_showtreino_Click(object sender, EventArgs e)
        {
            Professor_aluno professor_Aluno = new Professor_aluno();
            professor_Aluno.Show();
            this.Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CreateDataTreino();
            EraseFields();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            UpdateData();
            EraseFields();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
