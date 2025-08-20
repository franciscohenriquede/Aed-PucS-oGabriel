using Biblioteca;

namespace Biblioteca
{
    public class Livro
    {
        private string tituloLivro;
        private string autorLivro;
        private int anoPublicacao;
        private int numeroPaginas;
        private string status = "Disponivel";

        public Livro(string tituloLivro, string autorLivro, int anoPublicacao, int numeroPaginas)
        {
            this.tituloLivro = tituloLivro;
            this.autorLivro = autorLivro;
            this.anoPublicacao = anoPublicacao;
            this.numeroPaginas = numeroPaginas;
        }

        public void AlterarStatusParaEmprestado() => status = "Emprestado";
        public void AlterarStatusParaDisponivel() => status = "Disponivel";

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {tituloLivro}\nAutor: {autorLivro}\nAno: {anoPublicacao}\nPáginas: {numeroPaginas}\nStatus: {status}\n");
        }
    }

    public class Cliente
    {
        private string nomeCliente;
        private int numeroIdentificacaoCliente;
        private Livro[] livrosEmprestados;
        private int numeroLivrosEmprestados = 0;

        public Cliente(string nomeCliente, int numeroIdentificacaoCliente, int maxLivros)
        {
            this.nomeCliente = nomeCliente;
            this.numeroIdentificacaoCliente = numeroIdentificacaoCliente;
            livrosEmprestados = new Livro[maxLivros];
        }

        public void AlocarLivro(Livro livro)
        {
            if (numeroLivrosEmprestados < livrosEmprestados.Length)
            {
                livro.AlterarStatusParaEmprestado();
                livrosEmprestados[numeroLivrosEmprestados] = livro;
                numeroLivrosEmprestados++;
            }
            else
            {
                Console.WriteLine("Limite de livros emprestados atingido!");
            }
        }

        public void DevolverLivro(int indice)
        {
            if (indice >= 0 && indice < numeroLivrosEmprestados)
            {
                livrosEmprestados[indice].AlterarStatusParaDisponivel();
                // Remove o livro e reorganiza o array
                for (int i = indice; i < numeroLivrosEmprestados - 1; i++)
                    livrosEmprestados[i] = livrosEmprestados[i + 1];

                livrosEmprestados[numeroLivrosEmprestados - 1] = null;
                numeroLivrosEmprestados--;
            }
            else
            {
                throw new Exception("indice não existe");
            }
        }

        public void NomeCliente()
        {
            Console.WriteLine(nomeCliente);
        }

        public void ExibirLivrosEmprestados()
        {
            Console.WriteLine($"Cliente: {nomeCliente}");
            for (int i = 0; i < numeroLivrosEmprestados; i++)
            {
                livrosEmprestados[i].ExibirInformacoes();
            }
        }
    }

    public class Biblioteca
    {
        private Livro[] listaLivros;
        private Cliente[] listaClientes;
        private int idLivro = 0;
        private int idCliente = 0;

        public Biblioteca(int maxLivros, int maxClientes)
        {
            listaLivros = new Livro[maxLivros];
            listaClientes = new Cliente[maxClientes];
        }

        public void AdicionarLivro(Livro livro)
        {
            if (idLivro < listaLivros.Length)
            {
                listaLivros[idLivro++] = livro;
            }
        }

        public void AdicionarCliente(Cliente cliente)
        {
            if (idCliente < listaClientes.Length)
            {
                listaClientes[idCliente++] = cliente;
            }
        }

        public void ExibirListaDeLivros()
        {
            Console.WriteLine("------------------------------------------------------------------:");
            Console.WriteLine("Livros da Biblioteca:");
            foreach (var livro in listaLivros)
            {
                if (livro != null)
                    livro.ExibirInformacoes();
            }
        }

        public void ExibirListaDeClientes()
        {
            
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Lista de Clientes");
            foreach (var cliente in listaClientes)
            {
                 if (cliente != null)
                    cliente.NomeCliente();
            }
        }
    }
}
