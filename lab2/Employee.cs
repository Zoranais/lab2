namespace lab2;

class Employee
{
    public string Name { get; set; }
    public double MinimalWage { get; set; }

    public Employee(string name, double minWage)
    {
        Name = name;
        MinimalWage = minWage;
    }

    public virtual double CalculateWage(double k)
    {
        return MinimalWage * k;
    }
}
