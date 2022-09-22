using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{//classe diretor não consegue herdar de classe professor
 //se ela estiver selada
    public class Diretor : Professor
    {//diretor não pode modificar o método selado
        /*
         public override void Apresentar()
         {
             Console.WriteLine($"Oi, sou o Diretor!");
         }
        */
    }
}