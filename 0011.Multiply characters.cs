/*https://www.codewars.com/kata/52e9aa89b5acdd26d3000127

Here we have a function that help us spam our hearty laughter.
But is not working! I need you to find out why...
Expected results:

Kata.Spam(1)  => "hue";
Kata.Spam(6)  => "huehuehuehuehuehue";
Kata.Spam(14) => "huehuehuehuehuehuehuehuehuehuehuehuehuehue";*/

using System.Text;

public class Kata
{
    public static string Spam(int n)
    {
        const string SpamValue = "hue";   
        return new StringBuilder().Insert(0, SpamValue, n).ToString();
    }
}