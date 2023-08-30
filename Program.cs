// See https://aka.ms/new-console-template for more information
using Microsoft.Win32.SafeHandles;

namespace Euler_FiftyThree 
{
    class Program 
    {
        static void Main ()
        {
            long count = 0;
            for (long i = 23; i <= 100; i++)
            {
                for (long j = 0; j <= i; j++)
                {
                    if (Choose(i,j) >= 1000000)
                    {
                        Console.WriteLine($"{i} choose {j} is {Choose(i,j)} total {i-2*j +1}");
                        count += i-2*j +1;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }
        static long Choose (long n, long r)
        {
            if (n-r > r)
            {
                r = n-r;
            }
            long prod = 1;
            for (long i = r + 1; i<=n ; i++)
            {
                prod *= i;
            }
            prod /= Factorial(n-r);
            return prod;
        }
        static long Factorial (long number) {
            if (number == 0 ) {return 1;}
            return Factorial(number - 1) * number;
        } 
    }
}