package com.sandelarsen.palindrome;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Palindrome {
    public static boolean IsPalindrome(String text) {
        if(text == null)
            return false;
        Character[] characters = RemoveNonAlphaNumeric(text);
        for(int i = characters.length-1; i>0;--i)
            if (characters[i] != characters[characters.length - i - 1])
                return false;
        return true;
    }

    public static Character[] RemoveNonAlphaNumeric(String text) {
        List<Character> allowed = Arrays.asList(
                'a','b','c','d','e','f','g',
                'h','i','j','k','l','m','n',
                'o','p','q','r','s','t','u',
                'v','w','x','y','z','1','2',
                '3','4','5','6','7','8','9',
                '0');
        List<Character> chars = new ArrayList<>();
        for(char c : text.toCharArray()) {
            c = (char) (c | 0x20);
            if (allowed.contains(c))
                chars.add(c);
        }
        return chars.toArray(new Character[chars.size()]);
    }

    public static boolean IsPalindrome(int number) {
        return IsPalindrome(Integer.toString(number));
    }
}
