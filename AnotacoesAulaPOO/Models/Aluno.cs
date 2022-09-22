using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{//herança a partir da classe Pessoa
    public class Aluno : Pessoa
    {
        //sem criação de construtor vazio para deixar apenas
        //uma das classes do exemplo com a obrigatoriedade

        //criando construtor por ter sido obrigatorio em Pessoa
        public Aluno(string nome) : base(nome)
        {

        }
        public double Nota { get; set; }
        //a opção override libera a opção de sobrescrever
        //um método herdado de outra classe
        public override void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome} , tenho {Idade} anos e sou aluno nota {Nota}!");
        }
    }
}