using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaschetFizzBuzz
{
    public static class RaschetFizzBuzz
    {
        public static void VivodSpiska(int st_znach, int end_znach, int start, int kon)
        {
            //int change;
            //if (st_znach>end_znach) 
            //{
            //    change = st_znach;
            //    st_znach = end_znach;
            //    end_znach = change;
            //}
            if (start < kon)
            {
                for (int i = start; i <= kon; i++)
                {
                    if (i % st_znach == 0 && i % end_znach == 0)
                    {
                        string y = "FizzBuzz";
                        Console.WriteLine(y);
                    }
                    else if (i % st_znach == 0 && !(i % end_znach == 0))
                    {
                        string y = "Fizz";
                        Console.WriteLine(y);
                    }
                    else if (!(i % st_znach == 0) && i % end_znach == 0)
                    {
                        string y = "Buzz";
                        Console.WriteLine(y);
                    }
                    else
                        Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = start; i >= kon; i--)
                {
                    if (i % st_znach == 0 && i % end_znach == 0)
                    {
                        string y = "FizzBuzz";
                        Console.WriteLine(y);
                    }
                    else if (i % st_znach == 0 && !(i % end_znach == 0))
                    {
                        string y = "Fizz";
                        Console.WriteLine(y);
                    }
                    else if (!(i % st_znach == 0) && i % end_znach == 0)
                    {
                        string y = "Buzz";
                        Console.WriteLine(y);
                    }
                    else
                        Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        public static int ProverkaNaProstoty(int x)
        {
            //if (x == 0)
            //{
            //    //for (int i = 1; i < first; i++)
            //    //while (x == 0)
            //    //{
            //        Console.WriteLine("Please input prime number!");
            //        x = int.Parse(Console.ReadLine());
            //        ProverkaNaProstoty(x);
            //    //}
            //}
            if (x > 0)
            {
                for (int i = 2; i < x; i++)
                    while ((x % i == 0 && x != i && i != 1))
                    {
                        Console.WriteLine("Please input prime number!");
                        x = int.Parse(Console.ReadLine());
                        ProverkaNaProstoty(x);
                    }
            }
            if (x < 0)
            {
                for (int i = x; i < -2; i++)
                    while ((x % i == 0 && x != i && i != 1))
                    {
                        Console.WriteLine("Please input prime number!");
                        x = int.Parse(Console.ReadLine());
                        ProverkaNaProstoty(x);
                    }
            }
            return x;
        }
    }
}
