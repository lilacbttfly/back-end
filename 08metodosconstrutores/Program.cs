using Models;

public class Program{
    public static void Main(){
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Laura Caixão";
        pessoa1.idade = 45;*/

        Pessoa pessoa1 = new Pessoa("Nina Caliente", 30);
        Pessoa pessoa2 = new Pessoa("Eliza Pancakes", 43);
        Pessoa pessoa3 = new Pessoa("Nancy Quero-Tudo-Que-É-Seu", 55);

        pessoa1.Cantar();
        pessoa2.Cantar();
        pessoa3.Cantar();
    }
}