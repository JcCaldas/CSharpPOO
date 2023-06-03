
namespace _13Acoplamento;

internal class Homem : Animal
{
    /*A propriedade é provada e somente leitura para não
 poder ser alterada após receber a instância no construtor*/

    private readonly ComportamentoAndar _comportamentoAndar;

    public Homem(ComportamentoAndar andar)
    {
        _comportamentoAndar = andar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Homem));
        /*A expressão nameof produz o nome de uma variável,
         tipo ou membro como a constante de cadei de
        caracteres*/
        _comportamentoAndar.Andar();
    }
}
