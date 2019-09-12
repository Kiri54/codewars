/*https://www.codewars.com/kata/566dc566f6ea9a14b500007b

The method is supposed to remove even numbers from the list and return a list that contains odd number.
However, there is a bug in the method that needs to be resolved.*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i]%2 == 0)
            {
                listOfNumbers.RemoveAt(i);
                i--;
            }
        }
        return listOfNumbers;
    }
}