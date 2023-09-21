namespace Models
{
    public class Categorias
    {
        public string Barca { get; set; }
        public string Peça { get; set; }
        public string Rodízio { get; set; }
        public string Bebidas { get; set; }
        public string Porção { get; set; }
        public string Sobremesa { get; set; }

        public Categorias(string barca, string peça, string rodízio, string bebidas, string porção, string sobremesa)
        {
            this.Barca = barca;
            this.Peça = peça;
            this.Rodízio = rodízio;
            this.Bebidas = bebidas;
            this.Porção = porção;
            this.Sobremesa = sobremesa;
        }
    }
}
