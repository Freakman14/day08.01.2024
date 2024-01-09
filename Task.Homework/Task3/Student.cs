public class Student
{
    public string Name { get; set; }
    public int GradeLevel { get; set; }
    public List<int> score = new List<int>();

    public double GetAverage()
    {
        int sum = 0;
        int all = 0;
        foreach (var item in score)
        {
            sum += item;
        }
        all = sum / score.Count;
        // return all;

        if (all > 85)
        {
            System.Console.WriteLine($"Congratulations Nurullo Sulaymonov on achieving above average scores ({all}) in grade {GradeLevel}!Keep up the good work!");
        }
        else if (all > 70 && all < 85)
        {
            System.Console.WriteLine($"Abdulloh Abdulloev, if you're having difficulties with your studies, don't hesitate toseek help. Your current average score is {GradeLevel} in grade 10.");
        }
    ;
    }
}