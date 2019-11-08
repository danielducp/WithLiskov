using System;

namespace WithLiskov
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1,2,3,4,5 };

            Calculator sum = new SumCalculator(numbers);
            
 

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers:  {evenSum.Calculate()}");
            
            Console.WriteLine ();

            Calculator oddSum = new OddNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the odd numbers:  {oddSum.Calculate()}");


            Console.WriteLine ();

                       Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

        }
    }
}
