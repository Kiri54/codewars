/*https://www.codewars.com/kata/563cf89eb4747c5fb100001b

The museum of incredible dull things
The museum of incredible dull things wants to get rid of some exhibitions.
Miriam, the interior architect, comes up with a plan to remove the most boring exhibitions.
She gives them a rating, and then removes the one with the lowest rating.

However, just as she finished rating all exhibitions, she's off to an important fair,
so she asks you to write a program that tells her the ratings of the items after one removed the lowest one.
Fair enough.

Task
Given an array of integers, remove the smallest value. Do not mutate the original array/list.
If there are multiple elements with the same value, remove the one with a lower index.
If you get an empty array/list, return an empty array/list.

Don't change the order of the elements that are left. */

using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Count==0)
        {
            return new List<int>();
        }
        int min = numbers[0];
        int index=0;
        for(int i=0;i<numbers.Count;i++)
        {
            if(min>numbers[i])
            {
                min=numbers[i];
                index=i;
            }
        }
        int t = 0;
        List<int> copies = new List<int>();
        for(int i=0;i<numbers.Count;i++)
        {
            t = numbers[i];
            if(i!=index) copies.Add(t);
        }
        return copies;
    }
}