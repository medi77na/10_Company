using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using _10_Company.Enums;

namespace _10_Company.Models;
public class Employee : Person
{
    public Guid Id { get; set; }
    public string? IdentityNumber { get; set; }
    public Positions Position { get; set; }
    public double Salary { get; set; } 

    public Employee(string name, string lastName, string identityNumber, DateOnly birthDate, Positions position, double salary)
    : base(name, lastName, birthDate)
    {
        Id = Guid.NewGuid();
        IdentityNumber = identityNumber;
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