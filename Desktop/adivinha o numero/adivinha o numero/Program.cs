using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinha_o_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;

            while (valor != 666)
            {
                Console.WriteLine("jogo de adivinhação.qual é o numero?\r\nboa sorte procurando");
                valor = double.Parse(Console.ReadLine());
                if (valor != 666)
                {
                    Console.WriteLine("Errou,tente novamente.");
                }
            }//while
            Console.WriteLine("parabens,acertou o numero");
            Console.ReadKey();
        }//static void
    }//class program
}//namespace
