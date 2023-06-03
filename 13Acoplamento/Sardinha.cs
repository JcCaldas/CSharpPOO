
namespace _13Acoplamento;

internal class Sardinha : Animal
{
    private readonly ComportamentoNadar _comportamentoNadar;

    public Sardinha(ComportamentoNadar nadar)
    {
        _comportamentoNadar = nadar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Sardinha));
        _comportamentoNadar.Nadar();
    }
}
