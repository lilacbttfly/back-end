namespace Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

        public Usuario(string nome, string email, string senha, string rua, string bairro, int numero)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Numero = numero;
        }
    }
}
