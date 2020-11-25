using System;
using System.Collections.Generic;
using System.Text;
using Task0.FileStructure;
using Task0.MediatekaStructure.StatusEnumerator;

namespace Task0.MediatekaStructure
{
    interface IMediateka
    {
        Status Play(int id);
        Status PlayPrevious();
        Status PlayNext();
        Status Stop();
    }
}
