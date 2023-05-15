Console.WriteLine("## Herança - Construtores ##\n");

Aluno aluno = new Aluno();
/*Como comportamento padrão, ao criar a instância o primeiro construtor
 * a ser chamado é o da classe base.*/

Aluno aluno2 = new Aluno("José");
/*Ao informar o parâmetro, a classe derivada, como comportamento pardrão,
 vai chamar o construtor da classe base sem o parâmetro e o dela com o 
parâmetro. Ao utilizar a palavra chave "base" nos construtores, os construtores
 indicados são chamados*/


Console.ReadLine();

//Classe Base
class Pessoa
{
    //Construtor
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parâmetro");
    }


}

//Classe Derivada
class Aluno : Pessoa
{
    //Construtor
    public Aluno() : base() /*Ao utilizar a palavra chave "base" é invocado um construtor específico da classe base, no caso o sem parâmetros*/
    {
        Console.WriteLine("Construtor da classe Aluno");
    }

    public Aluno(string nome) : base(nome) /*Ao utilizar a palavra chave "base" é invocado um construtor específico da classe base, no caso o com parâmetros*/
    {
        Console.WriteLine("Construtor da classe Aluno com parâmetro");
    }
}