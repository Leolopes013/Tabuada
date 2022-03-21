using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaDesejada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Informe um número..: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i+" x "+numero+" = "+(numero*i));
            }

            Console.ReadKey();
        }
    }
}
