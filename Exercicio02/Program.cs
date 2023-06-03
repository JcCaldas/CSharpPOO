using Exercicio02;

Console.WriteLine("Exercício 02 - Interface\n");

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();


Console.WriteLine();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

Console.WriteLine();

ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();

/*Para acessar um método de uma interface que está sendo herdada
 por uma classe concreta, deve-se criar a instância da classe
que está herdando a interface e converte-la para o tipo da interface*/