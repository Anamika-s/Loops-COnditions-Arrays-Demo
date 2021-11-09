using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
           // How to take input from user
             // Console.ReadLine();
             int num1, num2;
             int choice;
             Console.WriteLine("Enter Num1");
             // 0 -255
             num1 = Byte.Parse(Console.ReadLine());
             Console.WriteLine("Enter Num2");
             num2 = Convert.ToByte(Console.ReadLine());
            //  Console.WriteLine("Enter your choice");
            //  choice = Convert.ToByte(Console.ReadLine());
             
             Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, (num1+num2));
             Console.WriteLine("Difference of {0} and {1} is {2}", num1, num2, (num1-num2));
             Console.WriteLine("Product of {0} and {1} is {2}", num1, num2, (num1*num2));
             Console.WriteLine("Quotient of {0} and {1} is {2}", num1, num2, (num1/num2));
             Console.WriteLine("Remainder of {0} and {1} is {2}", num1, num2, (num1%num2));
             
             




        }
    }
}
