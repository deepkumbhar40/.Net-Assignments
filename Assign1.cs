using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee("Amol", 6000, 2);
            //Employee e2 = new Employee("Amol", 500);
            //Employee e3 = new Employee("");
            Employee e1 = new Employee("sana1");
            Employee e2 = new Employee("sana", 123465);
            
            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e2.EmpNo);
            //Console.WriteLine(e2.EmpNo);
            //Console.WriteLine(e3.EmpNo);

            //Console.WriteLine(e3.EmpNo);
            //Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e1.Name);

            //Employee e = new Employee();
            // Console.WriteLine("Enter name");
            //  e.Name = Console.ReadLine();
            // Console.WriteLine(e.Name);

            /* Console.WriteLine("Enter basic salary");
             e.Basic = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine(e.Basic);
             decimal a = e.GetNetSalary();
             Console.WriteLine(a);

             Console.WriteLine("Enter DptNo");
             e.DeptNo = Convert.ToInt16(Console.ReadLine()); 
             Console.WriteLine(e.DeptNo);*/


            Console.ReadLine();
        }
    }
    public class Employee
    {
        static int empNo;
        String name;
        Double basic;
        short deptNo;
        static int temp = 0;

        public String Name
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Enter a valid name");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        public Double Basic
        {
            set
            {
                if (value < 10000 && value > 4000)
                {
                    basic = value;
                }
                else
                {

                    Console.WriteLine("Enter a valid data");
                }
            }
            get { return basic; }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Enter valid deptNo");
                }
            }
            get { return deptNo; }
        }
        public int EmpNo

        {
            get;

            set;
        } = ++empNo;


        public decimal GetNetSalary()
        {

            /*float PF = 5%;
            float TA = 4%;
            float IT = 5%
            decimal NetSalary = Convert.ToDecimal( Basic + HRA + TA - PF - IT);*/

            decimal NetSalary = Convert.ToDecimal(Basic + (0.03 * Basic) + (0.05 * Basic) - (0.04 * Basic) - (0.05 * Basic));
            return NetSalary;
        }

        public Employee()
        {

        }
        public Employee(String Name)
        {
            this.Name = Name;
        }
        public Employee(String Name, Double Basic)
        {
            this.Name = Name;
            this.Basic = Basic;
        }
        public Employee(String Name, Double Basic, short DeptNo)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;

        }


    }
}