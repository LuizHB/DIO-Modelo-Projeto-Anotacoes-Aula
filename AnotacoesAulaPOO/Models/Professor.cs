using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{   //classe selada, logo não podem herdar dela:
    //"public sealed class Professor"
    //por exemplo classe Diretor não pode herdar da classe Professor
    public class Professor : Pessoa
    {//herança a partir da classe Pessoa

        public Professor()
        {//construtor sem parametros para tirar a obrigatoriedade
         //criada pela classe Pessoa

        }

        //criando construtor por ter sido obrigatório em Pessoa
        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }
        //a opção override libera a opção de sobrescrever
        //um método herdado de outra classe
        //método selado, logo outras classes não podem herdar
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome}, tenho {Idade} anos e meu salário é {Salario:C}!");
        }
    }
}