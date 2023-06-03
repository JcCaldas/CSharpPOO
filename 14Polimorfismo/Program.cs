using _14Polimorfismo;

Console.WriteLine("Polimorfismo\n");

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}