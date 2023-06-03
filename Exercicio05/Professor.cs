

namespace Exercicio05;

public class Professor : Pessoa
{
    public Professor(string nome) : base(nome)
    {
    }

    public void Explicar()
    {
        Console.WriteLine("O professor está explicando o seguinte:");
        Console.ReadLine();
    }
}
