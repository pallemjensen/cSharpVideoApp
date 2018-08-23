using System;
using System.Collections.Generic;
using System.Text;

namespace Video_application
{
    public class Printer
    {
        private int selection = 0;
        readonly String[] menuItems =
        {
            "List videos",
            "Add video",
            "Delete video",
            "Edit video",
            "Search",
            "Exit"
        };

        public int OptionMenu()
        {
            Console.WriteLine("Select what you want to do. \n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {menuItems[i]}");
            }

            int selection;

            while(!int.TryParse(Console.ReadLine(), out selection)
            || selection < 1 
            || selection > 6)
            {
                Console.WriteLine("You need to choose to a number from 1 - 6");
            }
            Console.WriteLine("");
            //Console.WriteLine($"Selection : {selection}");
            //Console.WriteLine("");
            return selection;
        }


        



    }
}
