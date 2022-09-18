using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaIntermediario.Models
{
    public class LeituraArquivo
    {   //método com tuplas (sempre na ordem certa dos tipos)
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {//retorna tupla para sucesso
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }//retorna true para bool, valor de linhas e qt de linhas
            catch (Exception)
            {//retorna tupla para erro
                return (false, new string[0], 0);
            }//retorna false para bool, 0 para linhas e 0 para qt de linhas
        }
    }
}