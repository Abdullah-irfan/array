using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            array.arry();

            arith.mark();

            Console.ReadKey();
        }
    }
    class array
    {
        public static void arry()
        {
            int[] Abdullah = { 10, 20, 30 };
            if (Abdullah.Sum() == 60)
            {
                Console.WriteLine("A-Grade");
            }
            else if (Abdullah.Sum() == 40)
            {
                Console.WriteLine("B-Grade");
            }
            else if (Abdullah.Sum() == 20)
            {
                Console.WriteLine("C-Grade");
            }
            else
            {
                Console.WriteLine("yah");
            }

        }
    }
    class arith
    {
        public static void mark()
        {

            Hashtable student = new Hashtable();
            student.Add(1,"aa");
            student.Add(2, 546);
            student.Add(3, "irfan");
            ICollection RollNumberCollection = student.Keys;
            foreach (int Rollno in RollNumberCollection)
            {
                Console.WriteLine("Rollno:" + Rollno + "name:" + student[Rollno]);
            }
            Console.ReadKey();
        }
    }
    
}