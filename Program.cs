using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("A-ni daxil et:");

            double a = double.Parse(Console.ReadLine());

            Console.Write("B-ni daxil et:");

            double b = Convert.ToInt32(Console.ReadLine());

            double c = a + b;

            Console.WriteLine($"{a}+{b}={c}");













        }
    }
}
