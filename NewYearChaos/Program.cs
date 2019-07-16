using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearChaos
{
    class Program
    {
        static void minimumBribes(int[] q)
        {
            int[] arr = new int[q.Length];
            for(int i = 0; i < q.Length; i++)
            {
                arr[i] = i + 1;
            }
            bool chaotic = false;
            int bribes = 0;
            for(int i = 0; i < q.Length; i++)
            {
                if(q[i] > arr[i])
                {
                    if ((q[i] - arr[i]) >= 2) chaotic = true;
                    bribes = bribes + (q[i] - arr[i]);
                }
            }
            
            if (chaotic) Console.WriteLine("Too chaotic");
            else Console.WriteLine(bribes);
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[] q = new int[10000];
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;

                minimumBribes(q);
            }

            Console.ReadKey();
        }
    }
}

