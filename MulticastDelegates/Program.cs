using MulticastDelegates.NovaPasta.Services;
using System;

namespace MulticastDelegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            /*
            * MULTICAST DELEGATES:
            - Delegates que guardam a referência para mais de um método.
            - Para adicionar uma referência, pode-se usar o operador +=.
            - A chamada Invoke (ou sintaxe reduzida) executa todos os métodos na ordem em que foram adicionados
            - Seu uso faz sentido para métodos void
            */

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax; //Agora o delegate guarda duas referências para funções void a .ShowSum e a .ShowMax

            op(a, b); //Agora nesse caso chamando a variável "op" será executada as duas funções que tem suas referências guardadas dentro do "op"
        }
    }
}
