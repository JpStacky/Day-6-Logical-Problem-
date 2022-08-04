namespace PrimeNumber
{
    class Prime
    {
        static int number;
        public static void Main()
        {
            Console.WriteLine("Enter a number to check for prime = ");
            number = Convert.ToInt32(Console.ReadLine());
            CheckPrime();
        }
        static void CheckPrime()
        {
            int count = 0;
           for(int i = 2; i < number; i++)
           {
              if(number % i == 0)
                    count++;
           }
           if(count != 0)
                Console.WriteLine("Number is Not Prime");
            else
                Console.WriteLine("Number is Prime");
        }
    }
}