using System;
using System.Collections.Generic;
using System.Text;
using Task0.FileStructure;

namespace Task0.MediatekaStructure
{
    interface IMediateka
    {
        Enum Play(int id);
        Enum PlayPrevious();
        Enum PlayNext();
        Enum Stop();
    }
}
