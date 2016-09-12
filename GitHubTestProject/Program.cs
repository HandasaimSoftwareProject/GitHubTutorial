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
            bool Is = false;
            for (int i = 0; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    Is = true;
            }
            return Is;
        }

        /// <summary>
        /// Sorts a given integer array
        /// </summary>
        /// <param name="a">An integer array</param>
        public static void Sort(int[] a)
        {
            int help = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        help = a[i];
                        a[i] = a[j];
                        a[j] = help;
                    }

                }
            }
        }
        
    }
}
