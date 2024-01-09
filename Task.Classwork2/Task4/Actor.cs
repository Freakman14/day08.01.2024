public class Actor
{
    private string fullName { get; set; } = " Robert Downey Jr.";
    private int age = 56;
    private string gender = "Male";
    private List<Actor> moviesPlayed = new List<Actor>() ;

    public Actor() { }
    public Actor(string _fullName, int _age, string _gender)
    {
        fullName = _fullName;
        age = _age;
        gender = _gender;
    }
    public void AddMovie(Actor actor)
    {
        moviesPlayed.Add(actor);
    }
    public List<Actor> GetMoviesPlayed()
    {
        return moviesPlayed;
    }
    public void SetAge(int _age)
    {
        age = _age;
    }
    public int GetAge()
    {
        return age;
    }
    public void SetGender(string _gender)
    {
        gender = _gender;
    }
    public string GetGender()
    {
        return gender;
    }
}