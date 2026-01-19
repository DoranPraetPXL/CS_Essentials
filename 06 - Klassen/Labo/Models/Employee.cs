using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.Models
{
    internal class Employee
    {
        private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		private DateTime _birtDate;

		public DateTime BirthDate
		{
			get { return _birtDate; }
			set { _birtDate = value; }
		}

		private decimal _salary;

		public decimal Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}

		public int Age => DateTime.Today.Year - BirthDate.Year;

        public Employee()
        {
            
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

		public void IncreaseSalary(int percentage)
		{
			Salary *= (1 + (percentage / 100M));
		}

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Age} - {Salary:C}";
        }
    }
}
