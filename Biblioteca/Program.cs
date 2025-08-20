// See https://aka.ms/new-console-template for more information



namespace Biblioteca
{

    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca Saber = new Biblioteca(40, 40);
            Livro livro = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 1216);
            Livro livro2 = new Livro("o colisseu", "jota p", 5854, 300);
            Cliente clienteGold = new Cliente("pedro", 001, 3);
            Cliente clientecharp = new Cliente("saul", 002, 3);
            Saber.AdicionarCliente(clientecharp);
            Saber.AdicionarCliente(clienteGold);
            Saber.AdicionarLivro(livro);
            Saber.AdicionarLivro(livro2);
            Saber.ExibirListaDeLivros();
            clienteGold.AlocarLivro(livro);
            Saber.ExibirListaDeLivros();
            clienteGold.DevolverLivro(0);
            Saber.ExibirListaDeLivros();
            Saber.ExibirListaDeClientes();
            clientecharp.AlocarLivro(livro2);
            Saber.ExibirListaDeLivros();
        }



    }

}