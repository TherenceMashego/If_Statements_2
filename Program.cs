using System;

namespace If_Statements_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(2, 10));
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            return (num1 > num2) ? num1 : num2;
        }
    }
}
