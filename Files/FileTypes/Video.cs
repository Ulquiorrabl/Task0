using System;
using System.Collections.Generic;
using System.Text;

namespace Task0.Files.FileTypes
{
    class Video : File
    {
        public float Length { get; private set; }
        public int BitRate { get; private set; }
        public Video(string name, float size, float length, int bitrate) : base(name, size) 
        {
            this.Length = length;
            this.BitRate = bitrate;
        }
    }
}
