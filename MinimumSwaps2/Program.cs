using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSwaps2
{
    class Program
    {
        static int minimumSwaps(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minOfSubArr = getMin(i + 1, arr);
                if (arr[i] > minOfSubArr)
                {
                    int temp = arr[i];
                    int position = getIndex(minOfSubArr, arr);
                    arr[i] = arr[position];
                    arr[position] = temp;
                    total++;
                }
            }
            return total;
        }
        static int getMin(int index, int[] arr)
        {
            int[] newArr = new int[arr.Length - index];
            int Nindex = 0;
            for(int i = index; i < arr.Length; i++)
            {
                newArr[Nindex] = arr[i];
                Nindex++;
            }
            return newArr.Min();
        }

        static int getIndex(int num, int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    return i;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            Console.WriteLine(res);
            Console.ReadKey();
            //textWriter.WriteLine(res);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
