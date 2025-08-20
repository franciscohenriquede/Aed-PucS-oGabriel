/*5 – Crie uma classe chamada "Triângulo" com os atributos "lado1", "lado2" e "lado3".
Implemente um construtor que receba os valores dos três lados como parâmetros e inicialize os
campos correspondentes. Crie um segundo construtor cujos valores iniciais sejam definidos
diretamente pelo programador, como valores default. */

public class Triangulo
{
    private double lado1;
    private double lado2;

    private double lado3;


    public Triangulo(double lado1, double lado2, double lado3)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }
    public Triangulo()
    {
        lado1 = 3; // valor default
        lado2 = 4; // valor default
        lado3 = 5; // valor default
    }

   public void MostrarLados()
    {
        Console.WriteLine($"Lado 1: {lado1}, Lado 2: {lado2}, Lado 3: {lado3}");
    }
}











