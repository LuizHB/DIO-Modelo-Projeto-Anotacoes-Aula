using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaIntermediario.Models
{ //lê as exceções de baixo para cima na resposta do terminal
    public class ExemploExcecoes
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {//demonstrando que a exceção foi "capturada"
                Console.WriteLine($"Exceção tratada: {ex.Message}");
                //caminho feito pela exceção até o tratamento:
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção.");
        }

    }
}