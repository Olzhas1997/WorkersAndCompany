    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWorkers
{
    public static class AttributeSetting
    {
        static string errorMessage = "\nВы ввели неверное значение. Попробуйте еще раз: ";

        public static string StringValue(string message)
        {
            Console.Write(message);

            string? value = Console.ReadLine();
            return (!string.IsNullOrEmpty(value)) ? value.Trim() : StringValue(errorMessage);
        }
        public static int NumericValue(string message)
        {
            Console.Write(message);

            bool convertationProcess = int.TryParse(Console.ReadLine(), out int value);
            return (convertationProcess) ? value : NumericValue(errorMessage);
        }
    }
}
