using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{
    public class Professor : Pessoa
    {//herança a partir da classe Pessoa
        public decimal Salario { get; set; }
        //a opção override libera a opção de sobrescrever
        //um método herdado de outra classe
        public override void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome}, tenho {Idade} anos e meu salário é {Salario:C}!");
        }
    }
}