/*https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1

Ask a small girl - "How old are you?". She always says strange things...
Lets help her!

For correct answer program should return int from 0 to 9.

Assume test input string always valid and may look like "1 year old" or "5 years old", etc..
The first char is number only. */

using System;

public class Kata
{
    public static int GetAge(string inputString)
    {
        string s = inputString[0].ToString();
        return Convert.ToInt32(s);
    }
}