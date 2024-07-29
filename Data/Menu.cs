using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class Menu
    {
        private string _name;
        private double _price;
        private string _category;

        public Menu(string name, double price, string category)
        {
            _name = name;
            _price = price;
            _category = category;
        }

        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public string Category { get => _category; set => _category = value; }
        
    }
}
