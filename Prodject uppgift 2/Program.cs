using System;
using System.IO;
namespace Prodject_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Annvändaren ska kunna ändra låtar i topp listan

            // Annvändaren ska kunna söka efter låtar i topplistan
            
            //HTest dfoi

            Console.WriteLine("1. Ändra eller lägg till låtar i topplistan");
            int menyVal = 1;
            string[] songs = new string[20];
           // string val = Console.ReadLine();
           // string filnamn = Console.ReadLine();
            
            switch (menyVal)
            {
                case 1:
                    for (int i = 0; i < 20; i++) {
                        songs[i] = Console.ReadLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Skriv in en låt som ska skrivas in/över");
                    string rad = Console.ReadLine();
                   // File.WriteAllText(filnamn, rad);
                    Console.WriteLine("Låten är sparad i filen");
                    break;
                    
            }

           
            
        }
    }
}
