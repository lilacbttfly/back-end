using Models;
public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine(" »»————————————  ★  ————————————««");
        Console.WriteLine("|---------------------------------|");
        Console.WriteLine("|➼ Bem-Vindo ao Banco Cofrinho! ➼|");
        Console.WriteLine("|----Acesse sua conta corrente.---|");
        Console.WriteLine("|---------------------------------|");
        Console.WriteLine("|------------ [̲̅$̲̅(̲̅ιοο̲̅)̲̅$̲̅]-----------|");
        Console.WriteLine(" »»————————————  ★  ————————————««");
        Console.WriteLine("|---------------------------------|");
        Console.WriteLine("Digite o nome do titular:");
        string titular = Console.ReadLine();
        Console.WriteLine("|---------------------------------|");



        ContaCorrente conta1 = new ContaCorrente(titular);

        Menu(conta1);
    }

    public static void Menu(ContaCorrente conta)
    {
        string opcao = "";

        do
        {
            Console.WriteLine(" »»————————————  ★  ————————————««");
            Console.WriteLine("|--------------MENU---------------|");
            Console.WriteLine("|1➼ Checar seu saldo--------------|");
            Console.WriteLine("|2➼ Depositar qualquer valor------|");
            Console.WriteLine("|3➼ Sacar qualquer valor----------|");
            Console.WriteLine("|0➼ para sair da conta------------|");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine(" »»————————————  ★  ————————————««");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine(" »»————————————  ★  ————————————««");
                    Console.WriteLine("|---Obrigado, volte sempre!㋡ 🤙--|");
                    Console.WriteLine(" »»————————————  ★  ————————————««");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    conta.ConsultarSaldo();
                    break;
                case "2":
                    conta.Depositar();
                    break;
                case "3":
                    conta.Sacar();
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
}
