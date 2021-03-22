class contacto
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Telephone { get; set; }
    public void SetContacto(string name, string lastname, string address , string telephone)
    {
      this.Name =  name;
      this.LastName = lastname;
      this.Address =  address;
      this.Telephone = telephone;
    }
    public void Saludar()
    {
        System.Console.WriteLine($"Hola soy {Name} y mi apellido {this.LastName} y mi telefono es {Telephone} y mi direccion es {Address}");
    }
}