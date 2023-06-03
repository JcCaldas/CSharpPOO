using _09Heranca_is_as;

Console.WriteLine("Herança - Operadores: \"is\" e \"as\"\n");

Console.WriteLine("\"as\" no upcasting\n");

Object carroObj = new Carro();

var x = carroObj as string; //Solicitando que converta do tipo Carro para o tipo string
//Se for possível ele converte, se não retorna null

if (x != null)
{
    Console.WriteLine("Converteu obj para string");
}
else
{
    Console.WriteLine("Não foi possível converter, x é null");
}

Console.WriteLine("\n\"as\" no downcasting\n");

Circulo circulo = new Circulo();
Forma forma = circulo;//upcasting

Circulo c = forma as Circulo; //downcasting

if (c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting é inválida");
}

Console.WriteLine("\nOperador \"is\" - apenas verifica se a conversão é possível," +
    "retornando um bool");
if (forma is Circulo) // verifica se o downcast é possível.
{
    Console.WriteLine("Convetru Forma para Circulo\n");
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}