using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOIFinal;

namespace POOIFinal
{
    internal class Professor : Pessoa
    {
        public List<Disciplina> Disciplinas { get; private set; }
        public List<Curso> Cursos { get; private set; }

        public Professor(string nome, int idade, Disciplina disciplina) : base(nome, idade)
        {
            this.Disciplinas = new();
            AdicionarDisciplina(disciplina);
        }

        public Professor(string nome, int idade) : base(nome, idade)
        {
            this.Disciplinas = new();
            this.Cursos = new();

        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
           Disciplinas.Add(disciplina);
           
           Console.WriteLine($"Professor {this.Nome} atribuida a disciplina: {disciplina.Titulo}.");
           
        }
        //public void CadastraCurso(Disciplina disciplina)
        //{
        //    if (Curso.BuscarCurso == null)
        //    {
        //        Console.WriteLine("Curso não encontrado");
        //    }
        //    else
        //    {
        //        Cursos.Add(Curso.BuscarCurso(disciplina));
        //    }
            
        //}
        public void Imprimir()
        {
            Console.WriteLine($"Lista de disciplinas do professor {this.Nome}:");
            foreach (var disciplina in Disciplinas)
            {
                Console.WriteLine($"{disciplina.Titulo}");
                
            //var buscaCurso = Curso.BuscarCurso;
            //foreach (var materia in buscaCurso)
            //{
            //    Console.WriteLine($"{materia.Nome}");
            //}

            }
            foreach (var curso in Cursos)
            {
                Console.WriteLine(curso.Nome);
            }




        }
    }
}
