using System;

namespace OpenLab_01._2
{
    class Program
    {
        public static int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Put your first number :");
            var input = Console.ReadLine();
            Console.WriteLine("Put your second number :");
            var input2 = Console.ReadLine();
            int x = Int32.Parse(input);
            int y = Int32.Parse(input2);
            int sum = Sum(x, y);
            Console.WriteLine($"The sum is {sum}.");

        }
    }
}
