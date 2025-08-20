class Program
{
    static void Main(string[] args)
    {

        Jogador T1 = new Jogador(1, "Carlos", Posicao.Goleiro);
        Jogador T2 = new Jogador(2, "Baía", Posicao.Zagueiro);
        Jogador T3 = new Jogador(3, "Rafael", Posicao.Zagueiro);
        Jogador T4 = new Jogador(4, "Marcelo", Posicao.Lateral);
        Jogador T5 = new Jogador(5, "Lucas", Posicao.Lateral);
        Jogador T6 = new Jogador(6, "Gabriel", Posicao.Meia);
        Jogador T7 = new Jogador(7, "Bruno", Posicao.Meia);
        Jogador T8 = new Jogador(8, "Thiago", Posicao.Meia);
        Jogador T9 = new Jogador(9, "Pedro", Posicao.Atacante);
        Jogador T10 = new Jogador(10, "Fernando", Posicao.Atacante);
        Jogador T11 = new Jogador(11, "Ronaldo", Posicao.Atacante);

        // Reservas
        Jogador R1 = new Jogador(12, "Diego", Posicao.Goleiro);
        Jogador R2 = new Jogador(13, "Victor", Posicao.Zagueiro);
        Jogador R3 = new Jogador(14, "Leonardo", Posicao.Lateral);
        Jogador R4 = new Jogador(15, "Mateus", Posicao.Meia);
        Jogador R5 = new Jogador(16, "Caio", Posicao.Atacante);

        Time Lacoste = new Time("lacoste");
        Lacoste.AdicionarTitular(T1);
        Lacoste.AdicionarTitular(T2);
        Lacoste.AdicionarTitular(T3);
        Lacoste.AdicionarTitular(T4);
        Lacoste.AdicionarTitular(T5);
        Lacoste.AdicionarTitular(T6);
        Lacoste.AdicionarTitular(T7);
        Lacoste.AdicionarTitular(T8);
        Lacoste.AdicionarTitular(T9);
        Lacoste.AdicionarTitular(T10);
        Lacoste.AdicionarTitular(T11);

        // Adicionando reservas
        Lacoste.AdicionarReserva(R1);
        Lacoste.AdicionarReserva(R2);
        Lacoste.ExcluirReserva(R1);
        Lacoste.AdicionarReserva(R3);
        Lacoste.AdicionarReserva(R4);
        Lacoste.AdicionarReserva(R5);
        Lacoste.SubstituirTitular(T1, R2);
        Lacoste.SubstituirTitular(T11, R5);
        Lacoste.ExcluirReserva(R1);
        Lacoste.ExcluirTitular(T5);
        Lacoste.GerarArqTime("escalacao.txt");
        Console.WriteLine($"Apos escluir titular -------------");
        Lacoste.EscalacaoTime();




    }
}