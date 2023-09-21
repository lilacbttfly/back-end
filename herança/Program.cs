using Sesi.Models;
class Program{
    public static void Main(){
        Gato meuGato = new Gato();
        meuGato.Nome = "feinho";
        meuGato.Cor = "Cinza";
        meuGato.Idade = 1;
        meuGato.Especie = "Azul russo";
        meuGato.Sexo = "Masculino";
        meuGato.Peso = 3;

        Peixe meuPeixe = new Peixe();
        meuPeixe.Especie = "Escama de pérola";
        meuPeixe.Cor = "Mesclado";
        meuPeixe.Tamanho = 0.10M;
        meuPeixe.Nome = "Riff";    
    }
}