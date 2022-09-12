namespace DioFunds.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class Calculadora
    {
        /// <summary>
        /// soma de dois numeros
        /// </summary>
        /// <param name="x">primeiro valor inteiro para somar</param>
        /// <param name="y">segundo valor inteiro para somar</param>
        public void Soma(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtracao(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Divisao(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Multiplicacao(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(raiz, 3)}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 3)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 3)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 3)}");
        }





    }
}