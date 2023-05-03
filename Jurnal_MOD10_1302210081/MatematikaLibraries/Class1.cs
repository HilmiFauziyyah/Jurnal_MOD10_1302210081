﻿using System.Reflection.Metadata.Ecma335;

namespace MatematikaLibraries
{
    public class Class1
    {
        public void FPB(int temp, int input1, int input2)
        {
            while(input2 != 0)
            {
                temp = input2;
                input2 = input1 % input1;
                input1 = temp;
            }
        }
        public void KPK(int result, int input1, int input2)
        {

            int max;
            int min; 
            max = Math.Max(input1, input2);
            min = Math.Min(input1, input2);
            result = max;

            while(result % min != 0)
            {
                result = result + max;
            }

        }
        public static string turunan(int[]persamaan)
        {
            int n;
            int i;
            string result;
            n = persamaan.Length - 1;
            int[] turunan = new int[n+1];

            for (i = 1; i <= n; i++)
            {
                turunan[i] = persamaan[i] * (n - 1);
            }

            result = turunan[0] + "x^" + (n - 1);
            
            for (i = 1; i<n; i++)
            {
                if (turunan[i] > 0 )
                {
                    result = result + " + " + turunan[i] + "x" + (n - i - 1);
                }else if(turunan[i] < 0){
                    result = result+ "-" + (turunan) +"x"+(n -i -1);
                }
            }
            return result;
        }

        public static string integral(int[] persamaan)
        {
            int n;
            int i;
            string result;
            n = persamaan.Length;
            int[] integral = new int[n+1];

            for (i = 1; i <= n; i++)
            {
                integral[i] = persamaan[i - 1] / i;
            }
            result = "C";

            for (i = n; i >= 0; i--)
            {
                if (integral[i] > 0)
                {
                    result = "+" + integral[i] + "x" + (i + 1) + result;
                }else if (integral[i] < 0)
                {
                    result = integral[i] +"x^" + (i + 1) + result;
                }
            }
            return result;
        }
        
    }
}