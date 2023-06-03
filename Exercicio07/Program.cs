using Exercicio07;

Console.WriteLine("Exercício 07\n");

var listaFiguras = new List<Figura>
{
    new Circulo(),
    new Quadrado(),
    new Triangulo()
};

foreach (var figura in listaFiguras)
{
    figura.CalculaArea();
}