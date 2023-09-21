using System.Collections.Generic;
using Models;

public class Program
{
    public static void Main()
    {
        List<string> listaNomes = new List<string>();
        listaNomes.Add("maria clara");
        listaNomes.Add("beatriz");
        listaNomes.Add("debora");
        Console.WriteLine($"{listaNomes}");
        Console.WriteLine($"neste momento temos {listaNomes.Count} nrs");

        Console.WriteLine("-------------------------------");


        List<int> listaNumeros = new List<int>();
        listaNumeros.Add(10);
        listaNumeros.Add(3);
        listaNumeros.Add(4);


        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(80);
        Console.WriteLine($"neste momento temos {listaNumeros.Count} nrs");

        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        numeros.Add(10);

        foreach(int item in numeros){
            Console.WriteLine(item);
        }
        foreach(string nome in listaNomes){
            Console.WriteLine(nome);
        }

        listaAlunos.Add(new Aluno("Pabllo Vittar", 17));
        listaAlunos.Add(new Aluno("Cara do Perfume", 18));

        Console.WriteLine("Lista de alunos:");
        foreach (Aluno y in listaAlunos){
            Console.WriteLine($"O nome do Aluno é {y}");
        }
        
        var consulta = from aluno in listaAlunos
                        where aluno.idade > 18
                        orderby aluno.nome
                        select aluno;

                Console.WriteLine("Lista de alunos com mais de 18 anos:");
                foreach (var item in consulta)
                {
                    Console.WriteLine($"Nome do aluno: {item.nome}; idade: {item.idade}");
                }
    }
}