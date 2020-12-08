using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6C
{
    class Assign6C
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> GetBasic = (e) =>
            {
                decimal HRA = ((e * 3) / 100);
                decimal TA = ((e * 4) / 100);
                decimal IT = ((e * 5) / 100);
                decimal PF = ((e * 4) / 100); ;

                decimal NetSalary = e + HRA + TA - PF - IT;
                return NetSalary;
            };
            Console.WriteLine("Basic Salary = " + GetBasic(1200));

            Console.ReadLine();
        }


    }
}
