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
            Console.WriteLine("3. Sök efter en låt");

            string filnamn = @"c:\Temp\Annteckningar.txt";
            
            int menyVal = int.Parse(Console.ReadLine());
            string[] songs = new string[5];
            // string val = Console.ReadLine();
            // string filnamn = Console.ReadLine();
            if (File.Exists(filnamn))
            {
                songs = File.ReadAllLines(filnamn);

            }
            else
            {
                songs = new string[5];
                for (int i = 0; i < songs.Length; i++)
                {
                    songs[i] = "tom";
                }
                File.WriteAllLines(filnamn, songs);
            }



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
                    string sök = Console.ReadLine().ToLower();
                   
                    int finns = 0;  
                    for (int i = 0; i < songs.Length; i++) {
                        if (songs[i].ToLower().Contains(sök))
                        {
                            Console.WriteLine($"Låten {songs[i]} finns i spel listan");
                            finns++;
                        }
                       
                       }
                    if (finns == 0)
                    {
                        Console.WriteLine("Låten finns inte");
                    }
                    else
                    {
                        Console.WriteLine($"Det finns {finns} låtar");
                    }

                    break;
                    
                    
            }

           
            
        }
    }
}
