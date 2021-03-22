class Person
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public void ShowPerson()
    {
        System.Console.WriteLine($"Mi cedula es {ID}, mi nombre es {Name} y mi apellido {LastName} y tengo {Age} Años");
    }
    

}