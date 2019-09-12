/*https://www.codewars.com/kata/5996eb39cdc8eb39f80000a0

Since there are lots of katas requiring you to round numbers to 2 decimal places,
you decided to extract the method to ease out the process.
And you can't even get this right!
Quick, fix the bug before everyone in CodeWars notices that you can't even round a number correctly!*/

using System;
public static class RoundAndRound
{
    public static decimal RoundBy2DecimalPlaces(this decimal number)
    {
        return Math.Round(number, 2, MidpointRounding.AwayFromZero);
    }
}
