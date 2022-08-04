namespace CouponNumber
{
    class Coupon
    {
        public static void Main()
        {
            Console.Write("Enter the no. of coupons to be generated = ");
            int number  = Convert.ToInt32(Console.ReadLine());
            GenerateRandomNumber(number);
        }
        public static void GenerateRandomNumber(int number)
        {
            int[] coupon = new int[number];
            int countCoupon = 0;            //No. of unique coupons generated.
            int count = 0;                  //No. of times random() is executed.
            int index;                      //Array Index for traversing.
            Random random = new Random();

            while (countCoupon < number)
            {
                int temp = random.Next(number);
                Console.WriteLine(temp);
                ++count;
                for (index = 0; index < countCoupon; index++)
                {
                    if (coupon[index] == temp)
                        break;
                }
                if (index == countCoupon)
                {
                    coupon[index] = temp;
                    ++countCoupon;
                    Console.WriteLine("countCoupon = "+countCoupon  );
                }
            }
            Console.WriteLine("Total random number needed to have all distinct numbers = " + count);
            Console.Write("Random Numbers are : ");
            for(index = 0; index<countCoupon; index++)
                Console.Write(coupon[index]+" ");

        }
    }
}