using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            if(s.Contains("AM"))
            {
                s = s.Remove(8);
                int hour = int.Parse(s.Substring(0, 2));
                if (hour == 12)
                {
                    return "00" + s.Substring(2, 6);
                }
                return s;
            }
            else
            {
                s.Remove(8);
                int hour = int.Parse(s.Substring(0, 2));
                if (hour < 12) hour = hour + 12;
                return hour + s.Substring(2, 6);
            }

        }

        static void Main(string[] args)
        {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            //tw.WriteLine(result);
            Console.WriteLine(result);
            //tw.Flush();
            //tw.Close();
            Console.ReadKey();
        }
    }
}
