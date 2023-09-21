class DobroMetade
{
    public static void Main()
    {
        int resultadoDobro = Dobrar(3);
        int resultadoMetade = Dividir(8);
        Console.WriteLine(resultadoDobro);
        Console.WriteLine(resultadoMetade);
        TabuadaComWhile();
        Console.WriteLine(Somar (7, 8));
    }

    public static int Dobrar(int n1)
    {
        int dobro = n1 * 2;
        return(dobro);
    }


    public static int Dividir(int n2)
    {
      int metade = n2 / 2;
      return(metade);
    }

public static void TabuadaComWhile(){
        Console.WriteLine("Digite o numero:");
        int num = int.Parse(Console.ReadLine());
        int x = 1;
        do {
            Console.WriteLine($"{num} x {x} = {num*x}");
            x++;
        }
        while (x <= 10);
}


public static int Somar (int n1, int n2)
{
    int soma = n1 + n2;
    return soma;
}
}
