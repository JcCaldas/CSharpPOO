
namespace Exercicio03;

public class Carro : IVeiculo
{
    public int Gasolina { get; set; }
    
    public Carro(int gasolina)
    {
        Gasolina = gasolina;    
    }
    public bool Abastecer(int quantGasolina)
    {
        Gasolina += quantGasolina;
        return true;
    }

    public void Dirigir()
    {
        if (Gasolina > 0)
        {
            Console.WriteLine("Dirigindo...");
        }
        else
        {
            Console.WriteLine("Sem gasolina...");
        }
    }
}
