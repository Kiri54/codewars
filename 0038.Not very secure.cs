/*https://www.codewars.com/kata/526dbd6c8c0eb53254000110

In this example you have to validate if a user input string is alphanumeric. The given string is not nil, so you don't have to check that.

The string has the following conditions to be alphanumeric:

At least one character ("" is not valid)
Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
No whitespaces/underscore*/

using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool Alphanumeric(string str)
    {
        var match = Regex.Match(str, @"^[a-z0-9]+$", RegexOptions.IgnoreCase);
        if (match.Success)
            return true;
        return false;
    }
}