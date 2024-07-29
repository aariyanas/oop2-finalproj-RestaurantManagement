using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class Employees
    {
        private int _id;
        private string _name;
        private string _position;
        private string _email;
        private string _joinDate;
        private double _wage;

        public Employees(int id, string name, string position, string email, string joinDate, double wage)
        {
            _id = id;
            _name = name;
            _position = position;
            _email = email;
            _joinDate = joinDate;
            _wage = wage;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Position { get => _position; set => _position = value; }
        public string Email { get => _email; set => _email = value; }
        public string JoinDate { get => _joinDate; set => _joinDate = value; }
        public double Wage { get => _wage; set => _wage = value; }
    }
}
