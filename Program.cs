using System;

namespace Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photo1 = new Photo("Parents", 124, 1080);
            Track track = new Track("Bring me The Horizon - Doomed", 4.5f, 4.06f);
            Video video = new Video("Meeting 19.01.2020", 118, 20.45f, 128);

            Mediateka media = new Mediateka(new File[] {photo1, track, video});
            media.ShowMedia();
            Photo photo2 = new Photo("Children", 45, 720);
            media.Add(photo2);
            Console.WriteLine("");
            media.ShowMedia();
            Console.ReadKey();
        }
    }
}
