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
        private int TreinoId;

        public Aluno(int AlunoId, int TreinoId)
        {
            InitializeComponent();
            this.AlunoId = AlunoId;
            this.TreinoId = TreinoId;
            LoadAlunoData(); 
            LoadTreinoData();
        }

        private void LoadAlunoData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT nome, cpf, idade, plano, sexo FROM tb_alunos WHERE id=@AlunoId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AlunoId", AlunoId);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string nomeAluno = reader.GetString("nome");
                        string cpfAluno = reader.GetString("cpf");
                        int idadeAluno = reader.GetInt32("idade");
                        string planoAluno = reader.GetString("plano");
                        string sexoAluno = reader.GetString("sexo");

                        ListViewItem item = new ListViewItem(nomeAluno);
                        item.SubItems.Add(cpfAluno);
                        item.SubItems.Add(idadeAluno.ToString());
                        item.SubItems.Add(planoAluno);
                        item.SubItems.Add(sexoAluno);

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

        private void LoadTreinoData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT objetivo, intensidade FROM tb_treino WHERE id=@TreinoId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TreinoId", TreinoId);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string objetivoTreino = reader.GetString("objetivo");
                        string intensidadeTreino = reader.GetString("intensidade");

                        ListViewItem item = new ListViewItem(objetivoTreino);
                        item.SubItems.Add(intensidadeTreino);

                        lv_treino.Items.Add(item);
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
