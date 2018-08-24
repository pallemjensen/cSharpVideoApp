using System;

namespace Video_application
{
    class Program
    {
        static void Main()
        {
            var crud = new Gui();                   
            crud.ChooseMenuItem(crud.OptionMenu());

            Console.ReadLine();
        }
    }
}
