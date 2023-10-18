using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOIFinal;

namespace POOIFinal
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; private set; }
        public List<Curso> Cursos { get; private set; }

        public Aluno(string nome, int idade, int matricula, Curso curso) : base(nome, idade)
        {
            this.Cursos = new();
            this.Matricula = matricula;
            MatricularCurso(curso);

        }
        public Aluno(string nome, int idade, int matricula, string nomeCurso, int codCurso) : base(nome, idade)
        {
            this.Cursos = new();
            this.Matricula = matricula;
            

        }
        public Aluno(string nome, int idade, int matricula) : base(nome, idade)
        {
            this.Cursos = new();
            this.Matricula = matricula;
            

        }
        public void MatricularCurso(Curso curso)
        {
            this.Cursos.Add(curso);
            Console.WriteLine($"Aluno {this.Nome} matriculado no Curso {curso.Nome}.");
            Curso.SMatricularAluno(this, curso);
        }

        public void ExibeCursos()
        {
            Console.WriteLine($"\nLista de cursos matriculados do aluno {this.Nome}:");
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"{curso.Nome}");
                Console.WriteLine("\nLista de Disciplinas:");
                var buscaDisciplinas = Cursos.SelectMany(a => a.Disciplinas).ToList();
                foreach (var disciplina in buscaDisciplinas)
                {
                    Console.WriteLine($"{disciplina.Titulo}");
                }
                
            }


        }
    }
}
