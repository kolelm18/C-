namespace Project1
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var n in numbers)
                sum += n;
            return sum;
        }
    }
}
