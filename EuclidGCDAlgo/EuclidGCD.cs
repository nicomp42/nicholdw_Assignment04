
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
            // I need to have the larger number on the left so I can divide. I think
           long placeHolder = 0;
           if (m < n)
           // example m = 110 n = 210
            {
                placeHolder = m; // placeHolder = 110
                m = n; // m now is = 210
                n = placeHolder; // n now is = 110 
            }
           while (n != 0) 
            {
                placeHolder = m % n; // 210 mod 110 leaves a remainder of 40
                System.Console.WriteLine(placeHolder);
                m = n; // Make m equal the lower number, in this case 110
                System.Console.WriteLine(m);
                n = placeHolder; // make n what the remainder is so that we can continue to mod until their is no remainder
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("Final answer = " + m);
            return m;
            

        }
    }
}
