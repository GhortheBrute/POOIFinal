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
            Professor moises = new Professor("Moisés", 38);


            Disciplina algebra = new Disciplina("Algebra Linear", 60, "ementa", pedro);
            Disciplina calculoI = new Disciplina("Cálculo I", 60, "Introdução ao cálculo e Diferenciais.", moises);
            Disciplina calculoII = new Disciplina("Cálculo II", 60, "Integrais e Operações.", moises);

            pedro.AdicionarDisciplina(algebra);
            moises.AdicionarDisciplina(calculoI);
            moises.AdicionarDisciplina(calculoII);

            Console.WriteLine("\nDisciplina");
            Console.WriteLine("Pedro");
            pedro.Imprimir();
            Console.WriteLine("\nMoisés");
            moises.Imprimir();
            Console.WriteLine("\nCurso");

            aluno1.MatricularCurso(matematica);
            aluno1.ExibeCursos();



        }
    }
}