  /*Crie uma classe chamada "Aluno" com os atributos "nome", "matrícula" e "notas". Adicione
um método para calcular a média das notas do aluno. Obs: o atributo notas, deve ser privado.

*/

public class Aluno
{
    private string name;
    private double matricula;

    private double[] notas;

    //
    public Aluno(string name, double matricula, params double[] notas)
    {
        this.matricula = matricula;
        this.name = name;
        this.notas = notas;

    }
    public string Name
    {
        get { return name; }
        set { value = name; }
    }
    public double Matricula
    {
        get { return matricula; }
        set { value = matricula; }
    }

    public void DefinirNotas(params double[] notas)
    {
        this.notas = notas; // armazena o array recebido no campo
    }
    public void MostrarNotas()
    {
        foreach (double nota in notas)
        {
            Console.WriteLine(nota);
        }
    }
public void MostrarMedianota()
{
    if (notas.Length == 0)
    {
        Console.WriteLine("Nenhuma nota cadastrada.");
        return;
    }

    double soma = 0;
    foreach (double nota in notas)
    {
        soma += nota;
    }

    double media = soma / notas.Length;
    Console.WriteLine($"Média das notas: {media:F2}");
}


}