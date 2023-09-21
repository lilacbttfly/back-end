using Sesi.Model;

class Program
{
    public static void Main()
    {
        var aluno1 = new Aluno();
        aluno1.Nome = "Débora";
        aluno1.Idade = 16;
        aluno1.Turma = "2° E.M.";

        aluno1.Apresentar();

        aluno1.AdicionarFaltas(2); 
        aluno1.ResumoFaltas();  

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Bianca";
        aluno2.Idade = 16;
        aluno2.Turma = "2° E.M.";

        aluno2.Apresentar();

        aluno2.AdicionarFaltas(10); 
        aluno2.ResumoFaltas();    
    }
}