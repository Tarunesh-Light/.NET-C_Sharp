using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color, obj;
            Console.Write("Enter colour: ");
            color= Console.ReadLine();
            Console.Write("Enter obj: ");
            obj = Console.ReadLine();
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(obj + " are Blue");
        }
    }
}
