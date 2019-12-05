using System;
using System.Collections.Generic;
using System.Linq;
namespace DnetExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of Extension Metods");

            var e1 = new List<string> { "a", "b", "c" };

            var r1 = e1.Count(); // .net built in ext method from System.Linq

            Console.WriteLine($"R1 = {r1}");

            var e2 = "Hello World";

            var r2 = e2.IsLengthEven();

            Console.WriteLine($"R2 = {r2}");
        }
    }
}
