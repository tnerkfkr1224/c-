using System;
using SwinAdventure;
namespace SwinAdventure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter player name:");
            //player user input name
            string p_name = Console.ReadLine();
            Console.WriteLine("Enter player Description:");
            //player user input description
            string p_D = Console.ReadLine();

            //create player object
            Player player_input = new Player(p_name, p_D);

            //create items
            Item gun = new Item(new string[] { "gun" }, "Air gun", "this is a gun");
            Item bow = new Item(new string[] { "bow" }, "Hunting bow", "this is a bow");

            //add items in players inventory
            player_input.Inventory.Put(gun);
            player_input.Inventory.Put(bow);

            //create bag
            Bag bag = new Bag(new string[] { "bag" }, "backpack", "this is a bag");

            //add bag in players inventory
            player_input.Inventory.Put(bag);

            //create another item
            Item shield = new Item(new string[] { "shield" }, "body bunker", "this is shield");
            bag.Inventory.Put(shield);

            //loop reading commands 
            do
            {
                LookCommand cmd = new LookCommand();
                Console.Write("\nenter command:\n");
                string input = Console.ReadLine();
                string[] inputs = input.Split(' ');

                //get the look command to execute
                Console.Write(cmd.Execute(player_input, inputs));
            }
            while (true);           
        }
    }
}





