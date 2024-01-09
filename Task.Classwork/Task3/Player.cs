public class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;

    public void ScoreGoal()
    {
        System.Console.WriteLine($"Name: {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}");
    }
    public void AssistGoal(string playerName)
    {
        Name = playerName;
    }
    public string GetInfo()
    {
        return $"Name: {Name}\nNumber: {Number}\nPositon: {Position}\nTeam: {Team}\n{Name} scores a goal!\n{Name} assists a goal for Neymar.";
    }
}