using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class Inventory
    {
        private string _name;
        private int _quantity;
        private double _price;
        private string _category;
        private int _quantityToOrder;

        public Inventory(string name, int quantity, double price, string category)
        {
            _name = name;
            _quantity = quantity;
            _price = price;
            _category = category;
            _quantityToOrder = 0;
        }

        public string Name { get => _name; set => _name = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public double Price { get => _price; set => _price = value; }
        public string Category { get => _category; set => _category = value; }
        public int QuantityToOrder { get => _quantityToOrder; set => _quantityToOrder = value; }
    }
}

