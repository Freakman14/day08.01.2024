public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsLoggedIn { get; set; }

    public void Login(string username, string password)
    {
        UserName = username;
        Password = password;
        if (username == password)
        {
            System.Console.WriteLine("Пользователь успешно зарегистрирован");
        }
        else
        {
            System.Console.WriteLine("Ваш пароль или имя пользователя неверны");
        }
    }
    public void Logout()
    {
        bool f = false;
        if (IsLoggedIn == true)
        {
            System.Console.WriteLine(f);
        }
    }
    public string GetFullInfo()
    {
        return $"{FirstName} {LastName} - {IsLoggedIn}";
    }
}