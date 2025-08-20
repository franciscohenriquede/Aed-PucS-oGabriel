
public enum Posicao
{
    Goleiro,
    Zagueiro,
    Lateral,
    Meia,
    Atacante
}
public class Jogador
{
    // Atributos privados
    private int numero;
    private string nome;
    private Posicao posicao;
    // Construtor
    public Jogador(int numero, string nome, Posicao posicao)
    {
        this.numero = numero;
        this.nome = nome;
        this.posicao = posicao;
    }


    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public Posicao PosicaoJogador
    {
        get { return posicao; }
        set { posicao = value; }
    }

}
public class Time
{
    private string name;
    private Jogador[] titulares = new Jogador[0];
    private Jogador[] reserva = new Jogador[0];

    private int quantTitulares;



    private int quantReservas;



    public Time(string name)
    {
        this.name = name;
        this.quantReservas = 0;
        this.quantTitulares = 0;

    }

    public bool AdicionarTitular(Jogador jogador)
    {
        Jogador[] novo = new Jogador[quantTitulares + 1];
        for (int i = 0; i < quantTitulares; i++)
        {
            novo[i] = titulares[i];
        }

        if (quantTitulares < 11)
        {
            novo[quantTitulares] = jogador;
            titulares = novo;
            quantTitulares++;

            return true;
        }
        else return false;
    }

    public bool AdicionarReserva(Jogador jogador)
    {
        Jogador[] novo = new Jogador[quantReservas + 1];
        for (int i = 0; i < quantReservas; i++)
        {
            novo[i] = reserva[i];
        }

        if (quantReservas < 12)
        {
            novo[quantReservas] = jogador;
            reserva = novo;
            quantReservas++;
            return true;
        }
        else return false;
    }
    public bool SubstituirTitular(Jogador nomeTitular, Jogador NomeReserva)
    {
        int indiceReservar = -1;
        int i = -1;

        // Procurar jogador na reserva
        foreach (var jogador in reserva)
        {
            i++;
            if (jogador != null && jogador.Nome == NomeReserva.Nome)
            {
                indiceReservar = i;
                break;
            }
        }

        if (indiceReservar == -1)
        {
            Console.WriteLine(NomeReserva.Nome + " não existe na reserva");
            return false;
        }

        int indiceTitular = -1;
        int j = -1;

        // Procurar titular
        foreach (var jogador in titulares)
        {
            j++;
            if (jogador != null && jogador.Nome == nomeTitular.Nome)
            {
                indiceTitular = j;
                break;
            }
        }

        if (indiceTitular == -1)
        {
            Console.WriteLine(nomeTitular.Nome + " não existe entre os titulares");
            return false;
        }

        // Troca os jogadores
        titulares[indiceTitular] = reserva[indiceReservar];
        reserva[indiceReservar] = nomeTitular;

        return true;
    }


    public bool SubstituirReservarPorNovoJogador(Jogador NomeNovoJogador, Jogador NomeReserva)
    {
        int i = -1;
        int indiceReserva = -1;
        foreach (var jogador in reserva)
        {
            i++;
            if (NomeReserva.Nome == jogador.Nome)
            {
                indiceReserva = i;
            }
            else
            {
                Console.WriteLine("reserva não existe");
                return false;
            }
        }
        if (indiceReserva == -1)
        {
            return false;
        }
        reserva[indiceReserva] = NomeNovoJogador;
        return true;
    }

    public bool ConsultarReservar(Jogador NomeReserva)
    {
        foreach (var jogador in reserva)
        {
            if (NomeReserva.Nome == jogador.Nome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;
    }

    public void ExcluirTitular(Jogador NomeJogador)
    {
        int indiceTitular = -1;

        // Procurar o jogador
        for (int i = 0; i < quantTitulares; i++)
        {
            if (titulares[i].Nome == NomeJogador.Nome)
            {
                indiceTitular = i;
                break;
            }
        }

        // Se não encontrou, sai
        if (indiceTitular == -1)
        {
            Console.WriteLine("Jogador não encontrado entre os titulares.");
            return;
        }


        // Criar novo array com tamanho menor
        Jogador[] novo = new Jogador[quantTitulares - 1];

        // Copiar os elementos antes do índice
        for (int i = 0; i < indiceTitular; i++)
        {
            novo[i] = titulares[i];
        }

        // Copiar os elementos depois do índice
        for (int i = indiceTitular + 1; i < quantTitulares; i++)
        {
            novo[i - 1] = titulares[i];
        }

        // Substituir o array antigo
        titulares = novo;

        // Atualizar contador
        quantTitulares--;

        Console.WriteLine($"{NomeJogador.Nome} foi removido dos titulares.");
    }

    public void ExcluirReserva(Jogador jogador)
    {
        int indiceReserva = -1;
        //procurandoJogador
        for (int i = 0; i < quantReservas; i++)
        {
            if (reserva[i].Nome == jogador.Nome)
            {
                indiceReserva = i;
                break;
            }

        }
        if (indiceReserva == -1)
        {
            Console.WriteLine("Jogador não encontrado entre os Reservas.");
            return;
        }
        Jogador[] novo = new Jogador[quantReservas - 1];

        for (int i = 0; i < indiceReserva; i++)
        {
            novo[i] = reserva[i];
        }

        for (int i = indiceReserva; i < quantReservas - 1; i++)
        {
            novo[i] = reserva[i + 1];
        }

        reserva = novo;
        quantReservas--;




    }





    public void EscalacaoTime()
    {

        Console.WriteLine("Escalaão time Titular");
        foreach (var jogador in titulares)
        {
            if (jogador != null)
            {
                Console.WriteLine("nome :" + jogador.Nome + " ---> Posicao :  " + jogador.PosicaoJogador);
            }
        }
        Console.WriteLine("Reserva");
        foreach (var jogador in reserva)
        {
            if (jogador != null)
            {
                Console.WriteLine("nome :" + jogador.Nome + " ---> Posicao :  " + jogador.PosicaoJogador);
            }
        }

    }


public void GerarArqTime(string nomeArquivo)
{
    try
    {
        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            writer.WriteLine($"Time: {name}");
            writer.WriteLine("=============================");
            writer.WriteLine("Titulares:");
            
            foreach (var jogador in titulares)
            {
                if (jogador != null)
                {
                    writer.WriteLine($"Número: {jogador.Numero}, Nome: {jogador.Nome}, Posição: {jogador.PosicaoJogador}");
                }
            }

            writer.WriteLine();
            writer.WriteLine("Reservas:");

            foreach (var jogador in reserva)
            {
                if (jogador != null)
                {
                    writer.WriteLine($"Número: {jogador.Numero}, Nome: {jogador.Nome}, Posição: {jogador.PosicaoJogador}");
                }
            }
        }

        Console.WriteLine($"Arquivo '{nomeArquivo}' gerado com sucesso!");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro ao gerar arquivo: " + ex.Message);
    }
}









}
