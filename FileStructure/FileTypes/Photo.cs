using System;
using System.Collections.Generic;
using System.Text;

namespace Task0.FileStructure.FileTypes
{
    class Photo : File
    {
        public float Resolution { get; private set; }
        public Photo(string name, float size, float resolution) : base(name, size)
        {
            this.Resolution = resolution;
        }
    }
}
