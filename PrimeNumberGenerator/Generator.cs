using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumberGenerator
{
    class Generator
    {
        static readonly object locker = new object();

        public static List<long> getPrimesSequential(long startInt, long endInt, Form1 form)
        {
            //Creates the list to fill the prime numbers into
            List<long> primeNumbers = new List<long>();

            //Ensures the list is empty
            primeNumbers.Clear();

            // Starts timer
            Stopwatch timer = Stopwatch.StartNew();

            //Starts a for loop to check each number
            for (long i = startInt; i <= endInt; i++)
            {
                //Assume each number is a prime number
                bool isPrime = true;

                //For loops with the power of math to ascertain the actuality of prime status
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    //Wasn't actually a prime number.
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                //Adds the prime number to the list.
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }
            timer.Stop();
            long time = timer.ElapsedMilliseconds;
            form.TimestampsUpdate(startInt, endInt, "Sequential", time);

            return primeNumbers;
        }


        public static List<long> getPrimesParallel(long startInt, long endInt, Form1 form)
        {
            List<long> primeNumbers = new List<long>();
            primeNumbers.Clear();

            Stopwatch timer = Stopwatch.StartNew();

            Parallel.For(startInt, endInt, (i) =>
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    lock (locker)
                    {
                        primeNumbers.Add(i);
                    }
                }
            });
            timer.Stop();
            long time = timer.ElapsedMilliseconds;
            form.TimestampsUpdate(startInt, endInt, "Parallel", time);

            return primeNumbers;
        }
    }
}
