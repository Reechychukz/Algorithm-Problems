using System;

namespace primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the last number here: ");
            int lastNumber = int.Parse(Console.ReadLine());

            while(lastNumber < 2)
            {
                Console.Write("Enter a number equal to above 2 here!!!: ");
                lastNumber = int.Parse(Console.ReadLine());
            }

            Console.Write("The prime number(s) are: ");

            for (int i = 2; i <= lastNumber; i++)//Since 0 and 1 are not regarded as prime numbers, iteration starts from 2
            {
                int maxDivider = (int)Math.Sqrt(i);
                bool prime = true;
                int divider = 2;
                while (divider <= maxDivider)
                {
                    if (i % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;

                }
                if (prime)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
