using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_Company.Models
{
    public class RequestByEmployee
    {
        public static string? RequestName()
        {
            return Validation.ValidateString("Digite el nombre: ");
        }

        public static string? RequestLastName()
        {
            return Validation.ValidateString("Digite el apellido: ");
        }

        public static string? RequestIdentityNumber()
        {
            return Validation.ValidateString("Digite el número de identidad: ");
        }

        private static int RequestBirthYear()
        {
            return Validation.ValidateInt("Digite el año de nacimiento: ");
        }

        private static int RequestBirthMonth()
        {
            return Validation.ValidateInt("Digite el número del mes de nacimiento: ");
        }

        private static int RequestBirthDay()
        {
            return Validation.ValidateInt("Digite el número del día de nacimiento: ");
        }

        public static DateOnly RequestBirthDate()
        {
            return DateOnly.FromDateTime(new DateTime(RequestBirthYear(), RequestBirthMonth(), RequestBirthDay()));
        }

        public static string? RequestPosition()
        {
            return Validation.ValidateString("Digite el cargo: ");
        }

        public static double RequestSalary()
        {
            return Validation.ValidateDouble("Digite el salario: ");
        }

        public static Employee RequestDataEmployee()
        {
            return new Employee(RequestName(), RequestLastName(), RequestIdentityNumber(), RequestBirthDate(), RequestPosition(), RequestSalary());
        }

        public static void RequestShowProperties()
        {
            Console.WriteLine(" ");
            Console.WriteLine(@$"Lista de propiedades
----------------------------------------------------------------
1. Nombre
2. Apellido
3. Número de documento
4. Fecha de nacimiento
5. Cargo
6. Salario
----------------------------------------------------------------");
        }
    }
}