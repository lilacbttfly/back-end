    class Program
{
    public static string[] poltronas = new string[51];
    public static List<string> Passageiros = new List<string>();

    public static void Main()
    {
        Console.Clear();
        Console.WriteLine(" »»————————————  ★  ————————————««");
        Console.WriteLine("|---------------------------------|");
        Console.WriteLine("|-➼ Bem-Vindo ao Bus Lightyear! ➼-|");
        Console.WriteLine("|--Temos 50 lugares disponíveis.--|");
        Console.WriteLine("|---------------------------------|");
        Console.WriteLine("|------   _____________ ----------|");
        Console.WriteLine("|------ _/_|[][][][][] |----------|");
        Console.WriteLine("|------(      Lightyear|----------|");
        Console.WriteLine("|------ ==(O)===(O)==== ----------|");
        Console.WriteLine(" »»————————————  ★  ————————————««");
        Console.WriteLine("|---------------------------------|");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";

        do
        {
            Console.WriteLine(" »»————————————  ★  ————————————««");
            Console.WriteLine("|--------------MENU---------------|");
            Console.WriteLine("|1➼ para comprar passagem---------|");
            Console.WriteLine("|2➼ para poltronas disponíveis----|");
            Console.WriteLine("|3➼ para quantidade disponível----|");
            Console.WriteLine("|4➼ para mostrar passageiros------|"); // Corrigido de "3" para "4"
            Console.WriteLine("|0➼ para fechar o sistema---------|");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine(" »»————————————  ★  ————————————««");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine(" »»————————————  ★  ————————————««");
                    Console.WriteLine("|-------Obrigado, volte sempre!㋡ |");
                    Console.WriteLine(" »»————————————  ★  ————————————««");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                case "3":
                    Contador();
                    break;
                case "4":
                    MostrarPassageiros();
                    break;
                default:
                    Console.WriteLine(" »»————————————  ★  ————————————««");
                    Console.WriteLine("|---------Opção inválida ☹-------|");
                    Console.WriteLine(" »»————————————  ★  ————————————««");
                    Console.WriteLine("|---------------------------------|");
                    break;
            }
        } while (opcao != "0");
    }

    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens;

        while (!int.TryParse(Console.ReadLine(), out nrPassagens) || nrPassagens <= 0)
        {
            Console.WriteLine("Digite um número válido de passagens.");
        }

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPoltrona;

            while (!int.TryParse(Console.ReadLine(), out nrPoltrona) || nrPoltrona < 1 || nrPoltrona > 50)
            {
                Console.WriteLine("Digite um número de poltrona válido (entre 1 e 50).");
            }

            if (poltronas[nrPoltrona] != null)
            {
                Console.WriteLine("Essa poltrona já está ocupada. Por favor, escolha outra.");
                i--;
                continue;
            }

            Console.WriteLine("Informe o nome do passageiro:");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }

        Console.WriteLine("Obrigado pela(s) sua(s) compra(s)!");
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;
        Passageiros.Add(nome);
    }

    public static void PoltronasDisponiveis()
    {
        Console.WriteLine("Lista de Poltronas Disponíveis:");
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                Console.WriteLine($"Nº {i}");
            }
        }
    }

    public static void Contador()
    {
        int total = 0;
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                total = total + 1;
            }
        }
        Console.WriteLine("Atualmente temos " + total + " poltronas disponíveis.");
    }

    public static void MostrarPassageiros()
    {
        Console.WriteLine("Lista de Passageiros:");
        foreach (string passageiro in Passageiros)
        {
            Console.WriteLine(passageiro);
        }
    }
}
