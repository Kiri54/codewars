/*https://www.codewars.com/kata/5790cdc21ace7fe1bf000c92

The goal of this Kata is to write a function that will return the nth row (1-indexed) of Pascal's Triangle as an array of integers.
If the input to the function is less than 1, greater than 10, or invalid in any way, return an empty array.
Without getting into mathmatics, Pascal's Triangle can be represented in a tree structure with the following attributes:
The first and last item in each row is equals to 1
Each other item is equal to the sum of its parents*/

using System;
using System.Linq;


public class PascalsTriangle
{
    public static int[] GetRow(int rowNumber)
    {
        if(rowNumber < 1 || rowNumber > 10)
            return new int[]{};
        else if(rowNumber == 1)
            return new int[]{1};
        else if(rowNumber == 2)
            return new int[]{1,1};  
        var myarr = new int[3];
        var previous = new int[]{1,1};
        for(int i = 1; i < rowNumber; i++)
        {
            myarr = new int[previous.Length + 1];
            myarr[0] = 1;
            for(int y = 1; y < previous.Length; y++)
                myarr[y] = previous[y-1]+previous[y];        
            myarr[myarr.Length - 1] = 1;
            if(myarr.Length == rowNumber)
                return myarr;
            previous = myarr;
        }
        return myarr;
    }
}