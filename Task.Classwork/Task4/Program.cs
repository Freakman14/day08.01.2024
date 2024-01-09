var e1 = new Employee();
e1.FirstName = "John";
e1.LastName = "Doe";
e1.Age = 30;
e1.Position = "Manager";
e1.Salary = 500000;

System.Console.WriteLine(e1.GetInfo());
System.Console.WriteLine("-----------------------");

var em1=new Employee();
em1.FirstName = "John";
em1.LastName = "Doe";
em1.Age = 30;
em1.Position = "Manager";
em1.Salary = 555000;
System.Console.WriteLine(em1.GetInfo());