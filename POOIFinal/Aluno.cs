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
        public List<Curso> Cursos { get; private set; }

        public Aluno(string nome, int idade, int matricula, Curso curso) : base(nome, idade)
        {
            this.Cursos = new();
            this.Matricula = matricula;
            MatricularCurso(curso);

        }
        public void MatricularCurso(Curso curso)
        {
            this.Cursos.Add(curso);
            Console.WriteLine($"Aluno {this.Nome} matriculado no Curso {curso.Nome}.");
        }

        public void ExibeCursos()
        {
            Console.WriteLine("Lista de cursos matriculados:");
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"{curso.Nome}");
            }


        }
    }
}
