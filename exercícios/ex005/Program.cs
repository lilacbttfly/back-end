class ex005{
    public static void Main(){
        ListaChurrasco();
    }

    public static void ListaChurrasco(){
        string[] produtos = new string[6];

        for (int i=0; i<produtos.Length; i++){
            Console.WriteLine("informe o produto");
            string produto = Console.ReadLine();
            produtos[i] = produto;
        }
        Array.Sort(produtos);

        foreach (string item in produtos){
            Console.WriteLine($"Item {item}");
        }
        {
            
        }
    }
}