using System;

namespace Video_application
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            int x = printer.OptionMenu();

            CRUD crud = new CRUD();
            crud.ChooseMenuItem(x);
            Console.ReadLine();
        }


    }
}
