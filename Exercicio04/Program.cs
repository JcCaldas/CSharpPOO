using Exercicio04;

Console.WriteLine("Exercício 04\n");

var livro1 = new LivroFotos();
Console.WriteLine(livro1.GetNumeroPaginas());

var livro2 =  new LivroFotos(24);
Console.WriteLine(livro2.GetNumeroPaginas());

var superlivro = new SuperLivro();
Console.WriteLine(superlivro.GetNumeroPaginas());