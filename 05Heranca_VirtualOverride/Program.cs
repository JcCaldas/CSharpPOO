Console.WriteLine("Herança - Virtual e Override\n");

var gato = new Gato();
gato.Nome = "Bichano";

var cao = new Cachorro();
cao.Nome = "Pipoca";

gato.ExibeNome(); //puxa o método de sobrescrito de sua classe.
cao.ExibeNome(); //puxa o método da classe animal.



Console.ReadKey();

class Animal
{
    public string? Nome { get; set; }

    public virtual void ExibeNome()
    {
        Console.WriteLine($"CLASSE BASE: Oi, eu sou o(a) {Nome}");
    }
    /*Com a palavra chave "virtual" eu indico que esse método deverá
     ser sobrescrito na classe derivada*/
}

class Gato : Animal
{

    //método
    public override void ExibeNome()
    {
        Console.WriteLine($"CLASSE DERIVADA: Oi, eu sou um gato. Meu nome é {Nome}");
    }
    /*Com a palavra chave "override" eu indico que esse método está
     sobrescrevendo o método da classe base*/
}

class Cachorro : Animal
{

}