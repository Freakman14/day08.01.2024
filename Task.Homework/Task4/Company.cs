public class Company
{
    public string CompanyName { get; set; }
    public string Location { get; set; }
    public string CEO { get; set; }
    public int NumberOfEmployees { get; set; }
    public float Revenue { get; set; }
    public List<Employee> employees = new List<Employee>() { };

    public void HireEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    public void FireEmployee(Employee employee)
    {
        employees.Remove(employee);
    }
    public string GenerateAnnualReport()
    {
        return $"Company Name: {CompanyName}\nLocation: {Location}\nCEO: {CEO}\nNumber of Employees: {NumberOfEmployees}\nRevenue: {Revenue}";

    }

}