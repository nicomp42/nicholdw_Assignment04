
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
            if (m < n) { long tmp = m; m = n; n = tmp; } // If num1 < num2, swap the numbers
            while (n != 0) {
                long r;
                r = m % n;
                m = n;
                n = r;
            }
            return m;
        }
    }
}
