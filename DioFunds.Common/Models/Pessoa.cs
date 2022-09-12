namespace DioFunds.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// Representa a pessoa física
    /// </summary>
    public class Pessoa
    {


        public int Idade { get; set; } /*propriedade*/

        public string NomeP { get; set; } /*propriedade*/

        /// <summary>
        /// Faz a apresentação da pessoa com nome e idade
        /// </summary>
        public void Apresentar() /*método*/
        {
            Console.WriteLine($"Olá, meu nome é " +
            $"{NomeP} e tenho {Idade} anos.");
        }

    }
}