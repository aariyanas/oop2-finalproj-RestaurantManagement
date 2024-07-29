using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RestaurantManagement.Data
{
    public class InventoryManager
    {
        public static string inventoryFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\Resources\Res\inventory.csv");

        public static List<Inventory> inventoryInfo = new List<Inventory>();

        static InventoryManager()
        {
            LoadInventory();
        }

        public static void LoadInventory()
        {
            try
            {
                inventoryInfo.Clear();
                foreach (string line in File.ReadLines(inventoryFile))
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    int quantity = int.Parse(parts[1]);
                    double price = double.Parse(parts[2]);
                    string category = parts[3];

                    inventoryInfo.Add(new Inventory(name, quantity, price, category));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void OrderInventory(string name, int quantityToAdd)
        {
            var inventoryItem = inventoryInfo.FirstOrDefault(i => i.Name == name);
            if (inventoryItem != null)
            {
                inventoryItem.Quantity += quantityToAdd;
                SaveInventory();
            }
        }

        public static void DeleteInventoryItem(Inventory item)
        {
            inventoryInfo.Remove(item);
            SaveInventory();
        }

        private static void SaveInventory()
        {
            try
            {
                using (var writer = new StreamWriter(inventoryFile))
                {
                    foreach (var item in inventoryInfo)
                    {
                        writer.WriteLine($"{item.Name},{item.Quantity},{item.Price},{item.Category}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


