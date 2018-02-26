using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OnlineRadionDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSongs = int.Parse(Console.ReadLine());
            List<Song> playList = new List<Song>();
            int allSecond = 0;
            int allMinutes = 0;
            for (int i = 0; i < countSongs; i++)
            {
                string[] dataSong = Console.ReadLine().Split(';');
                string artistName = dataSong[0];
                string songName = dataSong[1];
                try
                {
                    string[] minutesAndSeconds = dataSong[2].Split(':');
                    int minutes = int.Parse(minutesAndSeconds[0]);
                    int seconds = int.Parse(minutesAndSeconds[1]);
                    Song song = new Song(artistName, songName, minutes, seconds);
                    playList.Add(song);
                    Console.WriteLine("Song added.");
                    allMinutes += minutes;
                    allSecond += seconds;
                }
                catch (InvalidSongException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException f)
                {
                    Console.WriteLine("Invalid song length.");
                }
              
            }
            TimeSpan ts = new TimeSpan(0, allMinutes, allSecond);
            Console.WriteLine($"Songs added: {playList.Count}");
            Console.WriteLine($"Playlist length: {ts.Hours}h {ts.Minutes}m {ts.Seconds}s");

            //string a = "14:59";
            //string b = "0:5";
            //int[] c = a.Split(':').Select(int.Parse).ToArray();
            //int[] d = b.Split(':').Select(int.Parse).ToArray();
            //TimeSpan ts = new TimeSpan(0, c[0],c[1]);
            //ts = ts.Add(new TimeSpan(0, d[0], d[1]));
            //Console.WriteLine(ts);

        }
    }
}
