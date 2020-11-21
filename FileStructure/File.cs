using System;
using System.Collections.Generic;
using System.Text;

namespace Task0.FileStructure
{
    internal class File
    {
        public string Name { get; private set; }
        public float Size { get; private set; }
        public string Format { get; private set; }
        public File(string name, float size)
        {
            this.Name = name;
            this.Size = size;
        }
        public File()
        {
            this.Name = "";
            this.Size = 0;
        }
        public void ChangeName(string name)
        {

        }

    }
}
