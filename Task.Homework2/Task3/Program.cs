var a1 = new Author("John", 15, "Russian");
System.Console.WriteLine($"Name: {a1.GetName()}");
System.Console.WriteLine($"Age: {a1.GetAge()}");
System.Console.WriteLine($"Nationality: {a1.GetNationality()}");
System.Console.WriteLine();
a1.Introduce();
a1.CelebrateBirthday();