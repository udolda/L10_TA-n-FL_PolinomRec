using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TA_n_FL_PR
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s;
            //Console.WriteLine("Введите многочлен:");
            //s = Console.ReadLine();

            Console.WriteLine( new Polinom("4x^4-4x^4+1x^2-25x^1+5"));
            Console.ReadKey();
        }
    }
}
