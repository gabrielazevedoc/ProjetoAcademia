using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.Models
{
    internal class Treino
    {
        public int Id { get; set; }
        public string Objetivo { get; set; }
        public string Intensidade { get; set; }

        public Treino()
        {

        }

        public Treino(int id, string objetivo, string intensidade)
        {
            Id = id;
            Objetivo = objetivo;
            Intensidade = intensidade;
        }
    }
}
