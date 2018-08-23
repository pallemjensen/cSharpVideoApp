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
                        ListVideos();
                        break;

                    case 2:                       
                        AddVideo();
                        break;

                    case 3:                       
                        DeleteVideo();
                        break;

                    case 4:
                        EditVideo();
                        break;

                    case 5:                        
                        Search();
                        break;

                    case 6:                        
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
            Console.WriteLine("You chose 3 : Delete video.");
        }

        public void AddVideo()
        {
            Console.WriteLine("You chose 2 : Add video.");
        }

        public void EditVideo()
        {
            Console.WriteLine("You chose 4 : Edit Video.");
        }

        public void ExitApplication()
        {
            Console.WriteLine("You chose 6: Exit application.");
        }

        public void ListVideos()
        {
            Console.WriteLine("You chose 1 : List Videos.");
        }

        public void Search()
        {
            Console.WriteLine("You chose 5 : Search function activated.");
        }

    }
}
