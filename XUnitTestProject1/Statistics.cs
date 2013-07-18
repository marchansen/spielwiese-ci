using System;
using System.Collections.Generic;
using System.Linq;

namespace XUnitTestProject1
{
    public class Statistics
    {
        public static int Min(int[] sequence)
        {
            return sequence.Min();
        }

        public static int Max(int[] sequence)
        {
            return sequence.Max();
        }

        public static int Count(int[] sequence)
        {
            return sequence.Count();
        }

        public static double Avg(int[] sequence)
        {
            return sequence.Average(); 
        }

        public static string Romanish(int zahl)
        {
            var result = "";
            double b = zahl / 5000d;
            var countM = (int) Math.Floor(b);
            if (countM > 3 && countM <= 5)
            {
                var countC = 5 - countM;
                for (int i = 0; i < countC; i++)
                    result += "D";    
            }

            if (countM > 0)
                result += "M";

            if (countM > 5)
            {
                var countC = countM - 5;
                for (int i = 0; i < countC; i++)
                    result += "C";
            }


            return result;
        }
    }
}