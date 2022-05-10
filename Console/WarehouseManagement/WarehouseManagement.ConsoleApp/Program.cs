using System;
using WarehouseManagement.ConsoleApp.Services;

namespace WarehouseManagement.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var applicationService = new ApplicationService();

                Console.WriteLine("Enter your command:");
                var command = Console.ReadLine();

                applicationService.Process(command);
            }
        }
    }
}
