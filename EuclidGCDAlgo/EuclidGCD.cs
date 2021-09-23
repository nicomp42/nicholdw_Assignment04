/*
 * William Arthur
 * arthurwb@mail.uc.edu
 * IT 3045
 * Assignment 02
 * Due September 23
 * Description: Your job is to complete the method EuclidGCD.ComputeGCD().
 * Citations:
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
            while (m != 0)
            {
                long temp = 0;

                temp = m;

                m = n % m;
                n = temp;
            }

            return n;
        }
    }
}
