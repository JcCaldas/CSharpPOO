

namespace Exercicio06;

public class Pessoa
{
    public string Nome { get; set; }

    public Pessoa(string nome)
    {
        this.Nome = nome;
    }

    public override string ToString()
    {
        return $"Olá, meu nome é {Nome}";
    }
}
