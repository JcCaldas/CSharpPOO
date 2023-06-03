using Exercicio03;

Console.WriteLine("Exercício 03\n");

Carro carro = new Carro(0);

Console.WriteLine("Informe quantos litros de gasolina deseja colocar: ");
int gasolina = Convert.ToInt32(Console.ReadLine());

if (carro.Abastecer(gasolina))
{
    carro.Dirigir();
}



