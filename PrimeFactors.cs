using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<int> GetPrimes(int number)
        {
            var primes = new List<int>();

            for(int divisor = 2; divisor<=number; divisor++) 
             {
               while(number % divisor == 0) 
               {
                    primes.Add(divisor);
                    number = number / divisor;
                }
            }
            return primes;
        }


    }
}
