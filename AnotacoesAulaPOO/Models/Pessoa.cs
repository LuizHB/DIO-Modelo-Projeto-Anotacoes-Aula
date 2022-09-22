using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.Models
{//abstração > criando uma classe com apenas o necessário para o objeto
    public class Pessoa
    {//criando um construtor > quebrou classes de aluno e professor
     //por não ter esse valor obrigatório, logo precisa criar
     //construtores nessas duas classes
        public Pessoa()
        {//construtor vazio retira a obrigatoriedade de se
         //implementar algo. Logo com os dois construtores
         //existe a possibilidade de se instanciar o valor
         //de forma obrigatória ou não. porém deve ser feita
         // a criação de construtores naqueles que herdam para
         //não ter a obrigatoriedade neles

        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
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