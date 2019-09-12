/*https://www.codewars.com/kata/597c684822bc9388f600010f

The code provided is supposed return a person's Full Name given their first and last names.
But it's not working properly.
Notes
The first and/or last names are never null (None in Python), but may be empty.
Task
Fix the bug so we can all go home early.*/

public class Dinglemouse
{
    private string firstName;
    private string lastName;
    public string FullName
    {
        get
        {
        if(string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            return string.Empty;
        if(string.IsNullOrEmpty(firstName))        
            return lastName;        
        else if(string.IsNullOrEmpty(lastName))        
            return firstName;
        else
            return firstName+" "+lastName;
        }
    }
  
    public Dinglemouse(string FirstName, string LastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }
}