using System;

namespace InventoryManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Item item1 = new Item("Laptop", 23, 500);
                Item item2 = new Item("Mouse", 20, 400);
                Item item3 = new Item("Printer", 14, 700);


                item1.DisplayDetails();

                Inventory inventory1 = new Inventory();
                inventory1.AddItem(item1);
                inventory1.AddItem(item2);
                inventory1.AddItem(item3);
                inventory1.DisplayItems();
                inventory1.UpdateItem("Mouse", 25, 600);
                item2.DisplayDetails();
                inventory1.RemoveItem("Laptop");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

