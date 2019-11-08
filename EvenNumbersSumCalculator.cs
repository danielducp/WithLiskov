namespace WithLiskov
{
    public class EvenNumbersSumCalculator: Calculator //Inheriting from the calculator class
    {       
         //Constructor like in the calculator class
        public EvenNumbersSumCalculator(int[] numbers):base(numbers) 
        {

        }

         public override int Calculate() //The override gives us the ability to change the method implementation
            {
                for (int i=0;i<_numbers.Length;i++) //Loops through each element in an array
                {
                    if (_numbers [i] % 2 == 0) //Checks that the number is even
                    sum+=_numbers[i];
                }

                return sum;
       }
    }
}