namespace PerfectNumber
{
    class Perfect
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number to check for perfect number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            CheckPerfect(number);
        }
        static void CheckPerfect(int number)
        {
            int count = 1;
            int sum = 0;
            while (count < number)
            {
                if (number % count == 0)
                    sum += count;
                ++count;
            }
            if (sum == number)
                Console.WriteLine("The number is a perfect number");
            else
                Console.WriteLine("The number is not a perfect number");
        }
    }
}