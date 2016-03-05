import org.hamcrest.core.Is;
import org.junit.Assert;
import org.junit.Test;

import static Utilities.Int.*;
import static org.junit.Assert.*;

/**
 * Created by Espen on 3/5/2016.
 */
public class ArmstrongTests {
    @Test
    public void testAllSingleDigitNumbersAreArmstrong() throws Exception {
        for(int n = 0;n < 10; n++){
            assertTrue(IsArmstrong(n));
        }
    }

    @Test
    public void testNoTwoDigitNumbersAreArmstrong() throws Exception {
        for(int n = 10;n<100;n++){
            assertFalse(IsArmstrong(n));
        }
    }

    @Test
    public void testThreeDigitNonArmstrongAreNotArmstrong() throws Exception {
        assertFalse(IsArmstrong(100));
        assertFalse(IsArmstrong(300));
    }

    @Test
    public void testThreeDigitArmstrongAreArmstrong() throws Exception {
        assertTrue(IsArmstrong(153));
        assertTrue(IsArmstrong(370));
        assertTrue(IsArmstrong(371));
        assertTrue(IsArmstrong(407));
    }

    @Test
    public void testFourDigitArmstrongAreArmstrong() throws Exception {
        assertTrue(IsArmstrong(1634));
        assertTrue(IsArmstrong(8208));
        assertTrue(IsArmstrong(9474));
    }

    @Test
    public void testBigArmstrongAreArmstrong() throws Exception {
        assertTrue(IsArmstrong(92727));
        assertTrue(IsArmstrong(24678051));
        assertTrue(IsArmstrong(146511208));

    }
}
