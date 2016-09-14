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
            if (n==2)
                return true;
            int s = (int)Math.Sqrt(n);
            for (int i = 2; i <= s; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;

            
        }

        /// <summary>
        /// Sorts a given integer array
        /// </summary>
        /// <param name="arr">An integer array</param>
        public static void Sort(int[] arr)
        {
            int temp = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
        }
    }
}
