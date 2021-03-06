﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralManager o = new GeneralManager();
            //o.GetNetSalary();
            Console.WriteLine("************************************************");
            CEO r = new CEO();
            //o.GetNetSalary();
            Console.ReadLine();

        }
    }
    public abstract class Employee
    {
        private static int lastempNo = 0;
        protected decimal basic;
        public string name;
        public int empNo;
        public short deptNo;

        public Employee(String Name = "Sana", decimal Basic = 9000, short DeptNo = 2)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            Console.WriteLine("Employee Department");
            EmpNo = ++lastempNo;
            Console.WriteLine("Emp no : " + EmpNo);
            Console.WriteLine("Emp Name : " + Name);
            Console.WriteLine("Emp Basic : " + Basic);
            Console.WriteLine("Emp depNo : " + DeptNo);
        }

        public abstract decimal Basic { set; get; }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Enter valid Department Number");
                }
            }
        }
        public String Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Enter valid name");
                }
                else
                { name = value; }
            }
        }
        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }
        //Abstract method
        public abstract decimal GetNetSalary(decimal Basic);
    }
    public class Manager : Employee
    {
        public Manager(String Name = "Sameer", decimal Basic = 30000, short DeptNo = 1, string Designation = "Manager") : base(Name, Basic, DeptNo)
        {

            this.Designation = Designation;

            Console.WriteLine("This is manager department");
            Console.WriteLine("Emp Name : " + Name);
            Console.WriteLine("Emp Basic : " + Basic);
            Console.WriteLine("Emp depNo : " + DeptNo);
            Console.WriteLine("Emp designation : " + Designation);
        }

        public string designation;
        public override decimal Basic
        {
            set
            {
                if (value > 15000 && value < 35000)
                {
                    basic = value;
                }
                else
                { Console.WriteLine("Enter valid Basic"); }
            }
            get { return basic; }

        }
        public string Designation
        {
            get { return designation; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Enter valid Designation");
                }
                else
                {
                    designation = value;
                }
            }
        }
        public override decimal GetNetSalary(decimal Basic)
        {      /* HRA =3%
               float PF = 5%;
               float TA = 4 %;
               float IT = 5 %
               decimal NetSalary = Convert.ToDecimal(Basic + HRA + TA - PF - IT); */
            decimal HRA = ((Basic * 3) / 100);
            decimal TA = ((Basic * 4) / 100);
            decimal IT = ((Basic * 5) / 100);
            decimal PF = ((Basic * 4) / 100); ;

            decimal NetSalary = Basic + HRA + TA - PF - IT;
            return NetSalary;
        }

    }
    public class GeneralManager : Manager
    {
        public GeneralManager(String Name = "Amol ", decimal Basic = 8000, short DeptNo = 1, String Designation = "Manager", String Perks = "None") : base(Name, Basic, DeptNo, Designation)
        {

            this.Perks = Perks;
            Console.WriteLine("This is General_Manager department");
            Console.WriteLine("Emp Name : " + Name);
            Console.WriteLine("Emp Basic : " + Basic);
            Console.WriteLine("Emp depNo : " + DeptNo);
            Console.WriteLine("Emp Perk : " + Perks);
        }
        public string Perks;

        public override decimal Basic
        {
            set
            {
                if (value > 35000 && value < 50000)
                {
                    basic = value;
                }
                else
                { Console.WriteLine("Enter valid Basic"); }
            }
            get { return basic; }
        }

        public sealed override decimal GetNetSalary(decimal Basic)
        {
            decimal HRA = ((Basic * 3) / 100);
            decimal TA = ((Basic * 4) / 100);
            decimal IT = ((Basic * 5) / 100);
            decimal PF = ((Basic * 4) / 100); ;

            decimal NetSalary = Basic + HRA + TA - PF - IT;
            return NetSalary;
        }
    }

    public class CEO : Employee
    {
        public CEO(String Name = " ", decimal Basic = 50000, short DeptNo = 2) : base(Name, Basic, DeptNo)
        {
            Console.WriteLine("This is CEO department");
            Console.WriteLine("Emp Name : " + Name);
            Console.WriteLine("Emp Basic : " + Basic);
            Console.WriteLine("Emp depNo : " + DeptNo);

        }

        public override decimal Basic
        {
            set
            {
                if (value > 50000 && value < 60000)
                {
                    basic = value;
                }
                else
                { Console.WriteLine("Enter valid Basic"); }
            }
            get { return basic; }
        }
        public sealed override decimal GetNetSalary(decimal Basic)
        {
            decimal HRA = ((Basic * 3) / 100);
            decimal TA = ((Basic * 4) / 100);
            decimal IT = ((Basic * 5) / 100);
            decimal PF = ((Basic * 4) / 100); ;

            decimal NetSalary = Basic + HRA + TA - PF - IT;
            return NetSalary;
        }

    }
}
