using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int tallestCandle = ar.Max();
            int successCandleBlowedOut = 0;
            successCandleBlowedOut = ar.Where(d => d == tallestCandle).Count();
            return successCandleBlowedOut;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
