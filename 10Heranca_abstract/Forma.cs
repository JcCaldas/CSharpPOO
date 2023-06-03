
namespace _10Heranca_abstract;

public abstract class Forma
{
    // propiedades

    public string? Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    //métodos abstratos

    public abstract void CalculaArea();
    public abstract void CalculaPerimetro();

    //método comum
    public string Descricao()
    {
        return "Sou a classe abstrata Forma";
    }
}
