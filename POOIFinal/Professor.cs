using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIFinal
{
    internal class Professor : Pessoa
    {
        public List<Disciplina> Disciplinas { get; private set; }

        public Professor(string nome, int idade, Disciplina disciplina) : base(nome, idade)
        {
            this.Disciplinas = new();
            AdicionarDisciplina(disciplina);
        }
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            this.Disciplinas.Add(disciplina);
        }
        public void Imprimir()
        {

        }
    }
}
