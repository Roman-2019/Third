using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trenirovka
{
    class Program
    {
        //static double Raschet(double x, double y, double z) 
        //{
        //    double result=1;
        //    for (double i=x;i<=z;i=x+(x+(x/100)*y)) 
        //    {
        //        result += 2;
        //        x = i;
        //    }
        //    Console.WriteLine("Skier ran {0} kilometrs za {1} days",z,result);
        //    return result;
        //}
        //static double Validation(double i) 
        //{
        //    while (i <= 0) 
        //    {
        //        Console.WriteLine("Input correct value");
        //        i= double.Parse(Console.ReadLine());
        //        Validation(i);
        //    }
        //return i;
        //}

       static void Main(string[] args)
        {
            double result;
            string[] skiers = new string[1] { "" };
            int schetchik=0;
            string Yes,vvod_znach;
            double x, y, z;
            Console.WriteLine("Do you want continue? Yes or No");
            Yes = Console.ReadLine();
            while (Yes == "Yes" || Yes=="Y" || Yes=="y")
            {
                Console.WriteLine("Input how many kilometrs skier ran in the first day X:");
                vvod_znach= Console.ReadLine(); 
                while (!double.TryParse(vvod_znach, out x))
                {
                    Console.WriteLine("It is not number!");
                    Console.WriteLine("Input correct value X:");
                    vvod_znach = Console.ReadLine();
                }
                TrenirovkaSkier.TrenirovkaSkier.Validation(x);
                //Validation(x);
                Console.WriteLine("Input velichiny yvelicheniya probega Y:");
                vvod_znach = Console.ReadLine();
                while (!double.TryParse(vvod_znach, out y))
                {
                    Console.WriteLine("It is not number!");
                    Console.WriteLine("Input correct value Y:");
                    vvod_znach = Console.ReadLine();
                }
                TrenirovkaSkier.TrenirovkaSkier.Validation(y);
                Console.WriteLine("Input granichniy probeg Z:");
                vvod_znach = Console.ReadLine();
                while (!double.TryParse(vvod_znach, out z))
                {
                    Console.WriteLine("It is not number!");
                    Console.WriteLine("Input correct value Z:");
                    vvod_znach = Console.ReadLine();
                }
                TrenirovkaSkier.TrenirovkaSkier.Validation(z);
                //Raschet(x, y, z);
                schetchik++;
                Array.Resize(ref skiers, schetchik);
                skiers[schetchik - 1] = "First skier ran "+z+"km at "+ TrenirovkaSkier.TrenirovkaSkier.Raschet(x, y, z) + " days";
                Console.WriteLine("Do you want continue? Yes or No");
                Yes = Console.ReadLine();
            }
            Console.WriteLine("Display menu, yes?");
            Yes = Console.ReadLine();
            if (Yes == "Yes" || Yes == "Y" || Yes == "y")
            {
                Console.WriteLine("Menu: \n1 - Display information about skiers \n2 - Close");
                int j=int.Parse(Console.ReadLine());
                switch (j) 
                {
                    case 1:
                        for (int i = 0; i < skiers.Length; i++)
                            Console.WriteLine(skiers[i]);
                        break;
                    case 2:
                        break;
                }
            }
                Console.ReadKey();
        }
    }
}
