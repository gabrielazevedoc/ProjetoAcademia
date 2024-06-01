using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, string cpf, int idade, DateTime nascimento, string sexo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Nascimento = nascimento;
            Sexo = sexo;
        }

        public static int CalcularIdade(DateTime Nascimento)
        {

            int idade = Convert.ToInt32(DateTime.Now.Year - Nascimento.Year);


            if (DateTime.Now.DayOfYear < Nascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
    }
}
  
