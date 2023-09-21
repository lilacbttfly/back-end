namespace Sesi.Model
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Turma { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} anos e estudo na turma {Turma}");
        }

        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {Nome} faltou hoje e teve {nr} faltas");
            nrFaltas = nrFaltas + nr;
        }

        public void ResumoFaltas()
        {
            Console.WriteLine($"O aluno tem {nrFaltas} faltas.");
        }
    }
}
