using System;
using System.Collections.Generic;
using System.Text;
using Task0.PlayerStructure.PlayerImplementation.PlayerTypes;
using Task0.PlayerStructure.PlayerImplementation;
using Task0.FileStructure;
using Task0.FileStructure.FileTypes;

namespace Task0.PlayerStructure.PlayerFactory.PlayerFactoryImplementation
{
    class PlayerFactory : IPlayerFactory
    {

        public Player ReturnPlayer(File file)
        {
            if(file is Photo)
            {
                return new PlayerPhoto();
            }
            if(file is Video)
            {
                return new PlayerVideo();
            }
            if (file is Track)
            {
                return new PlayerTrack();
            }
            throw new Exception("Unexpexted file");
        }

    }
}
