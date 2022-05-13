using ShopSolution.ConsoleApp.Models;

namespace ShopSolution.ConsoleApp.Services
{
    public class ApplicationService
    {
        private readonly ShopItemService _shopService = new ShopItemService();

        public void Process(string command)
        {

            try
            {
                command = command.ToLower();
                string[] parameters = command.Split(" ");

                if (command.StartsWith("add"))
                {
                    int quantity = int.Parse(parameters[2]);
                    decimal price = decimal.Parse(parameters[3]);

                    _shopService.Add(parameters[1], quantity, price);
                }
                else if (command.StartsWith("remove"))
                {
                    _shopService.Remove(parameters[1]);
                }
                else if (command.StartsWith("show inventory"))
                {
                    List<ShopItem> items = _shopService.GetAll();

                    items.ForEach(i => Console.WriteLine(i.ToString()));
                }
                else if (command.StartsWith("set"))
                {
                    int quantity = int.Parse(parameters[2]);

                    _shopService.UpdateQuantity(parameters[1], quantity);
                }
                else if (command.StartsWith("buy"))
                {
                    int quantity = int.Parse(parameters[2]);

                    _shopService.Buy(parameters[1], quantity);
                }
                else if (command.StartsWith("topup"))
                {
                    decimal money = decimal.Parse(parameters[2]);

                    _shopService.Topup(money);
                }
                else if (command.StartsWith("show items"))
                {
                    List<ShopItem> items = _shopService.GetCustomerItems();
                    items.ForEach(i => Console.WriteLine(i.ToString()));
                }
                else if (command.StartsWith("show balance"))
                {

                    decimal balance = _shopService.GetBalance();
                    Console.WriteLine($"Balance: {balance}");
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Something wrong with your parameters");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong has happened");
            }
        }
    }
}
