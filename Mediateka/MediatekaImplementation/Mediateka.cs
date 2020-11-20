using System;
using System.Collections.Generic;
using System.Text;
using Task0.Files;

namespace Task0.Mediateka.MediatekaImplementation
{
    class Mediateka : IMediateka
    {
        List<File> media = new List<File>();

        public Mediateka(Array arr)
        {
            foreach(File file in arr)
            {
                media.Add(file);
            }
        }

        public void Add(File file)
        {
            media.Add(file);
        }

        public void Remove(int index)
        {
            media.Remove(media[index]);
        }

        public void ShowMedia()
        {
            int index = 1;
            foreach(File file in media)
            {
                Console.WriteLine(index.ToString() + "." + file.Name + ".");
                index++;
            }
            index = 1;
        }
    }
}
