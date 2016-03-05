using System;

namespace ArmstrongNumber
{
    public static class ArmstrongIntExtensions
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
                n /= 10;
            }
            return sum == number;
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