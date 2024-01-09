public class Country
{
    private string name { get; set; }
    private string capital { get; set; }
    private int population { get; set; }
    private string officialLanguage { get; set; }

    public Country(string _name, string _capital, int _population, string _officialLanguage)
    {
        name = _name;
        capital = _capital;
        population = _population;
        officialLanguage = _officialLanguage;
        System.Console.WriteLine($"Country Name: {name}");
    }
    public void SetCapital(string capital)
    {
        this.capital = capital;
    }
    public string GetCapital()
    {
        return capital;
    }
    public void SetPopulation(int population)
    {
        this.population = population;
    }
    public int GetPopulation()
    {
        return population;
    }
    public void SetOfficialLanguage(string language)
    {
        officialLanguage = language;
    }
    public string GetOfficialLanguage()
    {
        return officialLanguage;
    }
}