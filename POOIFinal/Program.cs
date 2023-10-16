using POOIFinal;
namespace POOIFinal

{
    public class Progam
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Igor", 27, 347313);

            Curso matematica = new Curso("Matematica", 1);

            Professor pedro = new Professor("Pedro", 40);

            Disciplina algebra = new Disciplina("Algebra Linear", 60, "ementa", pedro);

            pedro.AdicionarDisciplina(algebra);
            pedro.Imprimir();


            aluno1.MatricularCurso(matematica);
            aluno1.ExibeCursos();



        }
    }
}