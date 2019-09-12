/*https://www.codewars.com/kata/5412509bd436bd33920011bc

Usually when you buy something, you're asked whether your credit card number,
phone number or answer to your most secret question is still correct. 
However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.
Your task is to write a function maskify, which changes all but the last four characters into '#'.*/

public static class Kata
{
    public static string Maskify(string cc)
    {
        char[] c = cc.ToCharArray();
        for (int i=0;i<c.Length;i++)
        {
            if (i<c.Length-4)
            {
                c[i]='#';
            }
        }
        cc = new string(c);
        return cc;
    }
}