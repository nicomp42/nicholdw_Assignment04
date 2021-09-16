/*
 * Logan Farwick
 * farwicls@mail.uc.edu
 * Course/Term: IT3045C Fall 2022 
 * Assignment:  04
 * Due Date: 09/23/2021
 * Description: Finishing the Euclid Algorithm to make the test cases work
 * Citations: https://simple.wikipedia.org/wiki/Euclidean_algorithm (psuedo code link from slides)
 * Anything else: N/A
 */
namespace EuclidGCDNamespace
{
/// <summary>
/// Euclid GCD Computations
/// </summary>
public class EuclidGCD
    {
        /// <summary>
        /// Compute the Greatest Common Divisor of two numbers
        /// Algo at https://simple.wikipedia.org/wiki/Euclidean_algorithm
        /// </summary>
        /// <param name="m">First Number</param>
        /// <param name="n">Second Number</param>
        /// <returns>GCD of num1 and num2</returns>
        public static long ComputeGCD(long m, long n)
        {
            long swap = 0;
            if (m < n)
            {
                swap = m;
                m = n;
                n = swap;
            }
            while (n != 0)
            {
                swap = m % n;
                m = n;
                n = swap;
            } return m;
        }
    }
}
