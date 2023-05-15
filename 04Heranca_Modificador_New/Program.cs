Console.WriteLine("Herança - Modificador \" New\"\n");

Aluno aluno = new Aluno();
aluno.Nome = "Maria";
aluno.Curso = "Quimica";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    
    //método
    public string Saudacao() => $"Oi, eu sou o(a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }

    //método
    public new string Saudacao() => $"Oi, eu sou o(a) {Nome} do curso de {Curso}.";
    /*Caso não seja utilizado o modificador "new" o compilador gera
     um alerta e oculta o método da classe base de forma implicita.
    Mas caso a intenção seja realmente ocultar, deve-se utilizar o
    modificador "new".*/
}