Console.WriteLine("Herança - Sealed\n");

Console.ReadKey();

sealed class Pessoa //com o modificador "sealed" a classe não pode ser herdada
{
    public string? Nome { get; set; }
    
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente //: Pessoa
{
    public void ExibeNome()
    {
        //Console.WriteLine($"Meu nome é {Nome}");
    }
}

class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }

    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("Classe1.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }
}

class Classe2 : Classe1
{
    //Tentar sobrescrever Metodo1() causa um erro CS0239.
    /*O método 1 da classe base, dessa classe, está "sealed" (selado)
     e não pode ser substituido*/
    protected override void Metodo1()
    {
        Console.WriteLine("Classe2.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo2()");
    }
}