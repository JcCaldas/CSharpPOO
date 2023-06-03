Console.WriteLine("Polimorfismo estático\n");

Calcular calcular = new Calcular();

Console.WriteLine(calcular.Somar(30, 40));

Console.WriteLine(calcular.Somar(30, 40, 50));

//Dependendo da quantidade de parâmetros o código é utlizado

class Calcular
{
    public int Somar (int num1, int num2)
    {
        return num1 + num2;
    }
    public int Somar (int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}