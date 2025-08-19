class Program
{
    static void Main(string[] args)
    {


        Livro LivroUM = new Livro("Lama", "florDeLotus", 2005, "Religiao");
        LivroUM.Exibirinformacao();
    Console.WriteLine(LivroUM.EhFiccao());
     
    }
}