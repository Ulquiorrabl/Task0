using System;
using System.Collections.Generic;
using System.Text;
using Task0.Player.PlayerFactory.PlayerFactoryImplementation;
using Task0.FileStructure;
using Task0.StorageStructure.StorageImplementation;

namespace Task0.Mediateka.MediatekaImplementation
{
    class Mediateka : IMediateka
    {
        PlayerFactory playerfactory;
        Storage storage;
        int index;
        
        public Mediateka()
        {
            playerfactory = new PlayerFactory();
            storage = new Storage();
            index = 0;
        }
        public void Play(int index)
        {
            playerfactory.Play(storage.Find(index));
        }
        public void PlayPrevious()
        {
            if(index != 0) { Play(index - 1); }
        }
        public void PlayNext()
        {
            Play(index + 1);
        }
        public void Stop()
        {
            playerfactory.Stop();
        }
    }
}
