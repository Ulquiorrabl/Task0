﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task0
{
    class Track : File
    {
        public float Length { get; private set; }
        public Track(string name, float size, float length) : base(name, size)
        {
            this.Length = length;
        }
    }
}
