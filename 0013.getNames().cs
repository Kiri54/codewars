/*https://www.codewars.com/kata/514a677421607afc99000002

The following code is not giving the expected results. Can you figure out what the issue is?
The following is an example of data that would be passed in to the function.

public class Person
{
  public int Age;
  public string Name;

  public Person(string name = "John", int age = 21)
  {
    Age = age;
    Name = name;
  }
}

Person[] data = new Person[]
{
  new Person("Joe", 20),
  new Person("Bill", 30),
  new Person("Kate", 23)
};

Kata.GetNames(data) => new string[] {"Joe", "Bill", "Kate"};*/

using System;

public class Kata
{
    public static string[] GetNames(Person[] data)
    {
        string[] s = new string[data.Length];
        for (Int32 i=0;i<data.Length;i++)  
        {
            s[i]=data[i].Name;
        }
        return s;
    }
}