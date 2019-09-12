/*https://www.codewars.com/kata/55a5bfaa756cfede78000026

 Make a function that returns the value multiplied by 50 and increased by 6.
 If the value entered is a string it should return "Error".
Note: in C#, you'll always get the input as a string,
so the above applies if the string isn't representing a double value.*/

using System;

public class Kata
{
    public static string Problem(String a)
    {
        try
        {
            int i = Convert.ToInt32(a);
            i=i*50+6;
            return i.ToString();
        }
        catch
        {
            try
            {
                double d = Convert.ToDouble(a);
                d=d*50+6;
                return d.ToString();
            }
            catch
            {
                return "Error";
            }
        }
    }
}