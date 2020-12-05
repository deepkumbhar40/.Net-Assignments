using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4C
{

    public class StudentData
    {
        public int Rno;

        public string Sname;

     

        public decimal Marks;

        public void setvalues(int Rno, string Sname, decimal Marks)
        {
            this.Rno = Rno;
            this.Sname = Sname;

            this.Marks = Marks;
        }

        public void show()
        {
            Console.WriteLine(Rno);
            Console.WriteLine(Sname);

            Console.WriteLine(Marks);


        }

    }


    class Assign4C
    {
        static void Main(string[] args)
        {

            Console.WriteLine("No of Students Data  ?  ");

            int capacity = int.Parse(Console.ReadLine());

            StudentData[] e1 = new StudentData[capacity];

            for (int i = 0; i < e1.Length; i++)
            {

                Console.WriteLine("\nEnter  Roll no = ");

                int Rno = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter  Student Name = ");

                string Sname = Console.ReadLine();


                Console.WriteLine("Enter Marks for Student = ");

                decimal Marks = decimal.Parse(Console.ReadLine());

                StudentData temp = new StudentData();

                temp.setvalues(Rno, Sname, Marks);

                e1[i] = temp;


            }



          


           




            Console.WriteLine("\n Enter the  roll No to be serched : ");

            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < e1.Length; i++)
            {

                if (e1[i].Rno == search)
                {
                    e1[i].show();
                }

            }



            Console.ReadLine();


        }

    }
}