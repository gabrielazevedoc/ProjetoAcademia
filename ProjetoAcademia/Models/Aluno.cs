using ProjetoAcademia.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.Models
{
    internal class Aluno : Pessoa
    {
        public int Id { get; set; }
        public string Plano { get; set; }
        public Treino treino { get; set; }

        public Aluno() { }

        public Aluno(string nome, string cpf, int idade, DateTime nascimento, string sexo, int id, string plano, Treino _treino) 
            : base(nome, cpf, idade, nascimento, sexo)
        {
            Id = id;
            Plano = plano;
            treino = _treino;
        }
    }

}
