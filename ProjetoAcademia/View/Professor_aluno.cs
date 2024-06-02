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

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new
                    MySqlDataAdapter("SELECT * FROM tb_alunos", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gv_alunos.DataSource = table;
            }
        }

        private void CreateData()
        {
            string nome = input_nome.Text;
            string CPF = input_CPF.Text;
            DateTime nascimento = input_data.Value;
            string plano = input_plano.Text;
            string sexo = input_sexo.Text;
            string treino = input_treino.Text;

            int idade = Pessoa.CalcularIdade(nascimento);

            if (idade < 0 && idade > 120)
            {
                MessageBox.Show("Data de nascimento inválida!");
                return;
            }


            // Inserindo no banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_alunos (nome, CPF, idade, plano, sexo, treino_id) VALUES (@nome, @CPF, @idade, @plano, @sexo, @treino)", conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@CPF", CPF);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@plano", plano);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@treino", treino);
                cmd.ExecuteNonQuery();
            }

            LoadData();

            MessageBox.Show("Aluno cadastrado com sucesso!");
        }

        private void Professor_aluno_Load(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
