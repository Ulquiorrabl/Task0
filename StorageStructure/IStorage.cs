using System;
using System.Collections.Generic;
using System.Text;
using Task0.FileStructure;

namespace Task0.StorageStructure
{
    interface IStorage
    {
        void Save(File file);

        void Delete(File file);

        File Find(string name);

        File FindById(int id);
    }
}
