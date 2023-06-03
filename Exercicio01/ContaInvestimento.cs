namespace Exercicio01;

internal class ContaInvestimento : ContaCorrente
{
    public ContaInvestimento (ContaCorrente cliente)
    {
        this.Nome = cliente.Nome;
        this.NumeroConta = cliente.NumeroConta;
    }

    public override void Saudacao()
    {
        Console.WriteLine($"\nOlá {Nome}!");
        Console.WriteLine($"Sua Conta Investimento nº {NumeroConta}, foi criada com sucesso!");

    }

    public override void Depositar()
    {
        Console.WriteLine("Qual valor você gostaria de depositar?");
        decimal valorDepositado = Convert.ToDecimal(Console.ReadLine());

        decimal rendimento = valorDepositado * 0.009m;
        Saldo += (valorDepositado + rendimento);

        Console.WriteLine("\n\tDEPOSITO EFETUADO");
        Console.WriteLine($"Foi depositado o valor de {valorDepositado.ToString("c")}");
        Console.WriteLine($"O valor depositado rendeu {rendimento.ToString("c")}");
        ExibirSaldo();
        Opcoes();

    }

    public override void Sacar()
    {
        Console.WriteLine("Qual valor você gostaria de sacar?");
        decimal valorSacado = Convert.ToDecimal(Console.ReadLine());

        decimal imposto = valorSacado * 0.001m;
        
        if ((valorSacado + imposto) > Saldo)
        {
            Console.WriteLine("\n\tSAQUE NÃO EFETUADO");
            Console.WriteLine($"O saque no valor de {valorSacado.ToString("c")} não pode ser efetuado.\nO valor do saque mais o imposto de " +
                $"{imposto.ToString("c")} (0,09%) deixarão o saldo negativo.");
            ExibirSaldo();
            Opcoes();
        }
        else
        {
        
            Saldo -= (valorSacado + imposto);
            Console.WriteLine("\n\tSAQUE EFETUADO");
            Console.WriteLine($"Foi sacado o valor de {valorSacado.ToString("c")}");
            Console.WriteLine($"Foi cobrado um imposto no valor de {imposto.ToString("c")}");
            ExibirSaldo();
            Opcoes();

        }
        
    }
}
