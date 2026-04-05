using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TP_MODUL6_103022400048
{
    class SayaMusicTrack
    {
        private int id;
        private string title;
        private int playCount;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh null");
            Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 1000000, "Penambahan play count maksimal 1.000.000");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada play count!");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
