
namespace EuclidGCDNamespace
{
/// <summary>
/// Euclid GCD Computations
/// </summary>
public class EuclidGCD
    {
        /// <summary>
        /// Compute the Greatest Common Divisor of two numbers, using recurssion
        /// Algo at https://simple.wikipedia.org/wiki/Euclidean_algorithm
        /// </summary>
        /// <param name="m">First Number</param>
        /// <param name="n">Second Number</param>
        /// <returns>GCD of num1 and num2</returns>
        public static long ComputeGCD(long m, long n)
        {

            //if n = 0, we have found the greatest common deviser, return it.
            if (n == 0) { return m; }

            //If we have not found it yet, have the function call itself again and keep going. (this is an example of recursion)
            //This will happen until the above IF statment is satisfied, and then the answer will be returned.
            return ComputeGCD(n, (m % n));
        }
    }
}
