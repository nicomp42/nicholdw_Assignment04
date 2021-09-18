﻿using System;

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
            long r = 0;
            if(m < n){
                r = m;
                m = n;
                n = r;
            }
            while(n != 0){
                r = m % n;
                m = n;
                n = r;
            }
            return m;
        }
    }
}
