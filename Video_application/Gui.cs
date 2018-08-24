using System;

namespace Video_application
{
    public class Gui
    {
        private readonly Logic _logic = new Logic();

        private readonly string[] _menuItems =
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

            for (var i = 0; i < _menuItems.Length; i++) Console.WriteLine($"{i + 1} : {_menuItems[i]}");

            int selection;

            while (!int.TryParse(Console.ReadLine(), out selection)
                   || selection < 1
                   || selection > 6)
                Console.WriteLine("You need to choose to a number from 1 - 6");
            Console.WriteLine("");

            return selection;
        }


        public void ChooseMenuItem(int menuSelection)
        {
            while (menuSelection != 6)
            {
                switch (menuSelection)
                {
                    case 1:
                        ListVideo();
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
                        SearchLogic();

                        break;

                    case 6:
                        Console.WriteLine("Press a key to exit the application.");
                        break;
                }

                menuSelection = OptionMenu();
            }

            Console.WriteLine("Bye!");
        }

        public void AddVideo()
        {
            Console.WriteLine("You chose option 2 : Add video.");
            Console.WriteLine("");

            Console.WriteLine("Input Name of Video:");
            var newVideoName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Input genre of the video:");
            var newVideoGenre = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Input duration of the video in minutes:");
            var newVideoDuration = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            _logic.AddVideoLogic(newVideoName, newVideoGenre, newVideoDuration);
        }

        public void ListVideo()
        {
            Console.WriteLine("You chose option 1 : List Videos.");
            Console.WriteLine("");

            foreach (var iVideo in _logic.ListVideoLogic())
            {
                Console.WriteLine($"Id: {iVideo.Id}");
                Console.WriteLine($"Name: {iVideo.Name}");
                Console.WriteLine($"Genre: {iVideo.Genre}");
                Console.WriteLine($"Duration: {iVideo.Duration}");
                Console.WriteLine("");
            }
        }

        public void DeleteVideo()
        {
            Console.WriteLine("You chose option 3 : Delete video.");

            Console.WriteLine("");

            foreach (var iVideo in _logic.ListVideoLogic())
                Console.Write($"Id: {iVideo.Id - 1} - Name: {iVideo.Name} \n");

            Console.WriteLine("");
            Console.WriteLine("Input the video Id number for the video you want to delete:");
            var idToDelete = Convert.ToInt32(Console.ReadLine());

            _logic.DeleteVideoLogic(idToDelete);

            Console.WriteLine("Video was deleted.");
            Console.WriteLine("");
        }

        public void EditVideo()
        {
            Console.WriteLine("You chose option 4 : Edit Video.");
            Console.WriteLine("");
            foreach (var iVideo in _logic.ListVideoLogic())
                Console.Write($"Id: {iVideo.Id - 1} - Name: {iVideo.Name} \n");

            Console.WriteLine("Choose the id number for the video you want to edit:");
            var idToEdit = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a new name for the chosen video:");
            var videoNameToEdit = Console.ReadLine();
            Console.WriteLine("Choose a new genre for the chosen video:");
            var videoGenreToEdit = Console.ReadLine();
            Console.WriteLine("Choose a new duration for the chosen video:");
            var videoDurationToEdit = int.Parse(Console.ReadLine());

            _logic.EditVideoLogic(idToEdit, videoNameToEdit, videoGenreToEdit, videoDurationToEdit);
        }

        public void SearchLogic()
        {
            _logic.SearchLogic();
        }
    }
}