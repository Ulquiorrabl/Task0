using System;
using System.Collections.Generic;
using System.Text;
using Task0.PlayerStructure.PlayerFactory.PlayerFactoryImplementation;
using Task0.FileStructure;
using Task0.StorageStructure.StorageImplementation;
using Task0.PlayerStructure.PlayerImplementation;
using Task0.MediatekaStructure.StatusEnumerator;

namespace Task0.MediatekaStructure.MediatekaImplementation
{

    class Mediateka : IMediateka
    {
        PlayerFactory playerfactory;
        Player player;
        Storage storage;

        public int Index { get; private set; }

        public Status MediatekaStatus { get; private set; }
        
        public Mediateka()
        {
            playerfactory = new PlayerFactory();
            storage = new Storage();
            player = new Player();
            MediatekaStatus = Status.Idle;
            Index = 0;
        }
        public Status Play(int id)
        {
            try
            {

                File file = storage.FindById(id);
                player = playerfactory.ReturnPlayer(file);
                player.Play(file);
                MediatekaStatus = Status.Play;
                return MediatekaStatus;
            }
            catch (Exception e)
            {
                MediatekaStatus = Status.Error;
                return MediatekaStatus;
            }
        }
        public Status PlayPrevious()
        {
            if(Index != 0) { Play(Index - 1); }
            MediatekaStatus = Status.Play;
            return MediatekaStatus;
        }
        public Status PlayNext()
        {
            Play(Index + 1);
            return MediatekaStatus;
        }
        public Status Stop()
        {
            player.Stop();
            return MediatekaStatus;
        }
    }
}
