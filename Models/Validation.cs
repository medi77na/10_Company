using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_Company.Models;

public class Validation
{
    //VALIDATE
    public static string ValidateString(string text)
    {
        bool bandera = true;
        string? value;
        do
        {
            Console.Write(text);
            value = Console.ReadLine().Trim().ToLower();
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Error: El campo -{text}- no puede estar vacío.");
                VisualInterfaceProgram.WaitForKey();
            }
            else
            {
                bandera = false;
            }
        } while (bandera);
        return value;
    }

    public static double ValidateDouble(string text)
    {
        bool bandera = true;
        double result = 0;
        do
        {
            Console.Write(text);
            string? value = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(value) || !Double.TryParse(value, out result))
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Error: El campo -{text}- no fue digtado correctamente.");
                VisualInterfaceProgram.WaitForKey();
            }
            else
            {
                bandera = false;
            }
        } while (bandera);
        return result;
    }

    public static int ValidateInt(string text)
    {
        bool bandera = true;
        int result = 0;
        do
        {
            Console.Write(text);
            string? value = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(value) || !int.TryParse(value, out result))
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Error: El campo -{text}- no fue digitado correctamente.");
                VisualInterfaceProgram.WaitForKey();
            }
            else
            {
                bandera = false;
            }
        } while (bandera);
        return result;
    }

    public static int ValidateIntWithRange(string text, int min, int max)
    {
        bool flag;
        int number;

        do
        {
            number = ValidateInt(text);
            if (number >= min && number <= max)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("El número ingresado está fuera del rango, digitelo nuevamente...");
                VisualInterfaceProgram.WaitForKey();
                flag = true;
            }
        } while (flag);
        return number;
    }
}
