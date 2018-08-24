using System;
using System.Collections.Generic;
using System.Linq;

namespace Video_application
{
    public class VideoData
    {
        private readonly List<Video> _videos = new List<Video>();

        public void AddVideos(int id, string newVideoName, string newVideoGenre, int newVideoDuration)
        {
            _videos.Add(new Video()
            {
                Id = id,
                Name = newVideoName,
                Genre = newVideoGenre,
                Duration = newVideoDuration
            });
        }

        public List<Video> GetVideoList()
        {          
            return _videos;
        }

        public void DeleteVideo(int videoId)
        {            
            videoId++;   
            
            foreach (var video in _videos.ToList())
            {
                if (video.Id == videoId)
                {
                    _videos.Remove(video);
                }
            }           
        }

        public void DbEditVideo(int id, String newName, String newGenre, int newDuration)
        {
            foreach (var video in _videos.ToList())
            {
                if (video.Id == id)
                {
                    video.Name = newName;
                    video.Genre = newGenre;
                    video.Duration = newDuration;
                }
            }
        }
    }
}



