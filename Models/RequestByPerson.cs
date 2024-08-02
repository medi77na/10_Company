using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_Company.Models
{
    public class RequestByPerson
    {
        public static string? RequestName()
        {
            return Validation.ValidateString("Digite el nombre: ");
        }

        public static string? RequestLastName()
        {
            return Validation.ValidateString("Digite el apellido: ");
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

    }
}