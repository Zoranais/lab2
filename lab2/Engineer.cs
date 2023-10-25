namespace lab2;

class Engineer : Employee
{
    public int ProjectCount { get; set; }
    public Engineer(string name, double minWage, int projects) : base(name, minWage)
    {
        ProjectCount = projects;
    }

    public override double CalculateWage(double k)
    {
        return base.CalculateWage(k) * (ProjectCount / 10d);
    }
}
