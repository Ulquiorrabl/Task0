﻿using System;
using System.Collections.Generic;
using System.Text;
using Task0.Files.FileTypes;

namespace Task0.PlayerStructure.PlayerImplementation.PlayerTypes
{
    class PlayerVideo : Player
    {
        public void Play(Video video)
        {
            Decode(video);
        }

        public new void Stop()
        {

        }

        void Decode(Video video)
        {

        }
    }
}
