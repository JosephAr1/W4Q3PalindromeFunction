using System;

namespace W4Q3PalindromeFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;

            Console.WriteLine("Please enter a number:");
            j = Convert.ToInt32(Console.ReadLine());

            Pal(j);
        }
        static void Pal(int j)
        {
            int num, sum = 0, temp;

            temp = j;
            while(j > 0)
            {
                num = j % 10;
                j = j / 10;
                sum = sum * 10 + num;
            }
            Console.WriteLine("The reverse number is: {0} " , sum);
            if(temp == sum)
            {
                Console.WriteLine("The number is Palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a Palindrome");
            }
            Console.ReadLine();
        }
    }
}
