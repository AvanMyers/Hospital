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
            int turn;
            int waitingTime = 10;

            Console.Write("Введите количество людей в очереди: ");
            turn = Convert.ToInt32(Console.ReadLine());
            
            int waitingHours = turn * waitingTime / 60;
            int waitingMinutes = turn * waitingTime % 60;

            Console.WriteLine($"Время ожидания сосавит {waitingHours} часов и {waitingMinutes} минут");

            Console.ReadKey();

        }
    }
}
