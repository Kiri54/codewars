/*https://www.codewars.com/kata/5804acd4e053562b5f00004d

2-Sum is a common task to find the pair of integers in the array such that their sum equals to the target.

Array = [1,2,3,4,5]

target - 7

Pair is [2, 5]

#Task

There is an array of unique integers.

The task is to find a sum of all targets in the specific range [from, to),
which has a pair in the array, such that sum of the pair equals to the target.

#Example

Array = [2, 4, 6, 10] target range is [6, 10)

target = 6 - there is a pair (2, 4)

target = 7 - there is no pair

target = 8 - there is a pair (2, 6)

target = 9 - there is no pair

So the Result is 14 = 6 + 8*/


using System;
using System.Collections.Generic;
using System.Linq;
  
public class TwoSum
{
    public int SumOfTwoSumTargets (int[] numbers, int from, int to) 
    {
        HashSet<int> hs = new HashSet<int>();
        for(int i =0;i<numbers.Length-1;i++)
        {
            for(int j = i+1;j<numbers.Length;j++)
            {
                int sum = numbers[i]+numbers[j];
                if (sum>=from&sum<to)                
                    hs.Add(sum);                
            }
        }
        return hs.Sum();
    }
}