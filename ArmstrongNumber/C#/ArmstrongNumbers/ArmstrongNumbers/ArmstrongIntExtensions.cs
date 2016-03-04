namespace ArmstrongNumber
{
    public static class ArmstrongIntExtensions
    {
        public static bool IsArmstrong(this int number)
        {
            int n = number, sum = 0;

            while(number > sum)
            {
                var r = n % 10;
                sum += r * r * r;
                n /= 10;
            }
            return sum == number;
        }
    }
}
