using System.Security.Cryptography.X509Certificates;

public class Post
{
    public string Text;
    public int Likes;
    public List<string> Commets = new List<string>() { "Super", "Great" };

    public void SetPost(string text)
    {
        Text = text;
    }
    public void AddLike()
    {
        int sum = Likes + 1;
        System.Console.WriteLine(sum);
    }
    public void AddComment(List<string> comment)
    {
        Commets = comment;
    }
    public string GetInfo()
    {
        return $"Text = {Text}\nLikes : {Likes}\n\nComments : ";
    }

    public void GetInfo2()
    {
        foreach (var item in Commets)
        {
            System.Console.WriteLine(item);
        }
    }
}