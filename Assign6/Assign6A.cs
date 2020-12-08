using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6A
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> SimpleInterest = (P, N, R) =>
            {
                decimal I;
                I = (P * N * R) / 100;

                return I;
            };
            Console.WriteLine("SimpleInterest=" + SimpleInterest(1000, 7, 2));

            Console.ReadLine();
        }

        /* decimal SimpleInterest(decimal P, decimal N, decimal R)
         {
             decimal I;
             I = (P * N * R) / 100;
             return I;
         }*/
    }
}
