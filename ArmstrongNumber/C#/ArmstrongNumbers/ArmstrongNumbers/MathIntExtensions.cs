using System;

namespace Utilities
{
    public static class MathIntExtensions
    {
        public static bool IsArmstrong(this int number)
        {
            int n = number, sum = 0, digits = number.CountDigits();
            switch (digits)
            {
                case 1:
                    return true;
                case 2:
                    return false;
            }
            while (n > 0)
            {
                var r = n%10;
                sum += r.Power(digits);
                if (sum > number)
                    return false;
                n = n.DivBy10();
            }
            return sum == number;
        }

        //this is the most nerdy way I've found to divide by ten, unless you compile with optimizations, (which will do this for you) this is pretty fast!
        public static int DivBy10(this int n)
        {
            return n/10;
        }

        public static int CountDigits(this int number)
        {
            number = Math.Abs(number);
            if (number < 10)
                return 1;
            return (number/10).CountDigits() + 1;
        }

        public static int Power(this int number, int power)
        {
            return number.Raise(power);
        }
        public static int Raise(this int number, int power)
        {
            if (number == 0 && power == 0) return 1;

            if (power == 0) return 0;

            if (power > 1) return number*number.Raise(power - 1);

            if (power == 1) return number;

            return 1;
        }
    }
}