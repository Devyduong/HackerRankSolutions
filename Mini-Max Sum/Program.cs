using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            maxSum(arr, 0, 0);
            Console.Write(" ");
            minSum(arr, 0, 0);
        }
        static void maxSum(int[] arr, long currentSum, int TT)
        {
            if(TT == 4)
            {
                Console.Write(currentSum);
            }
            else
            {
                int[] newArr;
                TT++;
                currentSum = currentSum + arr.Max();
                arr = createNewArr(arr, arr.Max());
                maxSum(arr, currentSum, TT);
            }
        }
        static void minSum(int[] arr, long currentSum, int TT)
        {
            if (TT == 4)
            {
                Console.Write(currentSum);
            }
            else
            {
                TT++;
                int k = arr.Min();
                currentSum = currentSum + arr.Min();
                arr = createNewArray(arr, arr.Min());
                minSum(arr, currentSum, TT);
            }
        }
        static int[] createNewArr(int[] old, int currentMax)
        {
            int[] newArr = new int[old.Length];
            int indexNewArr = 0;
            for(int i = 0; i < old.Length; i++)
            {
                if(old[i] != currentMax)
                {
                    newArr[indexNewArr] = old[i];
                    indexNewArr++;
                }
                else
                {
                    for(int j = i+1; j < old.Length; j++)
                    {
                        newArr[indexNewArr] = old[j];
                        indexNewArr++;
                    }
                    return newArr;
                }
            }
            return newArr;
        }
        static int[] createNewArray(int[] old, int currentMin)
        {
            int[] newArr = new int[old.Length-1];
            int indexNewArr = 0;
            for (int i = 0; i < old.Length; i++)
            {
                if (old[i] != currentMin)
                {
                    newArr[indexNewArr] = old[i];
                    indexNewArr++;
                }
                else
                {
                    for (int j = i + 1; j < old.Length; j++)
                    {
                        newArr[indexNewArr] = old[j];
                        indexNewArr++;
                    }
                    return newArr;
                }
            }
            return newArr;
        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            miniMaxSum(arr);
            Console.ReadKey();
        }
    }
}
