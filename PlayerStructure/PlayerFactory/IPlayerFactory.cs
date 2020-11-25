using System;
using System.Collections.Generic;
using System.Text;
using Task0.FileStructure;
using Task0.PlayerStructure.PlayerImplementation;

namespace Task0.PlayerStructure.PlayerFactory
{
    interface IPlayerFactory
    {
        Player ReturnPlayer(File file);
    }
}
