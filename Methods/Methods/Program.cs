using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student("Light");
            Student("Kira");
            int num1 = power(2);
            Console.WriteLine(num1);
        }

        static void Student(string a)
        {
            Console.WriteLine("Student is " + a);
        }

        static int power(int num)
        {
            return num*num*num;
        }
    }
}
