using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotacoesAulaPOO.interfaces
{//criação de interface, só traz os métodos sem implementação
 //só tem a descrição dos métodos (mas pode ter implementação> {})
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);
    }
}