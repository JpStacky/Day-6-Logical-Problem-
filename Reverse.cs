namespace ReverseNumber
{
    class Reverse
    {
        public static void Main()
        {
            Console.Write("Enter a Number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            ReverseNum(number);
        }
        static void ReverseNum(int number)
        {
            int ReNumber=0;
            
            while (number > 0)
            { 
                int remainder = number % 10;
                ReNumber = (ReNumber * 10) + remainder;
                number  = number / 10;
            }
            Console.WriteLine("Reverse number is = "+ReNumber);
        }

    }
}