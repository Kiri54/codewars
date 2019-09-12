/*https://www.codewars.com/kata/55c606e6babfc5b2c500007c

Failed Filter - Bug Fixing #3
Oh no, Timmy's filter doesn't seem to be working?
Your task is to fix the FilterNumber function to remove all the numbers from the string.*/

using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static string FilterNumbers(string str)
    {
        return Regex.Replace(str, @"\d", "");
    }
}