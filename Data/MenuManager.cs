using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class MenuManager
    {
        public static string menuFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\Resources\Res\menu.csv");

        public static List<Menu> menuInfo = new List<Menu>();

        public static List<Menu> GetMenu()
        {
            List<Menu> menu = new List<Menu>();
            foreach (string line in File.ReadLines(menuFile))
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                double price = double.Parse(parts[1]);
                string category = parts[2];

                Menu menuItems = new Menu(name, price, category);
                menu.Add(menuItems);
            }
            menuInfo = menu;
            return menu;
        }

        public static void AddMenuItem(Menu newItem)
        {
            newItem.Name = newItem.Name.ToPascalCase();
            newItem.Category = newItem.Category.ToPascalCase();
            menuInfo.Add(newItem);
            menuInfo = menuInfo.OrderBy(m => m.Category).ThenBy(m => m.Name).ToList();

            using (StreamWriter sw = File.AppendText(menuFile))
            {
                sw.WriteLine($"{newItem.Name},{newItem.Price},{newItem.Category}");
            }
        }
        public static void DeleteMenuItem(Menu itemToDelete)
        {
            menuInfo.Remove(itemToDelete);
            File.WriteAllLines(menuFile, menuInfo.Select(m => $"{m.Name},{m.Price},{m.Category}"));
        }

    }
}
