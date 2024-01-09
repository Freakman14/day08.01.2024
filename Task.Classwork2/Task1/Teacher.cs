public class Teacher
{
    private string fullName { get; set; }
    private string subject { get; set; }
    private int experiance { get; set; }

    public Teacher() { }

    public Teacher(string name, string _subject)
    {
        fullName = name;
        subject = _subject;
    }
    public Teacher(string name, string _subject, int _experiance)
    {
        fullName = name;
        subject = _subject;
        experiance = _experiance;
    }
    public string Teach()
    {
        return $"{fullName} teaching {subject}.";
    }
    public void SetExperiance(int years)
    {
        experiance = years;
    }
    public int GetExperiance()
    {
        return experiance;
    }
}