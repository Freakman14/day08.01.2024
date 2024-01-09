var per = new Person() { };
System.Console.Write("Enter your FirstName : ");
per.FirstName = Console.ReadLine();
System.Console.Write("Enter your LastName : ");
per.LastName = Console.ReadLine();
System.Console.Write("Enter your Age : ");
per.Age = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine(per.GetInfo());