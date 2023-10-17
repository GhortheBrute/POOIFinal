using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIFinal
{
    internal class Curso
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public List<Disciplina> Disciplinas { get; private set; }
        public List<Aluno> Matriculados { get; private set; }

        public Curso(string nome, int codigo, Disciplina disciplina, Aluno aluno)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Disciplinas = new();
            this.Matriculados = new();
            AdicionarDisciplina(disciplina);
            MatricularAluno(aluno);
        }
        public Curso(string nome, int codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Disciplinas = new();
            this.Matriculados = new();
            
        }
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            this.Disciplinas.Add(disciplina);
        }
        public void MatricularAluno(Aluno aluno)
        {
            this.Matriculados.Add(aluno);
        }
        public void ExibirDisciplinas(Curso curso)
        {
            foreach (var disciplina in this.Disciplinas)
            {
                Console.WriteLine($"Disciplina:\t{disciplina.Titulo}\nProfessor:\t{disciplina.NomeProfessor}");
            }
        }

    }
}
