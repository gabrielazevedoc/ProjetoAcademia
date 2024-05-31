using ProjetoAcademia.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.Models
{
    public class Aluno : Pessoa
    {
        public int Id { get; set; }
        public string Plano { get; set; }
        public Treino Treino { get; set; }

        public Aluno(string nome, string cpf, int idade, string sexo, int id, string plano, Treino _treino) : base(nome, cpf, idade, sexo)
        {
            Id = id;
            Plano = plano;
            Treino = _treino;
        }
    }

}
