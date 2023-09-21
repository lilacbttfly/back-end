class Program{
    public static void Main(){
        Console.WriteLine("Estou no método main.");
        Metodo();
        ImprimeDataHora();

        int resultadoSoma = Somar (3,8);
        Console.WriteLine(resultadoSoma);

        contagemRegressiva(5);

        JogoQuemSouEu();
    }    
    public static void Metodo(){
        Console.WriteLine("Estou no método / função.");
    }

    public static void ImprimeDataHora(){
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.Hour.ToString());
        Console.WriteLine(DateTime.Now.ToString());
    }

    public static int Somar(int n1, int n2){
        return n1 + n2;
    }
    
    public static void contagemRegressiva(int n){
        while (n>=0){
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("BOOOOOOOOOOOM!");
    }
       public static void JogoQuemSouEu(){
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("              Bem Vindo ao Jogo            ");
        Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine(""); //Linha em branco

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do{
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine("O número digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
            Console.WriteLine("O número sorteado é MENOR que o sorteado");
        }while (nrDigitado != nrSorteado);
         
         Console.WriteLine("Parabéns, você acertou!");
    }
}