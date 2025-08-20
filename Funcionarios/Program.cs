class Program
{
    static void Main(string[] args)
    {

        Funcionario PauloSenior = new Funcionario("paulo", "senior");
        PauloSenior.Mensagem();

        Funcionario franciscoJunior = new Funcionario("francisco", "junior");
        franciscoJunior.Mensagem();

        Funcionario DevErrado = new Funcionario("Juanno", "errado");
        DevErrado.Mensagem();

    }


}