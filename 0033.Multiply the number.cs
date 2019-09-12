/*https://www.codewars.com/kata/5708f682c69b48047b000e07

Jack really likes his number five: the trick here is that you have to multiply each number by 5 raised to the number of digits of each numbers, so, for example:

multiply(3)==15
multiply(10)==250
multiply(200)==25000
multiply(0)==0
multiply(-3)==-15*/

using System;

public class Kata
{
    public static int Multiply(int number)
    {
        return number*(int)Math.Pow(5,Digits(number));
    }

    public static byte Digits(int n)
    {
        n = Math.Abs(n);
        if (n < 10) return 1;
        if (n < 100) return 2;
        if (n < 1000) return 3;
        if (n < 10000) return 4;
        if (n < 100000) return 5;
        if (n < 1000000) return 6;
        if (n < 10000000) return 7;
        if (n < 100000000) return 8;
        if (n < 1000000000) return 9;
        return 10;
    }
}