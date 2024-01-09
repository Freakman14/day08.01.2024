public class Author
{
    private string name { get; set; }
    private int age { get; set; }
    private string nationality { get; set; }

    public Author() { }
    public Author(string _name, int _age)
    {
        name = _name;
        age = _age;
    }
    public Author(string _name, int _age, string _nationality)
    {
        name = _name;
        age = _age;
        nationality = _nationality;
    }
    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public string GetNationality()
    {
        return nationality;
    }
    public void Introduce()
    {
        System.Console.WriteLine($"Меня зовут {name}. Мне {age} лет. Я из {nationality}.");
    }
    public void CelebrateBirthday()
    {
        System.Console.WriteLine(age + 1);
    }

}