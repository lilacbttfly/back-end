class Animal
{
    public string Cor { get; set; } 
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {Cor} fazendo algum som");
    }
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"O cachorro {Cor} está latindo");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"O gato {Cor} está miando");
    }

    public void Ronronar()
    {
        Console.WriteLine($"O gato {Cor} está ronronando");
    }
}

class Program
{
    public static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.Cor = "Preto";
        animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.Cor = "Branco";
        meuCachorro.EmitirSom();

        Gato meuGato = new Gato();
        meuGato.Cor = "Cinza"; 
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}
