
public class ContaCorrente
{
    public string? Nome { get; set; }
    public int NumeroConta { get; set; }
    protected decimal Saldo { get; set; } = 0.00m;

    public virtual void Saudacao()
    {
        Console.WriteLine($"\nOlá {Nome}!");
        Console.WriteLine($"Sua Conta Corrente nº {NumeroConta}, foi criada com sucesso!");

    }

    public void ExibirSaldo()
    {
        Console.WriteLine("\n\tSALDO");
        Console.WriteLine($"Seu saldo atual é {Saldo.ToString("c")}");
        Opcoes();
    }

    public virtual void Depositar()
    {
        Console.WriteLine("Qual valor você gostaria de depositar?");
        decimal valorDepositado = Convert.ToDecimal(Console.ReadLine());

        Saldo += valorDepositado;
        
        Console.WriteLine("\n\tDEPOSITO EFETUADO");
        Console.WriteLine($"Foi depositado o valor de {valorDepositado.ToString("c")}");
        ExibirSaldo();
        Opcoes();

    }

    public virtual void Sacar()
    {
        Console.WriteLine("Qual valor você gostaria de sacar?");
        decimal valorSacado = Convert.ToDecimal(Console.ReadLine());

        Saldo -= valorSacado;
        Console.WriteLine("\n\tSAQUE EFETUADO");
        Console.WriteLine($"Foi sacado o valor de {valorSacado.ToString("c")}");
        ExibirSaldo();
        Opcoes();
    }

    public void Opcoes()
    {
        Console.WriteLine("\nO que deja fazer?");
        Console.WriteLine("1 - Depósito;\n2 - Saque;\n3 - Exibir Saldo;\n4 - Sair");
        Console.Write("Opção: ");
        int opcoes = Convert.ToInt32(Console.ReadLine());

        switch (opcoes)
        {
            case 1:
                this.Depositar();
                break;

            case 2:
                this.Sacar();
                break;

            case 3:
                this.ExibirSaldo();
                break;

            case 4:
                Console.WriteLine("Obrigado por utilizar o sistema!");
                break;
        }
    }
}
