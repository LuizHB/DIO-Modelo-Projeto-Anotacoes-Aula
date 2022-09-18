using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaIntermediario.Models
{
    //classe para extensão colocar static para não instanciar
    public static class IntExtensions
    {
        /* todos os inteiros terão esse método em qualquer
        momento do código caso seja chamado */
        public static bool EsPar(this int numeroC)
        {
            return numeroC % 2 == 0;
        }
    }
}