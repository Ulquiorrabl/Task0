using System;
using System.Collections.Generic;
using System.Text;
using Task0.FileStructure;

namespace Task0.Player.PlayerFactory
{
    interface IPlayerFactory
    {
        void Play(File file);
        void Stop();
    }
}
