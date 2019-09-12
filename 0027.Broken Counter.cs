/*https://www.codewars.com/kata/526471539d52735c620000c6

Our counter prototype is broken. Can you spot, what's wrong here?
Counter.Value must have manually defined getter/setter methods,
according to our company's style guide.*/

using System;

public class Counter
{
    int _value;
    public int Value
    {
        get
        {
            return _value;
        }
        private set
        {
        _value = value;
        }
    }
  
    public Counter()
    {
        Value = 0;
    }
  
    public void Increase()
    {
        ++Value;
    }
  
    public void Reset()
    {
        Value = 0;
    }
}