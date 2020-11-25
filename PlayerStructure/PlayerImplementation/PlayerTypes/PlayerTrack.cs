using System;
using System.Collections.Generic;
using System.Text;
using Task0.FileStructure.FileTypes;

namespace Task0.PlayerStructure.PlayerImplementation.PlayerTypes
{
    class PlayerTrack : Player
    {
        public void Play(Track track)
        {
            Decode(track);
        }

        public override void Stop()
        {

        }

        void Decode(Track track)
        {

        }
    }
}
