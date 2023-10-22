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
            //Console.WriteLine($"Aluno {this.Nome} matriculado no Curso {curso.Nome}.");
            curso.MatricularAluno(this);
        }

        public void ExibeCursos()
        {
            Console.WriteLine($"\nLista de cursos matriculados do aluno {this.Nome}:");
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"{curso.Nome}");
                Console.WriteLine("\nLista de Disciplinas:");

                //Aqui você está fazendo a pesquisa em todos os cursos em que ele está matriculado
                // mantendo assim, quando ele estiver em mais de um curso,
                // irá exibir todas as disciplinas de todos os cursos em um curso só
                // a exibição deve ser feita em cima da variável curso do foreach
                /* Verifique o aluno1
                 * como estava:
                var buscaDisciplinas = Cursos.SelectMany(a => a.Disciplinas).ToList();
                foreach (var disciplina in buscaDisciplinas)
                {
                    Console.WriteLine($"{disciplina.Titulo}");
                }
                */
                // como ficaria
                foreach (var disciplina in curso.Disciplinas)
                {
                    Console.WriteLine($"{disciplina.Titulo}");
                }
                //ou poderia ser feito utilizando string.Join();
                //Console.WriteLine("\n" + string.Join("\n", curso.Disciplinas.Select(x => x.Titulo)));
            }


        }
    }
}
