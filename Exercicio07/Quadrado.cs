
namespace Exercicio07;

internal class Quadrado : Figura
{
    
    public override void CalculaArea()
    {
        Console.WriteLine("\nÁrea do Quadrado");
        Console.WriteLine("\nInforme o valor do lado do quadrado:");
        double ladoQuadrado = Convert.ToDouble(Console.ReadLine());
        base.CalculaArea();
        double area = Math.Pow(ladoQuadrado, 2);
        Console.WriteLine($"\nA área do quadrado é {area}");
    }
}
