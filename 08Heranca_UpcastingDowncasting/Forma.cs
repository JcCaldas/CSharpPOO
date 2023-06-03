
namespace _08Heranca_UpcastingDowncasting;

internal class Forma
{
    protected int xpos, ypos;

    public Forma()
    {

    }

    public Forma (int x,  int y)
    {
        xpos = x;
        ypos = y;
    }

    public virtual void Desenhar()
    {
        Console.WriteLine($"Desenhar - Forma na posição: ({xpos},{ypos})");
    }
}
