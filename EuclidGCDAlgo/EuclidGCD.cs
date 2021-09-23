/* Joseph Tankersley tankerjh@mail.uc.edu
 * Contemporary Programming Fall 2021
 * Assignment 04
 * 23 September 2021
 * Class containing a method for finding the GCD of two numbers
 * Implementation of the Euclidean Algorithm as described by https://simple.wikipedia.org/wiki/Euclidean_algorithm
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
            if (m < n) //ensures m is not the smaller of the two numbers
            {
                long buffer = m;
                m = n;
                n = buffer;
            }

            long r;
            while (n != 0)
            {
                r = m % n;
                m = n;
                n = r;
            }

            return m;
        }
    }
}
