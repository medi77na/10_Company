using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_Company.Models
{
    public abstract class Person
    {
        protected Guid id;
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
        
        protected string? name;
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        protected string? lastName;
        public string? LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        protected DateOnly birthDate;
        public DateOnly BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public Person(string name, string lastName, DateOnly birthDate)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public int CalculateAge()
        {
            return DateTime.Today.Year - BirthDate.Year;
        }

        public override string ToString()
        {
            return $"{Name} {LastName}, {CalculateAge()} años";
        }
    }
}