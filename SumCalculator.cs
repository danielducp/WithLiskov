namespace WithLiskov
{
    public class SumCalculator : Calculator
    {
                public SumCalculator(int[] numbers) :base(numbers)
            {

            }

            public override int Calculate()
            {
                for (int i=0;i<_numbers.Length;i++)
                {
                    sum+=_numbers[i];
                }
                return sum;
            }
    }
}