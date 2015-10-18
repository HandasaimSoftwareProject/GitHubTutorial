using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; /*
using System.Of[A].Down; */

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
            // TODO: Complete fhe funtion
            //ctrl r+ a
            int a = (int)(Math.Sqrt(n));
            for (int i = 2; i <=a; i++ )
            {
                if((n%i==0)&(i!=n))
                {
                    return false;
                    
                }

            }
            return true;
        }

        /// <summary>
        /// Sorts a given integer array
        /// </summary>
        /// <param name="a">An integer array</param>
        public static void Sort(int[] a)
        {
            Array.Sort(a);
        }

        /// <summary>
        /// Counts the number of sequenes of the digits 0,1 with
        /// no 3 consecutive 1's
        /// 
        /// Example: 001101010110 is valid, 00111001 is not valid
        /// </summary>
        /// <param name="a">The sequence length</param>
        /// <returns>The number of sequences</returns>
        public static int CountVectors(int a)
        {
            if (a / 1000 < 0)
            {
                return (0);
            }
            if (a / 1000 == 0)
            {
                return(1);
            }
            else
            {
               return((CountVectors(a/10))+(CountVectors(a/100))+(CountVectors(a/1000))); 
            }
           
        }
    }
}
