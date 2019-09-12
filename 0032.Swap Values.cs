/*https://www.codewars.com/kata/5388f0e00b24c5635e000fc6

I would like to be able to pass an array with two elements to my swapValues function to swap the values.
However it appears that the values aren't changing.
Can you figure out what's wrong here?*/

public class Swapper
{
    public object[] Arguments { get; private set; }
    
    public Swapper(object[] args)
    {
        Arguments = args;
    }
    
    public void SwapValues()
    {
        object[] args = new[] { Arguments[0], Arguments[1] };
        
        object temp = args[0];
        args[0] = args[1];
        args[1] = temp;        
        Arguments = args;
    }
}