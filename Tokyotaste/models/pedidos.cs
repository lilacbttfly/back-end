namespace Models
{
    public class Pedidos
    {
        public string Produto { get; set; }
        public int Valor { get; set; }
        public string Usuário { get; set; }
        public string FormaDePagamento { get; set; }

        public Pedidos(string produto, int valor, string usuário, string formaDePagamento)
        {
            this.Produto = produto;
            this.Valor = valor;
            this.Usuário = usuário;
            this.FormaDePagamento = formaDePagamento;
        }
    }
}
