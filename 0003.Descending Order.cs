/*https://www.codewars.com/kata/5467e4d82edf8bbf40000155

Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order.
Essentially, rearrange the digits to create the highest possible number.*/

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        char[] c = num.ToString().ToCharArray();
        for (int i =0;i<c.Length-1;i++)
        {
            for(int j=0;j<c.Length-1;j++)
            {
                if(c[j]<c[j+1])
                {
                    char t = c[j];
                    c[j]=c[j+1];
                    c[j+1]=t;
                }
            }
        }
        string cc = new string(c);
        return Convert.ToInt32(cc);
    } 
}