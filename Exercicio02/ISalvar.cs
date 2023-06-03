
namespace Exercicio02;

internal interface ISalvar
{

    void Salvar();

    void Compactar()
    {
        Console.WriteLine("Compactando arquivos");
    }
}
