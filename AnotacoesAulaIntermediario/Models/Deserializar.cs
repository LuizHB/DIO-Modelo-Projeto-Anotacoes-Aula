using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AnotacoesAulaIntermediario.Models
{
    public class Deserializar
    {   //caso tenha valores diferentes de texto que não são aceitos no c#
        public int Id { get; set; }
        /* Exemplo se nome do produto for Nome_Produto 
        no arquivo json (não aceito pelo c#)
        Propriedade ler o nome no json e retorna o 
        nome dado pelo método */
        //colocar acima do método:
        //[JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        //tipo nulo aplicado na propriedade
        public decimal? Desconto { get; set; }
    }
}