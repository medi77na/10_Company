using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_Company.Models
{
    public static class Company
    {
        public static string? Name;
        public static string? Adress;
        private static List<Employee> ListEmployees;
        private static List<Client> ListClients;

        public static void Initialize(string name, string address)
        {
            Name = name;
            Adress = address;
            ListEmployees = new List<Employee>();
            ListClients = new List<Client>();
        }

        public static void AddEmployee(Employee employee)
        {
            ListEmployees.Add(employee);
        }

        public static void DeleteEmployee(Employee employee)
        {
            ListEmployees.Remove(employee);
        }

        public static List<Employee> GetAllEmployees()
        {
            return ListEmployees;
        }

        public static object? SearchEmployeeByIdentityNumber(string identityNumber)
        {
            return ListEmployees.FirstOrDefault(e => e.IdentityNumber == identityNumber);
        }

        public static void AddClient(Client client)
        {
            ListClients.Add(client);
        }

        public static void DeleteClient(Client client)
        {
            ListClients.Remove(client);
        }
        public static List<Client> GetAllClients()
        {
            return ListClients;
        }
    }
} 