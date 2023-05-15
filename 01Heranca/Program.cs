Console.WriteLine("## Herança ##\n");

ClasseDerivada cd = new ClasseDerivada();
cd.VerificaAcesso();




Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //Private_Membro(); //O compilador alerta que esse método é inacessível, pois ele é do tipo private.

        Console.WriteLine("\nAcesso ao campo private: private_var usando uma propriedade GET");
        int soma = public_var + protected_var + internal_var + Private_var;
        //Se tentar acessar o campo private_var, o compilador dá erro, mas acessando a propriedade, o GET retorna o valor.
        Console.WriteLine($"Total da soma: {soma}");
    }
}

public class ClasseBase
{
    //campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    //propriedade
    //Uma das formas de encapsulamento
    public int Private_var
    {
        get { return private_var; }
        set { private_var = value; }
    }

    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }

    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }

    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected Internal");
    }

    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método Private");
    }
}