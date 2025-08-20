public class Estacionamento
{
    private string nome;
    private int nunVagasLivres;

    private string[] vagas;


    public Estacionamento(string nome, int nunVagasLivres)
    {
        this.nome = nome;
        this.nunVagasLivres = nunVagasLivres;
        this.vagas = new string[nunVagasLivres];
    }


    public int estacionar(string placa)
    {
        int vagaEstacionada = -1;
        for (int i = 0; i < nunVagasLivres; i++)
        {
            if (vagas[i] == null)
            {
                vagas[i] = placa;
                vagaEstacionada = i;
                
                return vagaEstacionada;
            }
        }
        return vagaEstacionada;


    }
    //Retorna o número da vaga, ou seja, a posição do vetor vagas, ocupada pelo veículo com a placa informada como parâmetro
    public int BuscarNumVaga(string placa)

    {
        for (int i = 0; i < nunVagasLivres; i++)
        {
            if (vagas[i] == placa)
            {
                return i;
            }

        }
        return -1;
    }
    public void ExibirOcupacao()
    {
        foreach (var item in vagas.Select((placa, index) => new { placa, index }))
        {

            if (item.placa == null)
            {
                Console.WriteLine(" vaga " + item.index + " | Esta  vaga esta Livre");
            }
            else
            {
                Console.WriteLine(" vaga " + item.index + " | placa do carro Estacionado : " + item.placa);
            }
        }
    }
    public void Retirar(string placa)
    {
        bool CarroRetirado = false;
        {

            for (int i = 0; i < nunVagasLivres; i++)
            {
                if (vagas[i] == placa)
                {
                    vagas[i] = null;
                    CarroRetirado = true;
                    break;
                }

            }
            if (CarroRetirado == false)
                Console.WriteLine("Carro não encontrado");



        }
    }
}