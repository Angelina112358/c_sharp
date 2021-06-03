using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber first = new RationalNumber(12,25);
            RationalNumber second = new RationalNumber(11, 2);
            RationalNumber number;
            number = first + second;
            Console.WriteLine(first + "+" + second + "=" + number);
            number = first - second;
            Console.WriteLine(first + "-" + second + "=" + number);
            number = first * second;
            Console.WriteLine(first + "*" + second + "=" + number);
            number = first / second;
            Console.WriteLine(first + "/" + second + "=" + number);
            Console.WriteLine($"{first.Equals(second)}\n");
            Console.WriteLine($"{second.Equals(first)}\n");
            int firstBuffer;
            double secondBuffer;
            string str = "74/23";
            firstBuffer = first;
            Console.WriteLine(firstBuffer);
            secondBuffer = (double)first;
            Console.WriteLine(secondBuffer);
            second = (RationalNumber)str;
            Console.WriteLine(second);
        }
    }
}
