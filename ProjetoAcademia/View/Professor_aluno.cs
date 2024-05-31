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

        private void Professor_aluno_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
