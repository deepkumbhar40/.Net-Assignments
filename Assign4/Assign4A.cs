using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4A
{

    public class Employee
    {
        public int empno;

        public string empname;

        public string designation;

        public decimal salary;

        public void setvalues(int empno, string empname,  decimal salary)
        {
            this.empno = empno;
            this.empname = empname;
         
            this.salary = salary;
        }

        public void show()
        {
            Console.WriteLine(empno);
            Console.WriteLine(empname);
           
            Console.WriteLine(salary);


        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("No of employee you want ?  ");

            int capacity = int.Parse(Console.ReadLine());

            Employee[] e1 = new Employee[capacity];

            for (int i = 0; i < e1.Length; i++)
            {

                Console.WriteLine("\nEnter empno = ");

                int empno = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name = ");

                string empname = Console.ReadLine();


                Console.WriteLine("Enter salary = ");

                decimal salaray = decimal.Parse(Console.ReadLine());

                Employee temp = new Employee();

                temp.setvalues(empno, empname, salaray);

                e1[i] = temp;


            }


            
            decimal max = e1[0].salary;


            Console.WriteLine("\n********* Employee with Highest salaray*********\n");

            for (int i = 0; i < e1.Length; i++)
            {

                if (e1[i].salary > max)
                {
                    max = e1[i].salary;

                    e1[i].show();
                }

            }


          


            Console.WriteLine("\n Enter the EmpNo to be serched : ");

            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < e1.Length; i++)
            {

                if (e1[i].empno == search)
                {
                    e1[i].show();
                }

            }



            Console.ReadLine();


        }

    }
}