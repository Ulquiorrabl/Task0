using System;
using System.Collections.Generic;
using System.Text;
using Task0.FileStructure.FileTypes;

namespace Task0.Player.PlayerImplementation.PlayerTypes
{
    class PlayerTrack : Player
    {
        public void Play(Track track)
        {
            Decode(track);
        }

        public new void Stop()
        {

        }

        void Decode(Track track)
        {

        }
    }
}
