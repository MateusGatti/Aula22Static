using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"100 reais em dólar =  {Conversor.RealParaDolar(100)} dólares" );

            System.Console.WriteLine($"100 dólares em real =  {Conversor.DolarParaReal(100)} reais" );

            System.Console.WriteLine($"100 reais em euro =  {Conversor.RealParaEuro(100)} euros" );

            System.Console.WriteLine($"100 euros em reais =  {Conversor.EuroParaReal(100)} reais" );
        }
    }
}
