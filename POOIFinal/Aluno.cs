using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIFinal
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; private set; }

        public Aluno(string nome, int idade, int matricula) : base(nome, idade)
        {
            this.Matricula = matricula;
        }
    }
}
