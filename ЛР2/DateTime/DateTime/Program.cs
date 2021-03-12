using System;


namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("G"));
            Console.WriteLine(date.ToString("F"));
            string allTime = date.ToString("yyyyMMddHHmmss");
            Console.WriteLine(allTime);
            int[] digits = new int[allTime.Length];
            for(int i = 0; i <= 9; i++)
            {
                digits[i] = 0;
            }
            for(int i = 0; i < allTime.Length; i++)
            {
                if(allTime[i]>='0'&&allTime[i]<='9')
                { 
                    digits[allTime[i] - 48] ++;   
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Количество {i}: " + digits[i]);
            }
            Console.ReadKey();
        }
    }
}
