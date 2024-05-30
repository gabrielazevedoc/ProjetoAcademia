
using ProjetoAcademia.View;
using System.Data.SqlClient;

namespace ProjetoAcademia
{
    public partial class Login : Form
    {
        private string connectionString =
            System.Configuration.ConfigurationManager
            .ConnectionStrings["MySqlConnectionString"]
            .ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nome = input_name.Text;
            string CPF = input_CPF.Text;

            if (autenticarUsuario(nome, CPF))
            {
                // Login successful, open the next form
                Aluno aluno = new Aluno();
                aluno.Show();
                this.Hide();
            }
            else
            {
                // Login failed, show error message
                MessageBox.Show("Nome ou CPF inválidos");
            }
        }

        private bool autenticarUsuario(string nome, string CPF)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Verificar se a tabela de usuários está vazia
                    string checkEmptyQuery = "SELECT COUNT(1) FROM tb_alunos";
                    SqlCommand checkEmptyCommand = new SqlCommand(checkEmptyQuery, conn);
                    int userCount = Convert.ToInt32(checkEmptyCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        // Se não houver usuários no banco de dados, permitir login com admin/admin
                        if (nome == "admin" && CPF == "admin")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    // Se houver usuários no banco de dados, verificar as credenciais fornecidas
                    string query = "SELECT COUNT(1) FROM tb_alunos WHERE nome=@nome AND CPF=@CPF";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@CPF", CPF);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
    }
    
}
