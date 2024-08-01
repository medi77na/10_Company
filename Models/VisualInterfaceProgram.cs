using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_Company.Models;
public static class VisualInterfaceProgram
{

    public static void RunProgram()
    {
        RequestByCompany.InitialData();
        MainMenu();
    }

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine(@$"MENÚ DE OPCIONES
----------------------------------------------------------------
1. Agregar empleado
2. Mostrar Empleados
3. Eliminar empleado
4. Editar empleado
5. Salir
----------------------------------------------------------------");
    }

    public static int ChooseOption()
    {
        ShowMenu();
        return Validation.ValidateIntWithRange("Ingrese una opción: ",1,5);
    }

    public static void MainMenu()
    {
        int option;
        do
        {
            option = ChooseOption();
            switch (option)
            {
                case 1:
                    RequestByCompany.RequestAddEmployee();
                    break;
                case 2:
                    RequestByCompany.RequestShowAllEmployees();
                    break;
                case 3:
                    RequestByCompany.RequestDeleteEmployee();
                    break;
                case 4:
                    RequestByCompany.RequestUpdateEmployee();
                    break;
                default:
                    break;
            }
        } while (option != 5);
    }

    public static void EmployeeHeader()
    {
        Console.WriteLine("LISTADO DE EMPLEADOS");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" #  | ID                                   | Nombre Completo           | Cédula          | Fecha de nacimiento  | Cargo                | Salario           |");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
    }

    public static void WaitForKey()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Oprima una tecla para continuar... ");
        Console.WriteLine(" ");
        Console.ReadKey();
    }
}
