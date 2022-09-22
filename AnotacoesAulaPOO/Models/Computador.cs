using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{// para ver a classe object clica no Object e aperta f12
 //ai mostra o que ela está dando de herança para todas as classes
    public class Computador : Object
    {

        public override string ToString()
        {
            return "Método toString sobrescrito de Object";
        }
    }
}