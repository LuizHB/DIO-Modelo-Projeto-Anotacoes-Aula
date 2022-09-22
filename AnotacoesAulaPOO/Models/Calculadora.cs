using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnotacoesAulaPOO.interfaces;

namespace AnotacoesAulaPOO.Models
{
    public class Calculadora : ICalculadora
    {//implementando a interface (não esta herdando)
     //é obrigatorio implementar todos os métodos
     //que a interface definiu
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}