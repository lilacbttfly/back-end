using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        gravarArquivos();
        lerArquivos();
    }

    public static void gravarArquivos()
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter("arquivo.txt", true))
            {
                Console.WriteLine("Digite seu texto");
                string texto = Console.ReadLine(); 
                arquivo.WriteLine(texto); 
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro no arquivo: {erro.Message}");
        }
    }

    public static void lerArquivos()
    {
        try
        {
            using (StreamReader arquivo = new StreamReader("arquivo.txt"))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro na leitura do arquivo: {erro.Message}");
        }
    }
}
