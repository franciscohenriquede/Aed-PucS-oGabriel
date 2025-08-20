// See https://aka.ms/new-console-template for more infoclass Program
class Program
{

    static void Main(string[] args)
    {
        Console.Write("digite o lado1 , lado2, lado3 ");
        double l1 = Convert.ToDouble(Console.ReadLine());
        double l2 = Convert.ToDouble(Console.ReadLine());
        double l3 = Convert.ToDouble(Console.ReadLine());



        Triangulo t1 = new Triangulo(l1, l2, l3);
        t1.MostrarLados();
        Triangulo t2 = new Triangulo();
        t2.MostrarLados();
    
    }
}