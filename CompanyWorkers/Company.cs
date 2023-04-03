using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWorkers
{
    public class Company
    {
        private Worker[] workers;

        public int WorkerNumber { get => workers.Length; }
        public string Name { get; }

        public Company(string name, int volume)
        {
            Name = name;

            workers = new Worker[volume];

            WorkersAddingToList();
        }

        public Worker this[int index]
        {
            get => (WorkerNumber <= index || index < 0) ? throw new IndexOutOfRangeException() : workers[index];
            set => workers[index] = value;
        }

        private void WorkersAddingToList()
        {

            for (int i = 0; i < WorkerNumber; i++)
            {
                Console.WriteLine();

                string workerFirstName = AttributeSetting.StringValue($"Введите {i + 1}-го имя сотрудника: ");
                string workerLastName = AttributeSetting.StringValue($"Введите {i + 1}-го фамилию сотрудника: ");
                string workerPosition = AttributeSetting.StringValue($"Введите {i + 1}-го должность сотрудника: ");

                int workerEmploymentYear = AttributeSetting.NumericValue($"Введите {i + 1}-го год трудоустройства сотрудника: ");
                int workerSalary = AttributeSetting.NumericValue($"Введите зарплату {i + 1}-го сотрудника: ");

                workers[i] = new Worker(workerFirstName, workerLastName, workerPosition, workerSalary, workerEmploymentYear);

                Console.WriteLine(new string('_', 50));
            }

        }

        public void WorkersListFilteringByExperience(int desiredWorkExperience)
        {
            List<Worker>? workersFilteredList = new List<Worker>();

            for (int i = 0; i < WorkerNumber; i++)
                if (workers[i].WorkExperience > desiredWorkExperience)
                    workersFilteredList.Add(workers[i]);

            workersListOutput(workersFilteredList);
        }

        public void WorkersListSorting()
        {
            List<Worker>? workersFilteredList = new List<Worker>(workers);

            for (int i = 0; i < WorkerNumber - 1; i++)
                for (int j = i + 1; j < WorkerNumber; j++)
                    if (workersFilteredList[i] < workersFilteredList[j])
                        (workersFilteredList[i], workersFilteredList[j]) = (workersFilteredList[j], workersFilteredList[i]);

            workersListOutput(workersFilteredList);
        }

        private void workersListOutput(List<Worker> workersList)
        {
            string message = "Список работников пуст";

            if (workersList.Count == 0)
                Console.WriteLine(message);

            else
                foreach (Worker worker in workersList)
                    Console.WriteLine(worker.ToString());
        }
    }
}
