using POOIFinal;
namespace POOIFinal

{
    public class Progam
    {
        static void Main(string[] args)
        {
            //Alunos
            Aluno aluno1 = new Aluno("Igor", 27, 347313);
            Aluno aluno2 = new Aluno("Jesus", 33, 845671);
            Aluno aluno3 = new Aluno("Camila", 18, 456981);

            //Cursos
            Curso matematica = new Curso("Matematica", 1);
            Curso administracao = new Curso("Administração", 2);
            Curso engenharia = new Curso("Engenharia", 3);

            //Professores
            Professor pedro = new Professor("Pedro", 40);
            Professor moises = new Professor("Moisés", 38);
            Professor aline = new Professor("Aline", 23);
            Professor carol = new Professor("Carol", 30);
            Professor gabriel = new Professor("Gabriel", 45);

            //Disciplinas
            Disciplina algebra = new Disciplina("Algebra Linear", 60, "ementa", pedro);
            Disciplina calculoI = new Disciplina("Cálculo I", 60, "Introdução ao cálculo e Diferenciais.", moises);
            Disciplina calculoII = new Disciplina("Cálculo II", 60, "Integrais e Operações.", moises);
            Disciplina intAdm = new Disciplina("Introdução à Administração", 44, "História da Administração", aline);
            Disciplina desenho = new Disciplina("Desenho", 32, "Desenho ergométrico", carol);
            Disciplina fisica = new Disciplina("Física", 60, "Introdução à Física", aline);
            Disciplina geografia = new Disciplina("Geografia", 32, "Introdução à Geografia", gabriel);

            //adiciona disciplinas ao curso
            matematica.AdicionarDisciplina(algebra);
            matematica.AdicionarDisciplina(calculoII);
            matematica.AdicionarDisciplina(calculoI);
            administracao.AdicionarDisciplina(intAdm);
            administracao.AdicionarDisciplina(desenho);
            engenharia.AdicionarDisciplina(fisica);
            engenharia.AdicionarDisciplina(calculoI);
            engenharia.AdicionarDisciplina(calculoII);
            engenharia.AdicionarDisciplina(geografia);

            //adiciona disciplinas ao professor
            pedro.AdicionarDisciplina(algebra);
            moises.AdicionarDisciplina(calculoI);
            moises.AdicionarDisciplina(calculoII);
            aline.AdicionarDisciplina(intAdm);
            carol.AdicionarDisciplina(desenho);
            aline.AdicionarDisciplina(fisica);
            gabriel.AdicionarDisciplina(geografia);

            //Console.Clear();
            Console.WriteLine("\nDisciplina");
            Console.WriteLine("Pedro");
            pedro.Imprimir();
            Console.WriteLine("\nMoisés");
            moises.Imprimir();
            Console.WriteLine("\nAline");
            aline.Imprimir();
            Console.WriteLine("\nCarol");
            carol.Imprimir();
            Console.WriteLine("\nGabriel");
            gabriel.Imprimir();

            Console.WriteLine("\nCurso");

            aluno1.MatricularCurso(matematica);
            aluno1.ExibeCursos();
            Console.WriteLine();
            aluno2.MatricularCurso(administracao);
            aluno2.ExibeCursos();
            Console.WriteLine();
            aluno3.MatricularCurso(engenharia);
            aluno3.ExibeCursos();

            matematica.ListarAlunos();
            Console.WriteLine();
            administracao.ListarAlunos();
            Console.WriteLine();
            engenharia.ListarAlunos();



        }
    }
}