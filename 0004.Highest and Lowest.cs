/*https://www.codewars.com/kata/554b4ac871d6813a03000035

In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

Notes:

All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.*/

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        string[] s = numbers.Split(' ');
        int[] n = new int[s.Length];
        for (Int32 i=0;i<n.Length;i++)
        {
            n[i] = Convert.ToInt32(s[i]);
        }
        Int32 max = n[0];
        Int32 min = n[0];
        for (Int32 i=0;i<n.Length;i++)
        {
            if(max<n[i]) max=n[i];                               
            if(min>n[i]) min=n[i];                
        }
        return max.ToString() + " " + min.ToString();
    }
}