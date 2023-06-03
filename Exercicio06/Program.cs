using Exercicio06;

Console.WriteLine("Exercício 06\n");

var matrizPessoas = new List<Pessoa>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome da {i+1}ª pessoal:");
    matrizPessoas.Add(new Pessoa(Console.ReadLine()));
}

for (int i = 0;i < matrizPessoas.Count; i++)
{
    Console.WriteLine(matrizPessoas[i].ToString());
}