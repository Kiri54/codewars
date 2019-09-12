/*https://www.codewars.com/kata/550498447451fbbd7600041c

Given two arrays a and b write a function comp(a, b) (compSame(a, b) in Clojure)
that checks whether the two arrays have the "same" elements, with the same multiplicities.
"Same" means, here, that the elements in b are the elements in a squared, regardless of the order.*/

using System;
using System.Collections.Generic;

class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a==null||b==null||a.Length!=b.Length) return false;
        List<int> L = new List<int>();            
        for (int i =0; i<a.Length;i++)
        {
            for (int j = 0;j<b.Length;)
            {
                if (!L.Contains(j)&&b[i]==a[j]*a[j])
                {
                    L.Add(j);
                    break;
                }
                j++;
                if(j==b.Length) return false;
            }
        }
        return true;
    }
}