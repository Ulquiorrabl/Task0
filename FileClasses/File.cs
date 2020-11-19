using System;
using System.Collections.Generic;
using System.Text;

namespace Task0
{
    class File : IPlay
    {
        public string Name { get; private set; }
        public float Size { get; private set; }
        public string Format { get; private set; }
        public File(string name, float size)
        {
            this.Name = name;
            this.Size = size;
        }
        public void ChangeName(string name)
        {
            if(name != null)
            {
                this.Name = name;
            }
        }

        public void Play()
        {
            Console.WriteLine("Show");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public void Reset()
        {
            Console.WriteLine("Show");
        }
    }
}
