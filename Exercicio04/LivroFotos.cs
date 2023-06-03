
namespace Exercicio04;

public class LivroFotos
{
    protected int numPaginas {get;set;}

    public LivroFotos()
    {
        numPaginas = 16;
    }

    public LivroFotos(int numeroPaginas)
    {
        this.numPaginas = numeroPaginas;
    }

    public virtual int GetNumeroPaginas()
    {
        return numPaginas;
    }
}
