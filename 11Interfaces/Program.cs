Console.WriteLine("Interfaces\n");

IControle d = new Demo();

d.Name = "Teste";
d.Desenhar();
d.Exibir(); /*O método Exibir() está disnível pois a instância
             d é do tipo IControle*/
//O método Pintar() não é acessível, pois é do tipo IGrafico.


Console.ReadKey();

interface IControle //Por convenção o nome da interface deve ser iniciado com "I"
{

    //public IControle() { } //Interfaces não podem ter controladores de instância
    //int status; //Interfaces não podem ter campos de instância
    /*Campo de instância é um campo não estático que precisa de
     uma instância de um objeto para ser acessado*/

    string Name { get; set;  }

    void Desenhar(); //método abstrato - obrigado a imprementar na classe derivada
    
    public void Exibir () //método normal - não é obrigado a ser implementado
    {
        Console.WriteLine("teste...");
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico //uma classe pode herdar várias interfaces
{
    public string Name { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }
}