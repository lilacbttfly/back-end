namespace Models
{
    public class Produto
    {
        public string NomeDoProduto { get; set; }
        public string Ingredientes { get; set; }
        public int Preco { get; set; }

        public Produto(string nomeDoProduto, string ingredientes, int preco)
        {
            this.NomeDoProduto = nomeDoProduto;
            this.Ingredientes = ingredientes;
            this.Preco = preco;
        }
    }
}
