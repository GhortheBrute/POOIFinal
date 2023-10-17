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
            MatricularAluno(aluno);
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
        }
        public static void SMatricularAluno(Aluno aluno)
        {
            Curso vazio = new();
            vazio.MatricularAluno(aluno);
        }
        public void MatricularAluno(Aluno aluno)
        {
            this.Matriculados.Add(aluno);
        }
        public void ExibirDisciplinas()
        {
            Console.WriteLine($"Curso:\t{this.Nome}");
            foreach (var disciplina in Disciplinas)
            {
                Console.WriteLine($"Disciplina:\t{disciplina.Titulo}\nProfessor:\t{disciplina.NomeProfessor}");
            }
        }

    }
}
