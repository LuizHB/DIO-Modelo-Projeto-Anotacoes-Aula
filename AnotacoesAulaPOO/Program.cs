using AnotacoesAulaPOO.interfaces;
using AnotacoesAulaPOO.Models;

//abstração
//Pessoa é a chamar uma classe para criar um objeto Pessoa
Pessoa p1 = new Pessoa("Luiz");
p1.Idade = 31;
p1.Apresentar();

Console.WriteLine("-------------");

//encapsulamento
ContaCorrente c1 = new ContaCorrente(100, 5000);
//c1.saldo() > opção saldo não é visivel para o programa
//por ter sido definido como privado na classe
//saldo por ser privado não pode ser modificado nem fica visivel
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

Console.WriteLine("-------------");

//herança > classes Aluno e Professor  herdando da classe Pessoa
//classe pessoa colocou como obrigatorio o nome
Aluno a1 = new Aluno("Laurent");
Professor m1 = new Professor("Jones");
a1.Idade = 23;
a1.Nota = 8; //exclusivo da classe Aluno
a1.Apresentar();
m1.Salario = 1400; // exclusivo da classe Professor

Console.WriteLine("-------------");

//polimorfismo > sobrescrever o método Apresentar() nas classes
m1.Idade = 45;
m1.Apresentar();

Console.WriteLine("-------------");

//classe abstrata > conta não pode ser instanciada
//criando classe que herda chamada corrente
Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();
c.Creditar(700);
c.ExibirSaldo();

Console.WriteLine("-------------");

//classe Object de forma mais visivel
Computador comp = new Computador();
Console.WriteLine(comp.ToString());

Console.WriteLine("-------------");

//interface
//interface não pode ser instanciada
//executa uma interface que recebe uma classe que a implementa
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(1, 3));

