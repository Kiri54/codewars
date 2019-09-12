/*https://www.codewars.com/kata/55c423ecf847fbcba100002b

Oh no, Timmy's received some hate mail recently but he knows better.
Help Timmy fix his regex filter so he can be awesome again! */

using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static string filterWords(string phrase)
    {
        string pattern = @"(?i)bad|mean|ugly|horrible|hideous\b";
        string replacement = "awesome";
        Regex rgx = new Regex(pattern);
        return rgx.Replace(phrase, replacement);
    }
}