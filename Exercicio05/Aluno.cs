

namespace Exercicio05;

public class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome)
    {
    }

    public void Estudar()
    {
        Console.WriteLine("O aluno está estudando...");
    }
}
