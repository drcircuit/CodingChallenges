package Utilities;

/**
 * Created by Espen on 3/5/2016.
 */
public class Int {
    public static boolean IsArmstrong(int number){
        int digits = getDigits(number), sum = 0;

        if(digits == 1)
            return true;
        if(digits == 2)
            return false;

        int n = number;

        while (n > 0 && sum < number){
            int r = n % 10;
            sum += Math.pow(r, digits);
            n /= 10;
        }
        return sum == number;
    }

    private static int getDigits(int number) {
        number = Math.abs(number);
        if(number < 10)
            return 1;
        return getDigits((number / 10)) + 1;

    }
}
