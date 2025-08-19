
using System;


public class Retangulo{

 private  double largura;

 private double comprimento;


public  Retangulo(double largura , double comprimento){
    this.largura=largura;
    this.comprimento=comprimento;
}

public double Largura{
    get{return largura;}
    set{largura=value;}
}
public double Comprimento{
    get{return comprimento;}
    set{Comprimento=value;}
}
 public double Perimetro(){
    return this.largura*2 + this.comprimento*2;
   
 }    
 public double Area(){
    return  this.largura * this.comprimento;
 }

}



class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual a largura do seu retângulo: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Qual o comprimento do seu retângulo: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());

        Retangulo q1 = new Retangulo(largura, comprimento);
         
        Console.WriteLine("Área: " + q1.Area());
        Console.WriteLine("Perímetro: " + q1.Perimetro());
    }
}
