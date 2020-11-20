using System;
using System.Collections.Generic;
using System.Text;
using Task0.Files;

namespace Task0.Storage
{
    interface IStorage
    {
        void Save(File file);

        void Delete(File file);

        File Find(string name);

    }
}
