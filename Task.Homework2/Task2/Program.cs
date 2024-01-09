var us = new User();
us.FirstName = "Abdullo";
us.LastName = "Mirzoev";
us.UserName = "goodman";
us.Password = "123456789";
us.IsLoggedIn = true;
us.Login("BadMan", "000000");

us.Logout();
System.Console.WriteLine(us.GetFullInfo());