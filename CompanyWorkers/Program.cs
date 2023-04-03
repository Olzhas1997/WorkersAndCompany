using System;
using CompanyWorkers;

class Program
{
    static void Main(string[] args)
    {
        void companyStatisticsChoice(Company company)
        {
            bool isInfinityLoop = true;

            while (isInfinityLoop)
            {
                Console.WriteLine("\n1. Вывести отсортированный список сотрудников;\n2. Вывести сотрудников по выбранному стажу.\n3. Выход\n");

                int userAction = AttributeSetting.NumericValue("\nВыберите действие: \n");

                switch (userAction)
                {
                    case 1:
                        company.WorkersListSorting();
                        break;

                    case 2:
                        int desiredWorkExperience = AttributeSetting.NumericValue("\nВведите искомый стаж работы: ");
                        company.WorkersListFilteringByExperience(desiredWorkExperience);
                        break;

                    case 3:
                        isInfinityLoop = false;
                        break;

                    default:
                        Console.WriteLine("\nВы не выбрали действие!");
                        break;
                }
            }
        }

        Company companyCreating()
        {
            Console.WriteLine();

            string companyName = AttributeSetting.StringValue("Введите название компании: ");
            int companyWorkersNumber = AttributeSetting.NumericValue("Введите количество сотрудников компании: ");

            Console.WriteLine(new string('_', 50));

            return new Company(companyName, companyWorkersNumber);
        }

        Company company = companyCreating();
        companyStatisticsChoice(company);

        Console.ReadKey();
    }
}

