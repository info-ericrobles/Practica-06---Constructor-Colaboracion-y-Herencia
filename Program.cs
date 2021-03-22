using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Eric = new Person();

          Eric.ID = "402-1199587-6";

          Eric.Name = "Eric";

          Eric.LastName = "Robles";

          Eric.Age = 19;

          Eric.ShowPerson();

          Profesor Luis = new Profesor();

          Luis.ID = "402-1199587-6";

          Luis.Name = "Luis";

          Luis.LastName = "Martes";

          Luis.Age = 30;

          Luis.ShowPerson();

          Luis.Salary = 25000;

          Luis.ShowSalary();

          TestContacto.TestContacMain();

          ClassC classC = new ClassC();
        }
    }
}
