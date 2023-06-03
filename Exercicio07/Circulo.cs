
namespace Exercicio07;

internal class Circulo : Figura
{
    public override void CalculaArea()
    {
        Console.WriteLine("\nÁrea do Círculo");
        Console.WriteLine("\nInforme o raio do círculo:");
        double raioCirculo = Convert.ToDouble(Console.ReadLine());

        base.CalculaArea();
        
        double area = Math.PI * Math.Pow(raioCirculo, 2);

        Console.WriteLine($"\nA área do círculo é {area}");
    }
}
