using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using POOIFinal;

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
            MatricularAluno(aluno, this);
        }
        public Curso(string nome, int codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Disciplinas = new();
            this.Matriculados = new();
            
            
        }
        public Curso()
        {
            
        }
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            this.Disciplinas.Add(disciplina);
            disciplina.Cursos.Add(this);
        }
        public static void SMatricularAluno(Aluno aluno, Curso curso)
        {
            Curso vazio = new();
            vazio.MatricularAluno(aluno, curso);
        }
        public void MatricularAluno(Aluno aluno, Curso curso)
        {
            curso.Matriculados.Add(aluno);
            Console.WriteLine("Aluno Matriculado.");
        }
        public void ExibirDisciplinas(Professor professor)
        {
            
            Console.WriteLine($"Disciplinas do {professor.Nome} no Curso:\t{this.Nome}");
            foreach (var disciplina in Disciplinas)
            {
                Console.WriteLine($"Disciplina:\t{disciplina.Titulo}\nProfessor:\t{disciplina.NomeProfessor}");
            }
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Lista de Matriculados no curso {this.Nome}");
            foreach(var aluno in this.Matriculados)
            {
                Console.WriteLine($"{aluno.Nome}");
            }
        }
        //public static Curso BuscarCurso(Disciplina disciplina)
        //{
        //    var curso = 
            
        //    return busca;
        //}

    }
}
