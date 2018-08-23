using System;
using System.Collections.Generic;
using System.Text;

namespace Video_application
{
    public class CRUD
    {
        public void ChooseMenuItem(int menuSelection)
        {
            

            while (menuSelection != 6)
            {
                switch (menuSelection)
                {

                    case 1:
                        Console.WriteLine("You chose 1 : List Videos.");
                        ListVideos();
                        break;

                    case 2:
                        Console.WriteLine("You chose 2 : Add video.");
                        AddVideo();
                        break;

                    case 3:
                        Console.WriteLine("You chose 3 : Delete video.");
                        DeleteVideo();
                        break;

                    case 4:
                        Console.WriteLine("You chose 4 : Edit Video.");
                        EditVideo();
                        break;

                    case 5:
                        Console.WriteLine("You chose 5 : Search function activated.");
                        Search();
                        break;

                    case 6:
                        Console.WriteLine("You chose 6: Exit application.");
                        ExitApplication();
                        break;

                        

                    default:
                        break;
                        
                }

                break;
            }


        }

        public void DeleteVideo()
        {

        }

        public void AddVideo()
        {

        }

        public void EditVideo()
        {

        }

        public void ExitApplication()
        {

        }

        public void ListVideos()
        {

        }

        public void Search()
        {

        }

    }
}
