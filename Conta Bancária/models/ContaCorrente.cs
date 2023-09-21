namespace Models
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Saldo { get; set; }

        public ContaCorrente(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        public void Depositar()
        {
            Console.WriteLine("Digite o valor que deseja depositar:");
            int deposito = int.Parse(Console.ReadLine());
            int saldo = Saldo; 
            saldo += deposito;
            Saldo = saldo; 
            Console.WriteLine($"Você depositou {deposito},");
            Console.WriteLine($"Seu saldo atual é de {Saldo}.");
            Console.WriteLine( "|---------------------------------|");

        }

        public void Sacar()
        {
            Console.WriteLine("Digite o valor que deseja sacar:");
            int saque = int.Parse(Console.ReadLine());
            if (saque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                int saldo = Saldo; 
                saldo -= saque;
                Saldo = saldo; 
                Console.WriteLine($"Você sacou {saque}. Seu novo saldo é de {Saldo}");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo atual é de {Saldo}");
        }
    }
}
