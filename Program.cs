using System;

namespace fundamentals
{
    class Program
    {
        
        static void Main(string[] args)
        {
            for ( int i = 1; i <= 255; i++)
                {
                    Console.WriteLine(i);
                }
                    
            Divisible();
            FizzBuzz();
        }

        private static void Divisible()
        {
            for (int i = 0; i <= 100; i ++)
            {
                if ( i % 15 == 0)
                {
                    Console.WriteLine("");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
            if (i % 15 == 0)
            {
                Console.WriteLine("FIZZBUZZ");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("FIZZ");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
            else 
            {
                    Console.WriteLine(i);
            }
            }
        
        }

    }
}
