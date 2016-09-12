using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubTestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github!");
            Console.WriteLine("Please complete the following functions and initate a pull request.");
        }

        /// <summary>
        /// Tests if a given number is a prime
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        /// <summary>
        /// Sorts a given integer array
        /// </summary>
        /// <param name="a">An integer array</param>
        public static void Sort(int[] a)
        {
            int n = a.Length;
            int min, minI;
            for (int i = 0; i < n; i++)
            {
                minI = i;
                min = a[i];
                for (int j = i; j < n; j++)
                {
                    if (a[j] < min)
                    {
                        minI = j;
                        min = a[j];
                    }
                }
                a[minI] = a[i];
                a[i] = min;
            }
            
        }
    }
}
