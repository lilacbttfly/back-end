public class Program
{
    public static void Main()
    {
        var pessoa1 = new
        {
            nome = "John F. Kennedy",
            idade = 46,
        };
        var pessoa2 = new
        {
            nome = "Marilyn Monroe",
            idade = 36,
        };
        Console.WriteLine("Marca do carro: ");
        string marca = Console.ReadLine();

        Console.WriteLine("Modelo do carro: ");
        string modelo = Console.ReadLine();

        Console.WriteLine("Ano do carro: ");
        string ano = Console.ReadLine();

        var possante = new
        {
            marca,
            modelo,
            ano
        };

        Console.WriteLine($"O carro {modelo} é da marca {marca} e do ano {ano}");

        Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a pessoa 2 se chama {pessoa2.nome}");
    }
}