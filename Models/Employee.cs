using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace _10_Company.Models;
public class Employee
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? IdentityNumber { get; set; }
    public DateOnly BirthDate { get; set; }
    public string? Position { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string lastName, string identityNumber, DateOnly birthDate, string position, double salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        IdentityNumber = identityNumber;
        BirthDate = birthDate;
        Position = position;
        Salary = salary;
    }

    private double CalculateBonus()
    {
        return Salary * 0.1;
    }

    public override string ToString()
    {
        return $"| {Id,-10} | {Name +" "+ LastName,-25} | {IdentityNumber,-15} | {BirthDate,-20} | {Position,-20} | {Salary + CalculateBonus(),-17:C2} |";
    }
}