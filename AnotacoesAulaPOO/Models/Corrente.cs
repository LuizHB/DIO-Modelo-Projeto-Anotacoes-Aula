using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{//herdando da classe abstrata
    public class Corrente : Conta
    {//obrigatório ter de implementar o método abstrato
        public override void Creditar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Valor adicionado ao saldo: {valor:C}");
        }
    }
}