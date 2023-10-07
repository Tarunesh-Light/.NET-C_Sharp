using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1: ");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }
    }
}
