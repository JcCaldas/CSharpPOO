using _08Heranca_UpcastingDowncasting;

Console.WriteLine("Herança - Upcasting e Downcasting\n");

Console.WriteLine("Upcasting - Implícito\n");
/*Upcasting é possível pois a classe Circulo deriva da classe
 Forma. O upcasting é implícito, ou seja, Circulo acessa todos
os métodos de Forma, mas Forma não acessa os métodos de Circulo*/
Forma circulo = new Circulo(10, 20);

circulo.Desenhar();
//circulo.PintarCirculo(); // não tem acesso ao pintar circulo

//Outra maneira de fazer upcasting

Circulo circulo2 = new Circulo(10, 20);
Forma forma = circulo2;

forma.Desenhar();
//forma.PintarCirculo(); // não tem acesso ao pintar circulo

Console.WriteLine( forma == circulo2);

Console.WriteLine("\nDowncasting - Explícito\n");

Circulo circulo3 = new Circulo(20, 20);
Forma f = circulo3; //upcasting

Circulo c = (Circulo)f; //downcasting

//A variável "c" terá acesso aos métodos de Forma e círculo
c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo3);