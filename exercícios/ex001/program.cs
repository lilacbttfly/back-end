        Console.WriteLine("Digite o nome do aluno:");
        string nomeAluno = Console.ReadLine();

        Console.WriteLine("Digite a primeira nota:");
        int nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        int nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        int nota3 = int.Parse(Console.ReadLine());

        int media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine($"Sua média foi {media} e você foi aprovado. Parabéns {nomeAluno}!");
        }
        else
        {
            Console.WriteLine($"Sua média foi {media} e você não foi aprovado. Sinto muito {nomeAluno}.");
        }
