class Profesor:Person
{
    public double Salary { get; set; }

    public void ShowSalary()
    {
        System.Console.WriteLine($"My Sueldo es {Salary}");
    }
    //private double salary;

    /* public double Salary{
        get{
            return salary;
        }
        set{
            salary = value;
        }
    } */

}