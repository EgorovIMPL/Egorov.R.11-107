using System;

namespace Egorov.R._11_107.CodeForces
{
    public class EvgeniyPlaylist
    {
        public void Run()
        {
            int songsNum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse)[0];
            int[][] playlist = new int[songsNum][];
            for (int i = 0; i < songsNum; i++)
            {
                playlist[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }
            int[] moments = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] time = new int[playlist.Length];
            time[0] = playlist[0][0] * playlist[0][1];
            for (int i = 1; i < playlist.Length; i++)
                time[i] = time[i-1] + playlist[i][0] * playlist[i][1];
            foreach (var m in moments)
            {
                int count = 1;
                while (m > time[count-1])
                    count++;
                Console.WriteLine(count);
            }
        }
    }
}