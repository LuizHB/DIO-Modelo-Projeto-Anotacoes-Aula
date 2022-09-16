using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaIntermediario.Models
{
    public class Pessoa
    {
        //criando construtores
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome; //a propriedade Nome recebe nome pelo construtor
            Sobrenome = sobrenome; // a propriedade Sobrenome recebe sobrenome pelo construtor
        }

        //criando validação para nome não receber valor vazio
        private string _nome;

        //propriedade nome
        public string Nome
        {
            /*get retorna o nome se tiver string 
            exemplo retorna nome com todas as letras maiúsculas
            utilizando body expressions para códigos de apenas 1 linha
            ou comandos simples e diretos
            */
            get => _nome.ToUpper();

            //exceção para valor vazio
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }
        //validando a propriedade idade para não receber negativo
        private int _idade;
        //propriedade idade 
        public int Idade
        {
            get => _idade;
            // exceção para valores menores que zero
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }

        //propriedade somente leitura (não pode ser chamada)
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        //método

        public void Apresentar()
        {
            //chamando a propriedade no método (get)
            //sem validação o programa aceita qualquer nome, até mesmo vazio
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade} anos.");
        }
    }
}