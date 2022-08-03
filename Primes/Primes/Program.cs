using System;
using System.Collections;

namespace Primes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Primes primeFrom2To1000 = new Primes(2, 1000);
            foreach (long item in primeFrom2To1000)
            {
                Console.Out.Write($"{item} ");
            }
        }
    }

    public class Primes
    {
        private long min;
        private long max;

        public Primes() : this(2, 100)
        {
        }

        public Primes(long minimum, long maximum)
        {
            if (minimum < 2)
            {
                min = 2;
            }
            else
            {
                min = minimum;
            }

            max = maximum;
        }

        public IEnumerator GetEnumerator()
        {
            for (long possiblePrim = min; possiblePrim <= max; possiblePrim++)
            {
                bool isPrime = true;
                for (long possibleFactor = 2; possibleFactor <= (long) Math.Floor(Math.Sqrt(possiblePrim)); possibleFactor++)
                {
                    if ((possiblePrim % possibleFactor) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    yield return possiblePrim;
                }
            }
        }
    }
}