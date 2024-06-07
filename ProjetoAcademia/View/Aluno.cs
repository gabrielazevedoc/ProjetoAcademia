using MySql.Data.MySqlClient;

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
            this.AlunoId = AlunoId;
            ConfigureListView();
            LoadAlunoData(); 
        }

        private void ConfigureListView()
        {
            lv_aluno.FullRowSelect = true;
            lv_aluno.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lv_aluno.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            lv_aluno.Columns.Add("Plano", 100, HorizontalAlignment.Left);
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
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

    }
}
