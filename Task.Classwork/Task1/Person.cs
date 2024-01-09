public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;

    public string GetInfo()
    {
        return $"FirsName: {FirstName}\nLastName: {LastName}\nAge: {Age}";
    }
}