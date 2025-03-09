using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Tasks.MediaPlayer
{
    
    interface IMediaPlayer
    {
        void Play();
        void Pause();
        void Stop();
        string GetStatus();
    }

    
    interface IPlaylist
    {
        void AddToPlaylist(string media);
        void RemoveFromPlaylist(string media);
        void ShowPlaylist();
    }

    
    abstract class MediaPlayer : IMediaPlayer, IPlaylist
    {
        protected string status = "Stopped";
        protected string[] playlist = new string[10];
        protected int count = 0;

        public void Play()
        {
            if (count > 0)
            {
                status = "Playing";
                Console.WriteLine("Now Playing: " + playlist[0]);
            }
            else
            {
                Console.WriteLine("Playlist is empty.");
            }
        }

        public void Pause()
        {
            if (status == "Playing")
            {
                status = "Paused";
                Console.WriteLine("Playback Paused.");
            }
        }

        public void Stop()
        {
            status = "Stopped";
            Console.WriteLine("Playback Stopped.");
        }

        public string GetStatus()
        {
            return status;
        }

        public void AddToPlaylist(string media)
        {
            if (count < 10)
            {
                playlist[count++] = media;
                Console.WriteLine(media + " added to playlist.");
            }
            else
            {
                Console.WriteLine("Playlist is full.");
            }
        }

        public void RemoveFromPlaylist(string media)
        {
            for (int i = 0; i < count; i++)
            {
                if (playlist[i] == media)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        playlist[j] = playlist[j + 1];
                    }
                    playlist[count - 1] = null;
                    count--;
                    Console.WriteLine(media + " removed from playlist.");
                    return;
                }
            }
            Console.WriteLine("Media not found in playlist.");
        }

        public void ShowPlaylist()
        {
            Console.WriteLine("Playlist:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i + 1) + ". " + playlist[i]);
            }
        }
    }

    class AudioPlayer : MediaPlayer
    {
    }

    
    class VideoPlayer : MediaPlayer
    {
    }

    
    class StreamingPlayer : MediaPlayer
    {
        public void Stream(string url)
        {
            Console.WriteLine("Streaming from: " + url);
        }
    }

   
    class Program
    {
        static void Main()
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.AddToPlaylist("Song1.mp3");
            audioPlayer.AddToPlaylist("Song2.mp3");
            audioPlayer.ShowPlaylist();
            audioPlayer.Play();
            audioPlayer.Pause();
            audioPlayer.Stop();

            VideoPlayer videoPlayer = new VideoPlayer();
            videoPlayer.AddToPlaylist("Movie1.mp4");
            videoPlayer.ShowPlaylist();
            videoPlayer.Play();

            StreamingPlayer streamingPlayer = new StreamingPlayer();
            streamingPlayer.Stream("http://example.com/video");
        }
    }

}
