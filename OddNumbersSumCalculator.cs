namespace WithLiskov
{
    public class OddNumbersSumCalculator : Calculator
    {
        public OddNumbersSumCalculator(int[] numbers):base(numbers)
        {

        }

         public override int Calculate()
            {
                for (int i=0;i<_numbers.Length;i++)
                {
                    if (_numbers [i] % 2 != 0)
                    sum+=_numbers[i];
                }

                return sum;
       }
    }
}
