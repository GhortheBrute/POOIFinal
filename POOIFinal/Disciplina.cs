using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOIFinal;

namespace POOIFinal
{
    internal class Disciplina
    {
        public string Titulo { get; private set; }
        public int CargaHoraria { get; private set; }
        public string Ementa { get; private set; }
        public Professor NomeProfessor { get; private set; }
        public List<Curso> Cursos { get; private set; }

        public Disciplina(string titulo, int cargaHoraria, string ementa, Professor professor)
        {
            this.Titulo = titulo;
            this.CargaHoraria = cargaHoraria;
            this.Ementa = ementa;
            this.NomeProfessor = professor;
            this.Cursos = new();
        }
    }
}
