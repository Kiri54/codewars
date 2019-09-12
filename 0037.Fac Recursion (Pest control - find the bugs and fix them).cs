/*https://www.codewars.com/kata/57fa92b25c9910e7bc0001df

The code is a recursive attempt in calculating the result of a factorial function.
I.e. the result of 3! (Factorial of 3) is 3x2x1 = 6.
In case of 0! the result is 1 and in case of a negative factorial the result should be 0.

The goal is to find the bugs in the sourcecode and fix them (play a little pest control).*/


using System;
public class Fac
{
    public int FacCalculation(int startValue)
    {
        if (startValue==0)
            return 1;
        if (startValue<0)
            return 0;
        int answer = 1;
        while(startValue>0)
        {
            answer*=startValue;
            startValue--;
        }
        return answer;
    }
}