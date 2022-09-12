using System.IO;
using System.Linq;
using System;

/*
// Desafio 1
Console.WriteLine("Digite um numero");
int n = int.Parse(Console.ReadLine());
int p = 1, s = 0;
while (n > 0)
{
    int l = n % 10;
    // TODO: Crie as outras condições necessárias para a resolução do desafio:
    p *= l;
    s += l;
    n /= 10;
}

Console.WriteLine(p - s);
*/


/*
//Desafio 2

class Conta
{

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        string[] v = new string[2];
        for (int i = 0; i < qt; i++)
        {

            string a = v[0];
            string b = v[1];

            if (a.length < b.length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}
*/
/*
class Program
{
    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        string[] v = new string[2];

        for (int i = 0; i < qt; ++i)
        {
            v = Console.ReadLine().Split(" ");
            string a = v[0];
            string b = v[1];


            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}

/*

/*
//Desafio 3

class Solution
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (n % i == 0)
            {
                count++;
            }
            if (count > 3)
            {
                Console.WriteLine(false);
            }
        }
        Console.WriteLine(count == 3);
    }
}
*/