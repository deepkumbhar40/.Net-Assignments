using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6E
{
    class Assign6E
    {
        static void Main(string[] args)
        {
            Predicate<decimal> GetBasic = (e) =>
            {
                decimal HRA = ((e * 3) / 100);
                decimal TA = ((e * 4) / 100);
                decimal IT = ((e * 5) / 100);
                decimal PF = ((e * 4) / 100); ;

                decimal NetSalary = e + HRA + TA - PF - IT;
                return NetSalary > 10000;
            };
            Console.WriteLine(GetBasic(12000));

            Console.ReadLine();
        }
    }
}