// See https://aka.ms/new-console-template for more information
using ShopSolution.ConsoleApp.Services;

Console.WriteLine("Hello, World!");

var applicationService = new ApplicationService();

while (true)
{
    Console.WriteLine("Enter your command");
    var command = Console.ReadLine();
    applicationService.Process(command);
}
