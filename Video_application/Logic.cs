using System;
using System.Collections.Generic;

namespace Video_application
{
    public class Logic
    {      
        private int _x;
        readonly VideoData _videoData = new VideoData();
        
        public List<Video> ListVideoLogic()
        {
            return _videoData.GetVideoList();
        }

        public void AddVideoLogic(string newVideoName, string newVideoGenre, int newVideoDuration )
        {          
            _x++;
            _videoData.AddVideos(_x, newVideoName, newVideoGenre, newVideoDuration);

        }

        public void DeleteVideoLogic(int idToDelete)
        {
            _videoData.DeleteVideo(idToDelete);
        }


        public void EditVideoLogic(int id, String newName, String newGenre, int newDuration)
        {
            _videoData.DbEditVideo(id, newName, newGenre, newDuration);
        }

        public void SearchLogic()
        {
            Console.WriteLine("You chose option 5 : Search function activated.");          
            Console.WriteLine("");

            string[] searchMenuItems =
            {
                "Id",
                "Name",
                "Genre",               
            };

                Console.WriteLine("Select what you want to search for with a number input: \n");

                for (var i = 0; i < searchMenuItems.Length; i++)
                {
                    Console.WriteLine($"{i + 1} : {searchMenuItems[i]}");
                }

            int searchSelection;

                while (!int.TryParse(Console.ReadLine(), out searchSelection)
                       || searchSelection < 1
                       || searchSelection > 3)
                {
                    Console.WriteLine("You need to choose to a number from 1 - 3");
                }

            var searchSelectionFinal = 0;

            
                switch (searchSelection)
                {

                    case 1:
                        searchSelectionFinal = 1;
                        break;

                    case 2:
                        searchSelectionFinal = 2;
                        break;

                    case 3:
                        searchSelectionFinal = 3;
                        break;

                    case 4:
                        Console.WriteLine("Press a key to exit the application.");
                        break;
                }
            

            switch (searchSelectionFinal)
            {
                case 1:
                {
                    Console.WriteLine("You chose to search via Id.");
                    Console.WriteLine($"Please input a video Id you would like to search for. It must be between 1 and {_videoData.GetVideoList().Count}:");
                    var idSearchInt = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    var idSearchResults = 0;
                    foreach (var iVideo in _videoData.GetVideoList())
                    {
                        if (iVideo.Id == idSearchInt)
                        {
                            idSearchResults++;
                            Console.WriteLine($"Id: {iVideo.Id}");
                            Console.WriteLine($"Name: {iVideo.Name}");
                            Console.WriteLine($"Genre: {iVideo.Genre}");
                            Console.WriteLine($"Duration: {iVideo.Duration}");
                            Console.WriteLine("");
                        }
                    }
                    Console.WriteLine($"There was {idSearchResults} number of results when searching via Id.");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("You chose to search via Name.");
                    Console.WriteLine("Do you want to search for an exact phrase (1) or must the name just contain your phrase(2)?");
                    var nameSearchMethod = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Please input a name to search for:");
                    var searchString = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine($"You chose to search for {searchString}");
                    Console.WriteLine("");
                    if (nameSearchMethod == 1)
                    {
                        var numberOfExactResuslts = 0;
                        foreach (var iVideo in _videoData.GetVideoList())
                        {
                            if (String.Equals(iVideo.Name, searchString, StringComparison.CurrentCultureIgnoreCase))
                            {
                                numberOfExactResuslts++;
                                Console.WriteLine($"Id: {iVideo.Id}");
                                Console.WriteLine($"Name: {iVideo.Name}");
                                Console.WriteLine($"Genre: {iVideo.Genre}");
                                Console.WriteLine($"Duration: {iVideo.Duration}");
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine($"There was {numberOfExactResuslts} result(s) from your search.");
                        Console.WriteLine("");
                    }

                    if (nameSearchMethod == 2)
                    {
                        var numberOfContainsResuslts = 0;
                        foreach (var iVideo in _videoData.GetVideoList())
                        {
                            if (searchString != null && (iVideo.Name).ToLower().Contains(searchString.ToLower()))
                            {
                                numberOfContainsResuslts++;
                                Console.WriteLine($"Id: {iVideo.Id}");
                                Console.WriteLine($"Name: {iVideo.Name}");
                                Console.WriteLine($"Genre: {iVideo.Genre}");
                                Console.WriteLine($"Duration: {iVideo.Duration}");
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine($"There was {numberOfContainsResuslts} result(s) from your search.");
                        Console.WriteLine("");
                    }

                    break;
                }
                case 3:
                {
                    Console.WriteLine("You chose to search via Genre.");
                    Console.WriteLine("Do you want to search for an exact phrase (1) or must the name just contain your phrase(2)?");
                    var nameSearchMethodGenre = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Please input a genre to search for:");
                    var searchString = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine($"You chose to search for {searchString}");
                    Console.WriteLine("");
                    if (nameSearchMethodGenre == 1)
                    {
                        var numberOfExactGenreResuslts = 0;
                        foreach (var iVideo in _videoData.GetVideoList())
                        {
                            if (string.Equals(iVideo.Genre, searchString, StringComparison.CurrentCultureIgnoreCase))
                            {
                                numberOfExactGenreResuslts++;
                                Console.WriteLine($"Id: {iVideo.Id}");
                                Console.WriteLine($"Name: {iVideo.Name}");
                                Console.WriteLine($"Genre: {iVideo.Genre}");
                                Console.WriteLine($"Duration: {iVideo.Duration}");
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine($"There was {numberOfExactGenreResuslts} result(s) from your search.");
                        Console.WriteLine("");
                    }

                    if (nameSearchMethodGenre == 2)
                    {
                        var numberOfContainsGenreResuslts = 0;
                        foreach (var iVideo in _videoData.GetVideoList())
                        {
                            if (searchString != null && (iVideo.Genre).ToLower().Contains(searchString.ToLower()))
                            {
                                numberOfContainsGenreResuslts++;
                                Console.WriteLine($"Id: {iVideo.Id}");
                                Console.WriteLine($"Name: {iVideo.Name}");
                                Console.WriteLine($"Genre: {iVideo.Genre}");
                                Console.WriteLine($"Duration: {iVideo.Duration}");
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine($"There was {numberOfContainsGenreResuslts} result(s) from your search.");
                        Console.WriteLine("");
                    }

                    break;
                }
            }
        }
    }

 
}
