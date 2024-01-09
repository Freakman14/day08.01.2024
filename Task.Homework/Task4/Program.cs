var c1 = new Company();
c1.CompanyName = "ABC Corporation";
c1.Location = "Cityville";
c1.CEO = "John Smith";
c1.NumberOfEmployees = 150;
c1.Revenue = 5000000;


var c2 = new Company();
c2.CompanyName = "ABC Corporation";
c2.Location = "Cityville";
c2.CEO = "John Smith";
c2.NumberOfEmployees = 150;
c2.Revenue = 5000000;

System.Console.WriteLine(c1.GenerateAnnualReport());
System.Console.WriteLine("----------------------------");
System.Console.WriteLine(c2.GenerateAnnualReport());

// foreach (var item in Employee.e)
// {

// }