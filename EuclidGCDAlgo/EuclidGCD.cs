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
            long num = 0;
            if (m < n) {
                num = m;
                m = n;
                n = num;
            }

            while (n != 0) {
                num = m % n;
                m = n;
                n = num;
            }
            return m;
        }
    }
}
