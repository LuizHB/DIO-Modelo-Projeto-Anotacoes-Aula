using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{//encapsulamento
    public class ContaCorrente
    {//Construtor ContaCorrente
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        //por encapsulamento o saldo é bloqueado
        //apenas a classe pode modificar, mas o programa não
        private decimal saldo;
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                Console.WriteLine("Saldo realizado com sucesso");
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é: " + saldo);
        }
    }
}