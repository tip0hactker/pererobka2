using System;

class Address
{
    private string _index;
    private string _country;
    private string _city;
    private string _street;
    private string _house;
    private string _apartment;

    public string Index
    {
        get { return _index; }
        set { _index = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string House
    {
        get { return _house; }
        set { _house = value; }
    }

    public string Apartment
    {
        get { return _apartment; }
        set { _apartment = value; }
    }
}

class Program
{
    static void Main()
    {
       
        Address addressInstance = new Address();

        addressInstance.Index = "12345";
        addressInstance.Country = "Ukraine";
        addressInstance.City = "Kyiv";
        addressInstance.Street = "Main Street";
        addressInstance.House = "42";
        addressInstance.Apartment = "10";

   
        Console.WriteLine("Address Information:");
        Console.WriteLine($"Index: {addressInstance.Index}");
        Console.WriteLine($"Country: {addressInstance.Country}");
        Console.WriteLine($"City: {addressInstance.City}");
        Console.WriteLine($"Street: {addressInstance.Street}");
        Console.WriteLine($"House: {addressInstance.House}");
        Console.WriteLine($"Apartment: {addressInstance.Apartment}");
    }
}
using System;

class Converter
{
    private double _usdRate;
    private double _eurRate;
    private double _plnRate;

    public Converter(double usd, double eur, double pln)
    {
        _usdRate = usd;
        _eurRate = eur;
        _plnRate = pln;
    }

    public double ConvertToUsd(double amountInUah)
    {
        return amountInUah / _usdRate;
    }

    public double ConvertToEur(double amountInUah)
    {
        return amountInUah / _eurRate;
    }

    public double ConvertToPln(double amountInUah)
    {
        return amountInUah / _plnRate;
    }

    public double ConvertFromUsd(double amountInUsd)
    {
        return amountInUsd * _usdRate;
    }

    public double ConvertFromEur(double amountInEur)
    {
        return amountInEur * _eurRate;
    }

    public double ConvertFromPln(double amountInPln)
    {
        return amountInPln * _plnRate;
    }
}

class Program
{
    static void Main()
    {
      
        Converter converter = new Converter(27.5, 32.1, 7.8);

        
        double amountInUah = 1000;
        Console.WriteLine($"{amountInUah} UAH is approximately {converter.ConvertToUsd(amountInUah):0.00} USD");
        Console.WriteLine($"{amountInUah} UAH is approximately {converter.ConvertToEur(amountInUah):0.00} EUR");
        Console.WriteLine($"{amountInUah} UAH is approximately {converter.ConvertToPln(amountInUah):0.00} PLN");

        
        double amountInUsd = 50;
        Console.WriteLine($"{amountInUsd} USD is approximately {converter.ConvertFromUsd(amountInUsd):0.00} UAH");

        double amountInEur = 40;
        Console.WriteLine($"{amountInEur} EUR is approximately {converter.ConvertFromEur(amountInEur):0.00} UAH");

        double amountInPln = 120;
        Console.WriteLine($"{amountInPln} PLN is approximately {converter.ConvertFromPln(amountInPln):0.00} UAH");
    }
}
 using System;

class Employee
{
    private string _lastName;
    private string _firstName;

    public Employee(string lastName, string firstName)
    {
        _lastName = lastName;
        _firstName = firstName;
    }

    public void DisplayInfo(string position, int experience)
    {
        double baseSalary = CalculateBaseSalary(position, experience);
        double tax = CalculateTax(baseSalary);

        Console.WriteLine($"Employee Information:");
        Console.WriteLine($"Last Name: {_lastName}");
        Console.WriteLine($"First Name: {_firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Base Salary: {baseSalary:C2}");
        Console.WriteLine($"Tax: {tax:C2}");
        Console.WriteLine($"Net Salary: {(baseSalary - tax):C2}");
    }

    private double CalculateBaseSalary(string position, int experience)
    {

        double baseSalary = 0;

        if (position.ToLower() == "manager")
        {
            baseSalary = 5000 + 200 * experience;
        }
  

        return baseSalary;
    }

    private double CalculateTax(double baseSalary)
    {
        
        double taxRate = 0.15;
        return baseSalary * taxRate;
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Smith", "John");

       
        employee.DisplayInfo("Manager", 5);
    }
}
