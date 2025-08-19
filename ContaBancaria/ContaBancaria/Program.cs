// See https://aka.ms/new-console-template for more information
public class ContaBancaria
{
    private string titular;
    private double saldo;

    private double limite = -10000;



    public ContaBancaria(string titular)
    {
        this.titular = titular;
        this.saldo = 0;
    }

    public double Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }


    public void Depositar(double saldo)
    {
        this.saldo += saldo;
        Console.WriteLine(saldo);
    }
    public void Sacar(double valor)
    {
        bool verifica = VerificarLimite(valor);
        if (verifica)
        {
            this.saldo -= valor;
        }
        else Console.WriteLine("valor limite excedido");
    }
    public bool VerificarLimite(double valor)
    {


        return (saldo - valor) >= limite;
    }

    public string ExibirSaldo()
    {
        return titular + " seu saldo é de " + saldo.ToString();
    }



}


class Program
{
    static void Main(string[] args)
    {


        ContaBancaria Qw = new ContaBancaria("Mauricio");
        Qw.Depositar(40000);
        Qw.Sacar(60000);
        Console.WriteLine(Qw.ExibirSaldo());
    }
}