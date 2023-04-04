using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pair
{
    class number
    {
        public void pair(int a)
        {
            int[] arr = new int[a];
            Console.Write("\nPair number\nResult: ");
            for(int i = 0; i < arr.Length; i += 2) 
            {
                arr[i] = i;
            }
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

namespace NotPair
{
    class number
    {
        public void notpair(int a)
        {
            int[] arr = new int[a];
            Console.Write("\n\nNot pair number\nResult: ");
            for (int i = 1; i < arr.Length; i += 2)
            {
                arr[i] = i;
            }
            for (int i = 1; i < arr.Length; i += 2)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

namespace Prime
{
    class number
    {
        public void prime(int a)
        {
            Console.Write("\n\nPrime number\nResult: ");
            bool[] primes = new bool[a + 1];
            for (int i = 2; i <= a; i++)
            {
                primes[i] = true;
            }
            for (int p = 2; p * p <= a; p++)
            {
                if (primes[p] == true)
                {
                    for (int i = p * 2; i <= a; i += p)
                    {
                        primes[i] = false;
                    }
                }
            }
            for (int i = 2; i <= a; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

namespace Fibon
{
    class number
    {
        public void fib(int a)
        {
            Console.Write("\n\nFibbonachi number\nResult: ");
            int[] fib = new int[a + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= a; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            Console.WriteLine("Числа Фібоначчі до {0}:", a);
            for (int i = 0; i <= a; i++)
            {
                Console.Write(fib[i] + " ");
            }
        }
    }
}