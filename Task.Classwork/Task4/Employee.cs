public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }

    public void SetSalary(float salary)
    {
        Salary = (decimal)salary;
    }

    public float GetSalary()
    {
        return (float)Salary;
    }
    public string GetInfo()
    {
        return $"FirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}\nPosition: {Position}\nSalary: {Salary}";
    }

}