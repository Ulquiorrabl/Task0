using System;

namespace Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            float size;
            File[] Mediateka = new File[10];
            for(int i = 0; i < Mediateka.Length; i++)
            {
                Mediateka[i] = new File("name", 0);
                Console.WriteLine("Input name and size:");
                name = Console.ReadLine();
                try
                {
                    size = float.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
