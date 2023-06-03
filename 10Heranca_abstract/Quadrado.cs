namespace _10Heranca_abstract;

internal class Quadrado : Forma
{
    public double Lado { get; set; }

    public override void CalculaArea()
    {
        Area = Lado * Lado;
    }

    public override void CalculaPerimetro()
    {
Perimetro = 4 * Lado;
    }
}
