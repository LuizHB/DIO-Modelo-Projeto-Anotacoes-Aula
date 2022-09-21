using AnotacoesAulaPOO.Models;

//abstração
//Pessoa é a chamar uma classe para criar um objeto Pessoa
Pessoa p1 = new Pessoa();
p1.Nome = "Luiz";
p1.Idade = 31;
p1.Apresentar();

//encapsulamento
ContaCorrente c1 = new ContaCorrente(100, 5000);
//c1.saldo() > opção saldo não é visivel para o programa
//por ter sido definido como privado na classe
//saldo por ser privado não pode ser modificado nem fica visivel
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

//herança > classes Aluno e Professor  herdando da classe Pessoa
Aluno a1 = new Aluno();
Professor m1 = new Professor();
a1.Nome = "Jones";
a1.Idade = 23;
a1.Nota = 8; //exclusivo da classe Aluno
a1.Apresentar();
m1.Salario = 1400; // exclusivo da classe Professor

//polimorfismo > sobrescrever o método Apresentar() nas classes
m1.Nome = "João";
m1.Idade = 45;
m1.Apresentar();

