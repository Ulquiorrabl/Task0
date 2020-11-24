using System;
using System.Collections.Generic;
using System.Text;
using Task0.Player.PlayerFactory.PlayerFactoryImplementation;
using Task0.FileStructure;
using Task0.StorageStructure.StorageImplementation;

namespace Task0.MediatekaStructure.MediatekaImplementation
{
    class Mediateka : IMediateka
    {
        PlayerFactory playerfactory;
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
            Index = 0;
        }
        public Enum Play(int id)
        {
            try
            {
                playerfactory.Play(storage.FindById(id));
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
            playerfactory.Stop();
            return Status.Stop;
        }
    }
}
