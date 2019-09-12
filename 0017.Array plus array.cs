/*https://www.codewars.com/kata/5a2be17aee1aaefe2a000151

I'm new to coding and now I want to get the sum of two arrays...
actually the sum of all their elements. I'll appreciate for your help.

P.S. Each array includes only integer numbers. Output is a number too.*/

public static class Kata
{
  public static int ArrayPlusArray(int[] arr1, int[] arr2)
    {
        int s = 0;
        foreach(int i in arr1)
            s+=i;
        foreach(int i in arr2)
            s+=i;
        return s;
    }
}