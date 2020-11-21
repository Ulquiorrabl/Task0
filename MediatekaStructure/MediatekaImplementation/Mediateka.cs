using System;
using System.Collections.Generic;
using System.Text;
using Task0.Player.PlayerFactory.PlayerFactoryImplementation;
using Task0.FileStructure;
using Task0.Storage.StorageImplementation;

namespace Task0.Mediateka.MediatekaImplementation
{
    class Mediateka : IMediateka
    {
        PlayerFactory playerfactory;
        
        public void Start()
        {
            playerfactory = new PlayerFactory();
        }
        public void Play(File file)
        {
            playerfactory.Play(file);
        }
        public void PlayPrevious()
        {
            
        }
        public void PlayNext()
        {

        }
        public void Stop()
        {

        }
    }
}
