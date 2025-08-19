/* – Crie uma classe chamada "Livro" com os atributos "título", "autor", "anoPublicação" e
“Gênero”. Adicione um método para exibir as informações completas do livro. Adicione um
segundo método que retorna true caso um determinado livro seja de ficção e false, caso
contrário. */


public class Livro
{
    private string titulo;
    private string autor;

    private double anoPublicacao;

    private string genero;

    public Livro(string titulo, string autor, double anoPublicação, string genero)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anoPublicacao = anoPublicação;
        this.genero= genero;
    }

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }

    }

    public double AnoPublicação
    {
        get { return anoPublicacao; }
        set { anoPublicacao = value; }

    }
    public string Genero
    {
        get { return genero; }
        set { genero = value; }

    }
    public string Autor
    {
        get { return autor; }
        set { autor = value; }

    }
    public void Exibirinformacao()
    {
        Console.WriteLine($"Título: {titulo}\nAutor: {autor}\nAno: {anoPublicacao}\nGênero: {genero}");
    }
    public bool EhFiccao()
    {
        if (genero == "ficacao")
        {
            return true;
        }
        else
        {
            return false;
      }   }
   
 
}