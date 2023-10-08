using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 9, 5 };
            a1[2] = 8;

            string[] str=new string[100];
            str[0] = "Tarun";
            str[1] = "Besh";

            Console.WriteLine(a1[2]);
            Console.WriteLine(str[0] + str[1]);
        }
    }
}
