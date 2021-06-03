using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RationalNumber: IComparable<RationalNumber>
    {
        public int Numerator { get; set; }
        private int denominator = 1;
        public int Denominator 
        {
            get { return denominator; }
            set 
            {
                if (value == 0) { }
                else { denominator = value; }
            }
        }
        public RationalNumber() { }
        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public static RationalNumber operator +(RationalNumber number1, RationalNumber number2)
        {
            Reduction(number1);
            Reduction(number2);
            int nodDenominators = NOD(number1.Denominator, number2.Denominator);
            int numerator = (number1.Numerator * number2.Denominator / nodDenominators) + (number2.Numerator * number1.Denominator / nodDenominators);
            int denominator = number1.Denominator * number2.Denominator / nodDenominators;
            return new RationalNumber
            {
                Numerator = numerator,
                Denominator = denominator
            };
        }
        public static RationalNumber operator -(RationalNumber number1, RationalNumber number2)
        {
            Reduction(number1);
            Reduction(number2);
            int nodDenominators = NOD(number1.Denominator, number2.Denominator);
            int numerator = (number1.Numerator * number2.Denominator / nodDenominators) - (number2.Numerator * number1.Denominator / nodDenominators);
            int denominator = number1.Denominator * number2.Denominator / nodDenominators;
            return new RationalNumber
            {
                Numerator = numerator,
                Denominator = denominator
            };
        }
        public static RationalNumber operator *(RationalNumber number1, RationalNumber number2)
        {
            Reduction(number1);
            Reduction(number2);
            int numerator = number1.Numerator * number2.Numerator;
            int denominator = number1.Denominator * number2.Denominator;
            int nod = NOD(numerator, denominator);
            return new RationalNumber
            {
                Numerator = numerator / nod,
                Denominator = denominator / nod
            };
        }
        public static RationalNumber operator /(RationalNumber number1, RationalNumber number2)
        {
            Reduction(number1);
            Reduction(number2);
            int numerator = number1.Numerator * number2.Denominator;
            int denominator = number1.Denominator * number2.Numerator;
            int nod = NOD(numerator, denominator);
            return new RationalNumber
            {
                Numerator = numerator,
                Denominator = denominator
            };
        }
        public static bool operator <(RationalNumber number1, RationalNumber number2)
        {
            Reduction(number1);
            Reduction(number2);
            if (number1.Numerator * number2.Denominator < number1.Denominator * number2.Numerator)
                return true;
            else
                return false;
        }
        public static bool operator >(RationalNumber number1, RationalNumber number2)
        {
            Reduction(number1);
            Reduction(number2);
            if (number1.Numerator * number2.Denominator < number1.Denominator * number2.Numerator)
                return true;
            else
                return false;
        }
        public static bool operator ==(RationalNumber number1, RationalNumber number2)
        {
            Reduction(number1);
            Reduction(number2);
            return number1.Equals(number2);
        }
        public static bool operator !=(RationalNumber number1, RationalNumber number2)
        {
            Reduction(number1);
            Reduction(number2);
            return !number1.Equals(number2);
        }
        public static int NOD(int number1, int number2)
        {
            while ((number1 != 0) && (number2 != 0))
            {
                if (number1 > number2)
                    number1 -= number2;
                else
                    number2 -= number1;
            }
            return Math.Max(number1, number2);
        }
        public static RationalNumber Reduction(RationalNumber number)
        {
            int nod = NOD(number.Numerator, number.Denominator);
            if (nod != 0)
            {
                number.Numerator /= nod;
                number.Denominator /= nod;
                return new RationalNumber
                {
                    Numerator = number.Numerator,
                    Denominator = number.Denominator
                };
            }
            else
            {
                return new RationalNumber
                {
                    Numerator = number.Numerator,
                    Denominator = number.Denominator
                };
            }
        }
        public static implicit operator int(RationalNumber number)
        {
            return Convert.ToInt32(number.Numerator / number.Denominator);
        }
        public static explicit operator string(RationalNumber number)
        {
            return number.ToString();
        }
        public static explicit operator double(RationalNumber number)
        {
            return number.Numerator / number.Denominator;
        }
        public static explicit operator RationalNumber(string number)
        {
            return Parse(number);
        }
        public static RationalNumber Parse(string number) 
        {
            if (number.IndexOf('/') != -1)
            {
                string[] str = number.Split('/');
                return new RationalNumber(int.Parse(str[0]),
                       int.Parse(str[1]));
            }
            else
            {
                double thisIn = Convert.ToDouble(number);
                int dop;
                int thisOut; 
                thisIn = Convert.ToDouble(number);
                thisOut = Convert.ToInt32(Math.Floor(thisIn));
                dop = Convert.ToInt32(Math.Round((thisIn - thisOut), 3) * 1000);
                return new RationalNumber((thisOut * 1000) + dop, 1000);
            }
        }
        public override string ToString()
        {
            return (Numerator.ToString() + "/" + Denominator.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return false;
            }
            RationalNumber rationalNumber = (RationalNumber)obj;
            int cheсk = CompareTo(rationalNumber);
            if (cheсk == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CompareTo(RationalNumber number)
        {
            if (number > this)
            {
                return 1;
            }
            else if (number < this)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
