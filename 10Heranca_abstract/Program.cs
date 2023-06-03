using _10Heranca_abstract;

Console.WriteLine("Herança - abstract\n");

//Forma forma = new Forma(); //Se tentar referenciar uma classe abstrata, o compilador avisa que não é possível

Quadrado q  = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("\nInforme a cor da figura:");
q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado:");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalculaArea();
q.CalculaPerimetro();

Console.WriteLine($"\nÁrea do quadrado: {q.Area}m²");
Console.WriteLine($"\nPerímetro do quadrado: {q.Perimetro}m");

Console.WriteLine($"\nO quadrado tem a cor: {q.Cor}");
