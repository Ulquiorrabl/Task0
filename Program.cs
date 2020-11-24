using System;
using Task0.MediatekaStructure.MediatekaImplementation;

namespace Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediateka mediateka = new Mediateka();
            mediateka.Play(0);
            mediateka.PlayNext();
        }
    }
}
