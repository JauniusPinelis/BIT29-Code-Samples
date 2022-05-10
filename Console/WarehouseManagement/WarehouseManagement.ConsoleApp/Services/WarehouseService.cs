using System.Collections.Generic;
using System.Linq;

namespace WarehouseManagement.ConsoleApp.Services
{

    public class WarehouseService
    {
        private List<WarehouseItem> _items;

        public WarehouseService() //constructor
        {
            _items = new List<WarehouseItem>();
        }

        public void Add(string name, string price)
        {
            var item = new WarehouseItem()
            {
                Name = name,
                Price = price
            };

            _items.Add(item);
        }

        public void Remove(string name)
        {
            //var filteredItems = new List<WarehouseItem>();

            //foreach (var item in _items)
            //{
            //    if (item.Name != name)
            //    {
            //        filteredItems.Add(item);
            //    }
            //}

            //_items = filteredItems;

            _items = _items.Where(i => i.Name != name).ToList(); //linq
        }

        public List<WarehouseItem> GetAll()
        {
            return _items;
        }
    }
}
