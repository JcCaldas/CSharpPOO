namespace Exercicio07;

internal class Triangulo : Figura
{
    public override void CalculaArea()
    {
        Console.WriteLine("\nÁrea do Triângulo");
        
        Console.WriteLine("\nInforme o valor da base do triângulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nInforme o valor do altura do triângulo:");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        base.CalculaArea();

        double area = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine($"\nA área do triângulo é {area}");
    }
}
