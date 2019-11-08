using System;

namespace WithLiskov
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1,2,3,4,5 }; //The chosen numbers

            
 

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers:  {evenSum.Calculate()}"); //Outputs the sum of the even numbers
            
            Console.WriteLine ();

            Calculator oddSum = new OddNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the odd numbers:  {oddSum.Calculate()}");//Outputs the sum of the odd numbers


            Console.WriteLine ();
            Calculator sum = new SumCalculator(numbers); //creates an object sumcalculator
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}"); //Outputs the sum of numbers

        }
    }
}
