using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            int waitingTime = 10;
            int minutesInHour = 60;

            Console.Write("Введите количество людей в очереди: ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());
            
            int waitingHours = peopleInLine * waitingTime / minutesInHour;
            int waitingMinutes = peopleInLine * waitingTime % minutesInHour;

            Console.WriteLine($"Время ожидания сосавит {waitingHours} часов и {waitingMinutes} минут");

            Console.ReadKey();

        }
    }
}
