using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWorkers
{
    public class Worker
    {
        public string Name { get => $"{LastName} {FirstName[0]}."; }
        public string FirstName { get; set; } = "Unknown";
        public string LastName { get; set; } = "Unknown";

        public string Position { get; set; } = "Unknown";

        private int salary;
        public int Salary
        {
            get => salary;

            set
            {
                if (value > 0)
                    salary = value;
                else
                    Console.WriteLine($"Значение должно быть больше — 0");
            }
        }

        private int employmentYear;
        public int EmploymentYear
        {
            get => employmentYear;

            set
            {
                int conditionNumber = 1900;

                if (value >= conditionNumber)
                    employmentYear = value;
                else
                    Console.WriteLine($"Значение должно быть больше или равно — {conditionNumber}");
            }
        }
        
        public int WorkExperience { get => DateTime.Now.Year - EmploymentYear; }

        public Worker() { }

        public Worker(string firstName, string lastName, string position, int salary, int employmentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;

            Salary = salary;
            EmploymentYear = employmentYear;
        }

        public static bool operator > (Worker workerOne, Worker workerTwo)
        {
            int result = string.Compare(workerOne.Name, workerTwo.Name);
            return result < 0;
        }

        public static bool operator < (Worker workerOne, Worker workerTwo)
        {
            int result = string.Compare(workerOne.Name, workerTwo.Name);
            return result > 0;
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nДолжность: {Position}\nЗарплата: {Salary}\nГод трудоустройства: {EmploymentYear}\nСтаж работы: {WorkExperience}";
        }
    }
}
