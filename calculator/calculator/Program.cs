using System;
namespace app
{
    class Program
    {
        static void Main(string[]arg)
        {
            double a;
            double b;
            int s;
            Console.WriteLine("Enter first number :");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number :");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your choice");
            Console.WriteLine("Press 1 for add");
            Console.WriteLine("Press 2 for sub");
            Console.WriteLine("Press 3 for mult");
            Console.WriteLine("Press 4 for div");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choice = "+s);
            Console.Write("Answer=");    
            switch (s)
            {
                case 1:
                    Console.WriteLine("Sum is = " + (a+b));
                    break;
                case 2:
                    Console.WriteLine(a-b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    Console.WriteLine(a / b);
                    break;
                default:
                   Console.WriteLine("wrong choice");
                    break;
                   
            }
            



        }
    }
}