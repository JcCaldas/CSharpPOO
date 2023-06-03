
namespace Exercicio05;

public class Pessoa
{
    public string Nome { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Olá meu nome é {Nome}";
    }
}
