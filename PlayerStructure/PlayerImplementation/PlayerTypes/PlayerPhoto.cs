using System;
using System.Collections.Generic;
using System.Text;
using Task0.FileStructure.FileTypes;

namespace Task0.PlayerStructure.PlayerImplementation.PlayerTypes
{
    class PlayerPhoto : Player
    {
        public void Play(Photo photo)
        {
            Decode(photo);
        }

        public override void Stop()
        {

        }

        void Decode(Photo photo)
        {

        }
    }
}
