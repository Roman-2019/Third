using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            int startovoe, konechnoe;
            Console.WriteLine("Input start number:");
            startovoe = int.Parse(Console.ReadLine());
            Console.WriteLine("Input end number:");
            konechnoe = int.Parse(Console.ReadLine());
            Console.WriteLine("Input first prime number:");
            first = int.Parse(Console.ReadLine());

            int first_new = RaschetFizzBuzz.RaschetFizzBuzz.ProverkaNaProstoty(first);
            Console.WriteLine("first {0} ", first_new);
            Console.WriteLine("Input second prime number:");
            second = int.Parse(Console.ReadLine());
            int second_new = RaschetFizzBuzz.RaschetFizzBuzz.ProverkaNaProstoty(second);
            Console.WriteLine("second {0} ", second_new);
            Console.ReadKey();
            RaschetFizzBuzz.RaschetFizzBuzz.VivodSpiska(first_new,second_new,startovoe,konechnoe);
        }
    }
}
