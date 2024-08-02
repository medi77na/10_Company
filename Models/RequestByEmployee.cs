using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10_Company.Enums;

namespace _10_Company.Models
{
    public class RequestByEmployee
    {        
        public static string? RequestIdentityNumber()
        {
            return Validation.ValidateString("Digite el número de identidad: ");
        }

        public static Positions RequestPosition()
        {
            RequestShowPositions();
            int indexPosition = Validation.ValidateIntWithRange("Digite el número del cargo: ",1,Enum.GetValues(typeof(Positions)).Length)-1;
            return (Positions)indexPosition;
        }

        public static double RequestSalary()
        {
            return Validation.ValidateDouble("Digite el salario: ");
        }

        public static Employee RequestDataEmployee()
        {
            return new Employee(RequestByPerson.RequestName(), RequestByPerson.RequestLastName(), RequestIdentityNumber(), RequestByPerson.RequestBirthDate(), RequestPosition(), RequestSalary());
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

        public static void RequestShowPositions()
        {
            Console.WriteLine(" ");
            Console.WriteLine("CARGOS EN LA EMPRESA: ");
            Console.WriteLine(" ");
            foreach (Positions position in Enum.GetValues(typeof(Positions)))
            {
                Console.WriteLine($"{((int)position)+1}. {position}");
            }
            Console.WriteLine(" ");
        }
    }
}