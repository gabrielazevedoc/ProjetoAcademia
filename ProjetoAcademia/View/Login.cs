
using ProjetoAcademia.View;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace ProjetoAcademia
{
    public partial class Login : Form
    {
        private string connectionString =
            System.Configuration.ConfigurationManager
            .ConnectionStrings["MySqlConnectionString"]
            .ConnectionString;

        private enum LoginResult
        {
            Aluno,
            Professor,
            Invalido
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nome = input_name.Text;
            string CPF = input_CPF.Text;

            switch (AutenticarUsuario(nome, CPF))
            {
                case LoginResult.Aluno:
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT id FROM tb_alunos WHERE nome=@nome AND CPF=@CPF";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@CPF", CPF);

                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int AlunoId = reader.GetInt32("id");
                            Aluno aluno = new Aluno(AlunoId);
                            aluno.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Aluno não encontrado.");
                        }
                        conn.Close();
                    }
                    break;
                case LoginResult.Professor:
                    Professor_aluno professor_aluno = new Professor_aluno();
                    professor_aluno.Show();
                    this.Hide();
                    break;
                case LoginResult.Invalido:
                    MessageBox.Show("Nome ou CPF inválidos");
                    input_name.Text = string.Empty;
                    input_CPF.Text = string.Empty;
                    break;
            }
        }

        private LoginResult AutenticarUsuario(string nome, string CPF)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Verificar se a tabela de usuários está vazia
                    string checkEmptyQuery = "SELECT COUNT(1) FROM tb_alunos";
                    MySqlCommand checkEmptyCommand = new MySqlCommand(checkEmptyQuery, conn);
                    int userCount = Convert.ToInt32(checkEmptyCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        return LoginResult.Invalido;
                    }
                    else
                    {
                        if (nome == "admin" && CPF == "admin")
                        {
                            return LoginResult.Professor;
                        }
                    }

                    string query = "SELECT COUNT(1) FROM tb_alunos WHERE nome=@nome AND CPF=@CPF";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        return LoginResult.Aluno;
                    }
                    else
                    {
                        return LoginResult.Invalido;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    return LoginResult.Invalido;
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var confirmarSaida = MessageBox.Show("Tem certeza de que deseja sair?",
                                    "Confirmar Saída",
                                    MessageBoxButtons.YesNo);
            if (confirmarSaida == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}
