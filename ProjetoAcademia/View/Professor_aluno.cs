using MySql.Data.MySqlClient;
using ProjetoAcademia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia.View
{
    public partial class Professor_aluno : Form
    {
        private string connectionString =
           System.Configuration.ConfigurationManager
           .ConnectionStrings["MySqlConnectionString"]
           .ConnectionString;
        public Professor_aluno()
        {
            InitializeComponent();
        }

        private void LoadDataAlunos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapterAlunos = new
                        MySqlDataAdapter("SELECT * FROM tb_alunos", conn);
                    DataTable tableAlunos = new DataTable();
                    adapterAlunos.Fill(tableAlunos);
                    gv_alunos.DataSource = tableAlunos;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
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
                    gv_treino.DataSource = tableTreino;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void CreateData()
        {
            try
            {
                string nome = input_nome.Text;
                string CPF = input_CPF.Text;
                DateTime nascimento = input_data.Value;
                string plano = input_plano.Text;
                string sexo = input_sexo.Text;

                int idade = Pessoa.CalcularIdade(nascimento);

                if (idade < 0 && idade > 120)
                {
                    MessageBox.Show("Data de nascimento inválida!");
                    return;
                }

                if (gv_treino.SelectedRows.Count > 0)
                {
                    int treino_id = Convert.ToInt32(gv_treino.SelectedRows[0].Cells["id"].Value);


                    // Inserindo no banco de dados
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_alunos (nome, CPF, idade, plano, sexo, treino_id) VALUES (@nome, @CPF, @idade, @plano, @sexo, @treino_id)", conn);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@CPF", CPF);
                        cmd.Parameters.AddWithValue("@idade", idade);
                        cmd.Parameters.AddWithValue("@plano", plano);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@treino_id", treino_id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadDataAlunos();

                    MessageBox.Show("Aluno cadastrado com sucesso!");
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

        private void DeleteData()
        {
            try
            {

                if (gv_alunos.SelectedRows.Count > 0)
                {
                    int aluno_id = Convert.ToInt32(gv_alunos.SelectedRows[0].Cells["id"].Value);


                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_alunos WHERE id=@aluno_id", conn);
                        cmd.Parameters.AddWithValue("@aluno_id", aluno_id);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadDataAlunos();

                    MessageBox.Show("Aluno deletado do sistema com sucesso!");

                }
                else
                {
                    MessageBox.Show("Por favor, selecione um aluno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void gv_alunos_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_alunos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gv_alunos.SelectedRows[0];
                input_nome.Text = row.Cells["nome"].Value.ToString();
                input_CPF.Text = row.Cells["CPF"].Value.ToString();
                int idade = Convert.ToInt32(row.Cells["idade"].Value);
                input_data.Value = ConverterIdadeParaDataNascimento(idade);
                input_plano.Text = row.Cells["plano"].Value.ToString();
                input_sexo.Text = row.Cells["Sexo"].Value.ToString();
            }
        }

        public static DateTime ConverterIdadeParaDataNascimento(int idade)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataNascimento = dataAtual.AddYears(-idade);

            // Ajuste a data de nascimento se o aniversário deste ano ainda não tiver ocorrido
            if (dataNascimento > dataAtual)
            {
                dataNascimento = dataNascimento.AddYears(-1);
            }

            return dataNascimento;
        }

        private void UpdateDataAlunos()
        {
            try
            {
                if (gv_alunos.SelectedRows.Count > 0)
                {
                    string nome = input_nome.Text;
                    string CPF = input_CPF.Text;
                    DateTime nascimento = input_data.Value;
                    string plano = input_plano.Text;
                    string sexo = input_sexo.Text;

                    int aluno_id = Convert.ToInt32(gv_alunos.SelectedRows[0].Cells["id"].Value);

                    int idade = Pessoa.CalcularIdade(nascimento);

                    if (idade < 0 && idade > 120)
                    {
                        MessageBox.Show("Data de nascimento inválida!");
                        return;
                    }

                    if (gv_treino.SelectedRows.Count > 0)
                    {
                        int treino_id = Convert.ToInt32(gv_treino.SelectedRows[0].Cells["id"].Value);


                        // Atualizando o banco de dados
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("UPDATE tb_alunos SET nome=@nome, CPF=@CPF, idade=@idade, plano=@plano, sexo=@sexo, treino_id=@treino_id WHERE id=@aluno_id", conn);
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@CPF", CPF);
                            cmd.Parameters.AddWithValue("@idade", idade);
                            cmd.Parameters.AddWithValue("@plano", plano);
                            cmd.Parameters.AddWithValue("@sexo", sexo);
                            cmd.Parameters.AddWithValue("@treino_id", treino_id);
                            cmd.Parameters.AddWithValue("@aluno_id", aluno_id);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        LoadDataAlunos();

                        MessageBox.Show("Aluno atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecione um treino.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um aluno para atualizar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Professor_aluno_Load(object sender, EventArgs e)
        {
            LoadDataAlunos();
            LoadDataTreino();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CreateData();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void btn_cadTreino_Click(object sender, EventArgs e)
        {
            Professor_treino professor_Treino = new Professor_treino();
            professor_Treino.Show();
            this.Hide();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            UpdateDataAlunos();
        }
    }
}
