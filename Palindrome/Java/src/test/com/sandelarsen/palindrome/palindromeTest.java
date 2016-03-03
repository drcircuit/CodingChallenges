package com.sandelarsen.palindrome;

import org.junit.Test;

import static com.sandelarsen.palindrome.Palindrome.IsPalindrome;
import static org.junit.Assert.*;

public class palindromeTest {
    @Test
    public void noArgumentReturnsFalse() throws Exception {
        assertFalse(IsPalindrome(null));
    }

    @Test
    public void emptyStringReturnsTrue() throws Exception {
        assertTrue(IsPalindrome(""));
    }

    @Test
    public void singleCharacterReturnsTrue() throws Exception {
        assertTrue(IsPalindrome("a"));
    }

    @Test
    public void whitespaceReturnsTrue() throws Exception {
        assertTrue(IsPalindrome(" "));
        assertTrue(IsPalindrome("  "));
        assertTrue(IsPalindrome("  \n"));
    }

    @Test
    public void singleCharacterWithWhitespaceReturnsTrue() throws Exception {
        assertTrue(IsPalindrome(" a "));
    }

    @Test
    public void doubleCharacterNonPalindromeReturnsFalse() throws Exception {
        assertEquals(false,IsPalindrome("an"));
    }

    @Test
    public void doubleCharacterPalindromeReturnsTrue() throws Exception {
        assertTrue(IsPalindrome("aa"));
    }

    @Test
    public void singleWordNonPalindromeReturnsFalse() throws Exception {
        assertFalse(IsPalindrome("nas"));
        assertFalse(IsPalindrome("nasn"));
    }

    @Test
    public void singleWordPalindromeReturnsTrue() throws Exception {
        assertTrue(IsPalindrome("racecar"));
    }

    @Test
    public void doubleWordPalindromeReturnsTrue() throws Exception {
        assertTrue(IsPalindrome("roses sesor"));
    }

    @Test
    public void singleWordPalindromeWithPunctuactionReturnsTrue() throws Exception {
        assertTrue(IsPalindrome("racecar."));
        assertTrue(IsPalindrome("racecar//"));
        assertTrue(IsPalindrome("racecar?><>`!@#$/"));
    }

    @Test
    public void mixedCasePalindromeReturnsTrue() throws Exception {
        assertTrue(IsPalindrome("RoTOr"));
    }

    @Test
    public void multiLinePalindromeWithPunctuationAndMixedCaseReturnsTrue() throws Exception {
       assertTrue(IsPalindrome("no 'X' \n in Nixon"));
    }

    @Test
    public void numericNonPalindromeReturnsFalse() throws Exception {
        assertFalse(IsPalindrome(1234));
    }

    @Test
    public void numericPalidromeReturnsTrue() throws Exception {
        assertTrue(IsPalindrome(12321));
    }

    @Test
    public void alphaNumericNonPalindromeReturnsFalse() throws Exception {
        assertFalse(IsPalindrome("Roses 43 sesoR"));
    }

    @Test
    public void alphaNumericPalindromeReturnsTrue() throws Exception {
        assertTrue(IsPalindrome("RoSeS 55 SeSor"));
    }
}
