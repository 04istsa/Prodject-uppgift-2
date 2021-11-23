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

            string filnamn = @"c:\Temp\Annteckningar.txt";
            
            int menyVal = int.Parse(Console.ReadLine());
            string[] songs = new string[5];
            // string val = Console.ReadLine();
            // string filnamn = Console.ReadLine();
            

            switch (menyVal)
            {
                case 1:
                    Console.WriteLine("Skriv in fem låtar");
                    for (int i = 0; i < 5; i++) {
                        songs[i] = Console.ReadLine();
                    
                    
                    }
                    File.WriteAllLines(filnamn, songs);
                    break;
                case 2:
                    Console.WriteLine("Skriv in en låt som ska skrivas in/över");
                    string rad = Console.ReadLine();
                   //File.WriteAllText(filnamn, rad);
                    Console.WriteLine("Låten är sparad i filen");


                    break;
                case 3:
                    Console.WriteLine("Sök efter en låt");
                    string sök = Console.ReadLine();
                        
                    for (int i = 0; i < songs.Length; i++) {
                        if (songs[i].Contains(sök))
                        {
                            Console.WriteLine($"{songs[i]}");
                        }
                        else
                        {
                            Console.WriteLine("Låten du söker finns inte");
                        }
                        
                    }
                    break;
                    
                    
            }

           
            
        }
    }
}
