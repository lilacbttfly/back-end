public class program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("DIGITE UM NUMERO VÁLIDO");
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro: {erro.Message}");
        }
    }
}