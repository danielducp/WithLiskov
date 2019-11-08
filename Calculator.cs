namespace WithLiskov
//This is the parent class calculator, which calculates the sum of elements in an array
{
    public abstract class Calculator
    {
        protected int sum = 0; //Initialised as 0, enabling it to be used throughout the program
        protected readonly int [] _numbers; //Declared an array called _numbers

        public Calculator(int[] numbers) //Constructor - which has an array as a variable
        {
            _numbers = numbers; 
        }

        public abstract int Calculate(); //Abstract Method which has no implementation
    }
}