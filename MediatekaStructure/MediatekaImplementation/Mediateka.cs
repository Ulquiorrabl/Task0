using System;
using System.Collections.Generic;
using System.Text;
using Task0.PlayerStructure.PlayerFactory.PlayerFactoryImplementation;
using Task0.FileStructure;
using Task0.StorageStructure.StorageImplementation;
using Task0.PlayerStructure.PlayerImplementation;

namespace Task0.MediatekaStructure.MediatekaImplementation
{
    class Mediateka : IMediateka
    {
        PlayerFactory playerfactory;
        Player player;
        Storage storage;
        enum Status
        {
            Play,
            Stop,
            Error
        }

        public int Index { get; private set; }
        
        public Mediateka()
        {
            playerfactory = new PlayerFactory();
            storage = new Storage();
            player = new Player();
            Index = 0;
        }
        public Enum Play(int id)
        {
            try
            {
                File file = storage.FindById(id);
                player = playerfactory.ReturnPlayer(file);
                player.Play(file);
                return Status.Play;
            }
            catch (Exception e)
            {
                return Status.Error;
            }
        }
        public Enum PlayPrevious()
        {
            if(Index != 0) { Play(Index - 1); }
            return Status.Play;
        }
        public Enum PlayNext()
        {
            Play(Index + 1);
            return Status.Play;
        }
        public Enum Stop()
        {
            player.Stop();
            return Status.Stop;
        }
    }
}
