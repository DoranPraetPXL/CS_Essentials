using Labo.Models;

namespace Labo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Voornaam: ");
            string firstName = Console.ReadLine();

            Console.Write("Achternaam: ");
            string lastName = Console.ReadLine();

            Console.Write("Geboortedatum: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Salaris: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Employee employee = new Employee(firstName, lastName)
            {
                BirthDate = birthDate,
                Salary = salary
            };

            ShowDetails(employee);

            int percentage;
            do
            {
                Console.Write("Opslag percentage: ");
            } while(!int.TryParse(Console.ReadLine(), out percentage) || percentage < 0 || percentage > 10);

            employee.IncreaseSalary(percentage);

            ShowDetails(employee);
        }

        static void ShowDetails(Employee employee)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Wernemer: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"Geboortedatum: {employee.BirthDate.ToLongDateString()} ({employee.Age})");
            Console.WriteLine($"Salaris: {employee.Salary:C}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Samenvatting: {employee}");
            Console.WriteLine("--------------------------------------");
        }
    }
}
