using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                BuildStaircase(n);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Enter a numeric pls");
            }
        }

        public static void BuildStaircase(int sizeStaircase)
        {
            if((0 < sizeStaircase) && (sizeStaircase <= 100))
            {
                for(int lenghtOfSidestep = 1; lenghtOfSidestep <= sizeStaircase; lenghtOfSidestep++)
                {
                    int numberSpaces = sizeStaircase - lenghtOfSidestep;
                    BuildASidestep(lenghtOfSidestep, numberSpaces);
                }
            }
        }

        public static void BuildASidestep(int lenghtOfSidestep, int numberSpaces)
        {
            for(int i = 1; i <= numberSpaces; i++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= lenghtOfSidestep; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
