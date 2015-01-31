using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class PrimeSieve
    {
        private bool[] _Sieve;

        /// <summary>
        /// Generates an array of booleans where elements in the array are marked true where the index is a prime number.
        /// For example, calling Generate(10) would return the following array: 01110101000
        /// </summary>
        /// <param name="max">The maximum number checked for prime. The array returned will have a length of max + 1</param>
        public PrimeSieve(int max)
        {
            _Sieve = new bool[max + 1];

            // Initialize all as prime
            for (int i = 2; i <= max; i++)
            {
                _Sieve[i] = true;
            }

            // Loop through all primes
            int prime = 2;
            while (true)
            {
                if (prime > max / 2)
                {
                    break;
                }

                // mark factors of prime as not prime
                for (int index = prime * 2; index <= max; index += prime)
                {
                    if (index % prime == 0)
                    {
                        _Sieve[index] = false;
                    }
                }

                // Find the next prime
                prime++;
                while (!_Sieve[prime]) prime++;
            }
        }

        public int[] Primes
        {
            get
            {
                int count = _Sieve.Count(b => b);
                int[] primes = new int[count];
                int index = 0;
                for (int i = 0; i < _Sieve.Length && index < count; i++)
                {
                    if (_Sieve[i])
                    {
                        primes[index] = i;
                        index++;
                    }
                }

                return primes;
            }
        }

        public bool[] Sieve
        {
            get
            {
                return _Sieve.Clone() as bool[];
            }
        }
    }
}
