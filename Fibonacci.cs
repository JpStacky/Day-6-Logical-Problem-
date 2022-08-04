namespace FibonacciSeries
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the no. of terms to print Fibonacci Series = ");
            int maxLimit = Convert.ToInt32(Console.ReadLine());
            int firstValue = 0;
            int secondValue = 1;
            int sum = 0;
            int count = 3;
            Console.WriteLine("0 \n1");
            while (count <= maxLimit)
            {
                ++count;
                sum = firstValue+ secondValue;
                Console.WriteLine(sum);
                firstValue = secondValue;
                secondValue = sum;
            }
        }
    }
}