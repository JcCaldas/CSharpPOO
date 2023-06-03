using Exercicio01;

Console.WriteLine("Exercício - Herança");

ContaCorrente clienteCorrente = new ContaCorrente();

Console.Write("Digite o nome do cliente: ");
clienteCorrente.Nome = Console.ReadLine();

Console.Write("Digite o número da conta: ");
clienteCorrente.NumeroConta = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deseja abrir outro tipo de conta para esse cliente?");
var resposta = Console.ReadLine();

if (resposta[0].ToString().ToLower() == "s")
{
    Console.WriteLine("Qual tipo de conta deseja abrir?");
    Console.WriteLine("1 - Investimento;\n2 - Poupança;");
    int opcoesConta = Convert.ToInt32(Console.ReadLine());
    
    switch (opcoesConta)
    {
        case 1:
            ContaInvestimento clienteInvestimento = new ContaInvestimento(clienteCorrente);
            clienteInvestimento.Saudacao();
            clienteInvestimento.Opcoes();
            break;
        
        case 2:
            ContaPoupanca clientePoupanca = new ContaPoupanca(clienteCorrente);
            clientePoupanca.Saudacao();
            clientePoupanca.Opcoes();
            break;
    }
}
else
{
    clienteCorrente.Saudacao();
    clienteCorrente.Opcoes();
}