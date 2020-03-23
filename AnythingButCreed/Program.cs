using System;
using System.Collections.Generic;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Define a List, named `goodSongs`, that will hold instances of `Song`.

            List<Song> goodSongs = new List<Song>();

            var thunder = new Song("Thunder", "Imagine Dragons");
            var allIn = new Song("All In", "Lifehouse");
            var open = new Song("Arms Wide Open", "Creed");
            var jude = new Song("Hey Jude", "The Beatles");
            var allStar = new Song("All Star", "Smash Mouth");
            var higher = new Song("Higher", "Creed");
            var wheel = new Song("Wheel In the Sky", "Journey");
            var sacrifice = new Song("My Sacrifice", "Creed");
            var thriller = new Song("Thriller", "Michael Jackson");
            var last = new Song("One Last Breath", "Creed");
            var believer = new Song("Believer", "Imagine Dragons");
            var africa = new Song("Africa", "Toto");


            //3. Define a List, named `allSongs`, that contains 12 instances of `Song`.
            //Make sure that some of the songs are from the band Creed.If you're not familiar with the band, consider yourself lucky and make up some songs. It's not worth googling.

            List<Song> allSongs = new List<Song>();
            allSongs.Add(thunder);
            allSongs.Add(allIn);
            allSongs.Add(open);
            allSongs.Add(jude);
            allSongs.Add(allStar);
            allSongs.Add(higher);
            allSongs.Add(wheel);
            allSongs.Add(sacrifice);
            allSongs.Add(thriller);
            allSongs.Add(last);
            allSongs.Add(believer);
            allSongs.Add(africa);


            //4. Once the set is populated with 12 instances of song, use Linq to filter the `allSongs` list for songs where the artist is **not** Creed.
            //Set `goodSongs` equal to the filtered result.

            goodSongs = allSongs.FindAll(song => !song.Artist.Contains("Creed"));

            foreach(var song in goodSongs)
            {
                Console.WriteLine(song.Artist + ": " + song.Name);
            }

            //5. Loop to print out all the good songs:
            //Queen : Don't Stop Me Now
            //Dolly Parton : 9 to 5
        }
    }
}
