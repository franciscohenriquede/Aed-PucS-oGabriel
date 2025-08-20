/** – Crie uma classe chamada "Funcionário" com os atributos "nome", "cargo" e "salário".
Implemente um construtor que receba o nome e o cargo como parâmetros e inicialize os campos
correspondentes. Defina um valor padrão para o salário caso não seja fornecido no construtor.*/

public class Funcionario
{

    private string name;
    private string cargo;

    private double salario;


    public bool FuncionarioCargoValido(string cargo) {

        string[] cargosValidos = { "Gerente", "Analista", "Estagiario" , "junior", "senior", "pleno"};

        // retorna true se o cargo estiver na lista (ignora maiúsculas/minúsculas)
        return cargosValidos.Contains(cargo, StringComparer.OrdinalIgnoreCase);

    }


    public Funcionario(string name, string cargo)
    {
        this.name = name;
        while (!FuncionarioCargoValido(cargo))
        {

            Console.WriteLine(name + " Digite o Cargo novamente:");
            cargo = Console.ReadLine();

        }
        this.cargo = cargo;

        if (cargo.Equals("junior", StringComparison.OrdinalIgnoreCase))
            this.salario = 2200;
        else if (cargo.Equals("pleno", StringComparison.OrdinalIgnoreCase))
            this.salario = 5200;
        else if (cargo.Equals("senior", StringComparison.OrdinalIgnoreCase))
            this.salario = 10200;
        else if (cargo.Equals("gerente", StringComparison.OrdinalIgnoreCase))
            this.salario = 20200;
        else if (cargo.Equals("estagiario", StringComparison.OrdinalIgnoreCase))
            this.salario = 1800;
            
    }

    public void Mensagem()
    {
        Console.WriteLine($"Nome   : {name}\nCargo  : {cargo}\nSalario: {salario}");
    }
}







