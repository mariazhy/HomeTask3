using System;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int finish = 0;
            int attemptsCount = 0;
            do
            {
                if (attemptsCount != 0)
                {
                    Console.WriteLine("Please try again. " + (5 - attemptsCount) + " attempt(s) left");
                }
                Console.WriteLine("Please input first value of the range:");
                bool isValidatedFirst = int.TryParse(Console.ReadLine(), out int inputFirst) && inputFirst > 0;
                Console.WriteLine("Please input last value of the range:");
                bool isValidatedLast = int.TryParse(Console.ReadLine(), out int inputLast) && inputLast > 0;
                if (isValidatedFirst && isValidatedLast)
                {
                    start = inputFirst > inputLast ? inputLast : inputFirst;
                    finish = inputLast > inputFirst ? inputLast : inputFirst; 
                }
                else
                {
                    Console.WriteLine("Enter natural numbers with range >= 10");
                }
                attemptsCount++;
            } while (finish - start < 10 || attemptsCount > 5);

            var sum = 0;
            for (int i = start; i <= finish; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write($"{i} \t");
                    sum += i;
                }
            }
            Console.WriteLine($"\nSum is: {sum}");
        }
    }
}