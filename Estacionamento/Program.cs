class Program
{
    static void Main(string[] args)
    {
        Estacionamento park = new Estacionamento("park", 30);
        Console.WriteLine(park.estacionar("45587"));
        Console.WriteLine(park.estacionar("45584"));
        Console.WriteLine(park.estacionar("45487"));
        Console.WriteLine(park.estacionar("45227"));
        Console.WriteLine(park.estacionar("4444"));
              park.ExibirOcupacao();
        Console.WriteLine("Se estiver no estacionamentoa aparera um número de 0 a 30 , caso não aparecera -1");
        Console.WriteLine( park.BuscarNumVaga("4444"));
        park.Retirar("4444");
        Console.WriteLine("------------------------------");
        Console.WriteLine("apos retirar carro");
        park.ExibirOcupacao();


    }
}