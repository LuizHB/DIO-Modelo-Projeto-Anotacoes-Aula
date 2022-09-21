using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{//abstração > criando uma classe com apenas o necessário para o objeto
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        //opção virtual libera a possibilidade de modificar 
        //o método em outra classe
        public virtual void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}