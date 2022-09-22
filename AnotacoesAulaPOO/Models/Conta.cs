using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{//classe abstrata que não pode ser instanciada
    public abstract class Conta
    {
        //método com protected é protegido contra alterações
        //porém as classes que herdam podem utilizar
        //no private as classes que herdam não podem utilizar
        protected decimal saldo;
        //Creditar é abstrato, não tem implementação
        //quem herdar a classe tem de implementar o método
        //em seu código
        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é {saldo:C}");
        }
    }
}