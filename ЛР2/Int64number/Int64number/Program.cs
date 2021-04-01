using System;

namespace Int64number
{
    class Program
    {
        static Int64 CalculatePower(Int64 a)
        {
            Int64 power = 0;
            while (a > 0)
            {
                a /= 2;
                power += a;
            }
            return power;
        }
        static void Main(string[] args)
        {
            Int64 a = 0, b = 0;
            bool error = false;
            do
            {
                Console.Write("Введите a > 0: ");
                string strA = Console.ReadLine();
                error = !Int64.TryParse(strA, out a) || (a <= 0);
            } while (error);
            do
            {
                Console.Write("Введите b > 0: ");
                string strB = Console.ReadLine();
                error = !Int64.TryParse(strB, out b) || (b <= 0);
            } while (error);
            if (a > b)
            {
                Int64 temp = a;
                a = b;
                b = temp;
            }
            Int64 powerA = CalculatePower(a - 1);
            Int64 powerB = CalculatePower(b);
            Console.WriteLine("Степень двойки: " + (powerB - powerA));
            Console.ReadKey();
        }
    }
}
