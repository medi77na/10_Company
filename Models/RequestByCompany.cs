using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10_Company.Enums;

namespace _10_Company.Models
{
    public static class RequestByCompany
    {

        public static void InitialData()
        {
            Company.Initialize("David Development", "Calle 123, Los Ángeles, CP 12345");

            Company.AddEmployee(new Employee("luis", "diaz", "100985674", DateOnly.FromDateTime(new DateTime(1995, 06, 15)), Positions.gerente, 3000000));
            Company.AddEmployee(new Employee("ana", "martinez", "100234567", DateOnly.FromDateTime(new DateTime(1988, 04, 23)), Positions.desarrollador, 2000000));
            Company.AddEmployee(new Employee("carlos", "lopez", "100345678", DateOnly.FromDateTime(new DateTime(1990, 12, 05)), Positions.analista, 2500000));
            Company.AddEmployee(new Employee("maria", "gomez", "100456789", DateOnly.FromDateTime(new DateTime(1985, 07, 30)), Positions.contador, 3500000));
            Company.AddEmployee(new Employee("pedro", "perez", "100567890", DateOnly.FromDateTime(new DateTime(1992, 09, 10)), Positions.tester, 2800000));
        }

        public static void RequestAddEmployee()
        {
            Console.Clear();
            Console.WriteLine("AGREGANDO EMPLEADO:");
            Console.WriteLine(" ");
            Company.AddEmployee(RequestByEmployee.RequestDataEmployee());
            Console.Clear();
            Console.WriteLine("Empleado agregado exitosamente...");
            VisualInterfaceProgram.WaitForKey();
        }

        public static void RequestDeleteEmployee()
        {
            var listEmployees = Company.GetAllEmployees();
            Console.Clear();
            Console.WriteLine("ELIMINANDO EMPLEADO:");
            Console.WriteLine(" ");
            var name = RequestByEmployee.RequestName();
            var lastName = RequestByEmployee.RequestLastName();
            var employeeDelete = listEmployees.Where(e => e.Name == name && e.LastName == lastName).FirstOrDefault();

            if (employeeDelete is null)
            {
                Console.Clear();
                Console.WriteLine("No se encontró al empleado...");
                VisualInterfaceProgram.WaitForKey();
            }
            else
            {
                Console.Clear();
                Company.DeleteEmployee(employeeDelete);
                Console.WriteLine("Empleado eliminado exitosamente");
                VisualInterfaceProgram.WaitForKey();
            }
        }

        public static bool RequestShowAllEmployees()
        {
            bool flag;
            var listEmployees = Company.GetAllEmployees();
            Console.Clear();

            if (listEmployees.Count() < 1)
            {
                Console.WriteLine("No hay empleados aún...");
                VisualInterfaceProgram.WaitForKey();
                flag = false;
            }
            else
            {
                VisualInterfaceProgram.EmployeeHeader();
                for (var i = 0; i < listEmployees.Count(); i++)
                {
                    Console.WriteLine($" {i + 1}  {listEmployees[i]}");
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                VisualInterfaceProgram.WaitForKey();
                flag = true;
            }
            return flag;
        }

        public static void RequestUpdateEmployee()
        {
            if (RequestShowAllEmployees())
            {
                var listEmployees = Company.GetAllEmployees();
                int numberUser = Validation.ValidateIntWithRange("Ingrese el # del usuario que desea actualizar: ", 1, Company.GetAllEmployees().Count()) - 1;
                RequestByEmployee.RequestShowProperties();
                int optionUpdate = Validation.ValidateIntWithRange("Digite el # de la propiedad que desea actualizar: ", 1, 6);
                Console.WriteLine(" ");

                switch (optionUpdate)
                {
                    case 1:
                        listEmployees[numberUser].Name = RequestByEmployee.RequestName();
                        break;
                    case 2:
                        listEmployees[numberUser].LastName = RequestByEmployee.RequestLastName();
                        break;
                    case 3:
                        listEmployees[numberUser].IdentityNumber = RequestByEmployee.RequestIdentityNumber();
                        break;
                    case 4:
                        listEmployees[numberUser].BirthDate = RequestByEmployee.RequestBirthDate();
                        break;
                    case 5:
                        listEmployees[numberUser].Position = RequestByEmployee.RequestPosition();
                        break;
                    case 6:
                        listEmployees[numberUser].Salary = RequestByEmployee.RequestSalary();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}