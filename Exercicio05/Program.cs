using Exercicio05;

Console.WriteLine("Exercício 05\n");

var matriz = new List<Pessoa>();

for  (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Digite o nome do professor: ");
        matriz.Add(new Professor(Console.ReadLine()));

    }
    else
    {
        Console.WriteLine($"Digite o nome do {i+1}º aluno: ");
        matriz.Add(new Aluno(Console.ReadLine()));

    }
}

foreach (var pessoa in matriz)
{
    if (pessoa.GetType() == typeof(Professor))
    {
        Console.WriteLine($"\nO professor {pessoa.Nome}:");
        ((Professor)pessoa).Explicar();
    }
    else
    {
        Console.WriteLine($"\nO aluno {pessoa.Nome}:");
        ((Aluno)pessoa).Estudar();
    }
}
