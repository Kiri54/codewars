/*https://www.codewars.com/kata/5b2b4836b6989d207700005b

Fix a bug in provided method which should execute a passed action n (possibly hundreds) times.
The method is timing out and not completing in time.*/

using System;
using System.Threading.Tasks;

public class Worker 
{
    public void Execute(Action a, int nTimes) 
    {
        Parallel.For(0, nTimes, x=> a());
    }
}