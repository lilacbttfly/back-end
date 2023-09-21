namespace Models{
    public class Pessoa{
        public string nome { get; set; }
        public int idade { get; set; }

        public void Cantar(){
            Console.WriteLine($"{nome} está cantando");
        }

        public Pessoa (string nomePessoa, int idadePessoa){
            this.nome = nomePessoa;
            this.idade = idadePessoa;
        }
    }
}