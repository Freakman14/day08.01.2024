public class Student
{
    private string fullName { get; set; }
    private int age { get; set; }
    private int grade { get; set; }

    public Student() { }

    public Student(string name, int _age)
    {
        fullName = name;
        age = _age;
    }
    public Student(string name, int _age, int _grade)
    {
        fullName = name;
        age = _age;
        grade = _grade;
    }
    public void Study()
    {
        System.Console.WriteLine($"{fullName} is studying.");
    }
    public void SetGrade(int newGrade)
    {
        grade = newGrade;
    }
    public int GetGrade()
    {
        return grade;
    }
}