using System;
using System.Collections.Generic;
using System.Text;
using Task0.PlayerStructure.PlayerImplementation.PlayerTypes;
using Task0.FileStructure;
using Task0.FileStructure.FileTypes;

namespace Task0.Player.PlayerFactory.PlayerFactoryImplementation
{
    class PlayerFactory : IPlayerFactory
    {
        PlayerVideo playervideo = new PlayerVideo();
        PlayerTrack playertrack = new PlayerTrack();
        PlayerPhoto playerphoto = new PlayerPhoto();

        public void Play(File file)
        {
            if (file is Photo) { playerphoto.Play(file); };
            if (file is Video) { playervideo.Play(file); };
            if (file is Track) { playertrack.Play(file); };
        }

        public void Stop()
        {
            playerphoto.Stop();
            playertrack.Stop();
            playervideo.Stop();
        }
    }
}
