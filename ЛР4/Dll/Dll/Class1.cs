using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll
{
    unsafe public class Pointer
    {
        static public void Pointers()
        {
            int* x;
            int y = 10;
            x = &y;
            Console.WriteLine(*x);
            y = y + 20;
            Console.WriteLine(*x);
            *x = 50;
            Console.WriteLine(y);
        }
    }
}
    public class Calculator
    {
        static public void Actions()
        {
            double a, b, c;
            string number;
            char sign;
            do
            {
                Console.WriteLine("Введите первое число: ");
                number = Console.ReadLine();
                Console.Clear();
            } while (!double.TryParse(number, out a));
            do
            {
                Console.WriteLine("Введите второе число: ");
                number = Console.ReadLine();
                Console.Clear();
            } while (!double.TryParse(number, out b));
            do
            {
                Console.Clear();
                Console.WriteLine("Введите знак (+, -, *, /)");
                number = Console.ReadLine();
                Console.Clear();
            } while (!char.TryParse(number, out sign) || (sign != '+' && sign != '-' && sign != '*' && sign != '/'));
            switch (sign)
            {
                case '+':
                    c = a + b;
                    Console.WriteLine("{0}" + sign + "{1} = {2}", a, b, c);
                    break;
                case '-':
                    c = a - b;
                    Console.WriteLine("{0}" + sign + "{1} = {2}", a, b, c);
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine("{0}" + sign + "{1} = {2}", a, b, c);
                    break;
                case '/':
                    if (b == 0) Console.WriteLine("/0 нельзя");
                    else
                    {
                        c = a / b;
                        Console.WriteLine("{0}" + sign + "{1} = {2}", a, b, c);
                    }
                    break;
            }
        }
    }
    public class Tetrahedron
    {
        static public void Volume()
        {
            double a;
            string number;
            double volume;
            do
            {
                Console.WriteLine("Введите длину стороны: ");
                number = Console.ReadLine();
                Console.Clear();
            } while (!double.TryParse(number, out a) || a <= 0);
            volume = (Math.Pow(a, 3) * Math.Sqrt(2)) / 12;
            Console.WriteLine(volume);
        }
    }
