using System;
using System.Threading;
using System.IO;
using System.Text;
namespace Prodject_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
        

            // Annvändaren ska kunna ändra låtar i topp listan

            // Annvändaren ska kunna söka efter låtar i topplistan
            
            //HTest dfoi
            
            



            string filnamn = @"c:\Temp\Annteckningar2.txt";
            
            
            string[] songs;
            // string val = Console.ReadLine();
            // string filnamn = Console.ReadLine();
            if (File.Exists(filnamn))
            {
                songs = File.ReadAllLines(filnamn);

            }
            else
            {
                songs = new string[20];
                for (int i = 0; i < songs.Length; i++)
                {
                    songs[i] = "tom";
                }
                File.WriteAllLines(filnamn, songs);
            }
            int menyVal = 0;
           
            while (menyVal != 5) { 
            Console.WriteLine("1. Visa din topplista");
            Console.WriteLine("2. Skriva in låtar i topplistan");
            Console.WriteLine("3. Ändra låtar i topplistan");
            Console.WriteLine("4. Sök efter en låt");
            Console.WriteLine("5. Avsluta programmet!\n");
            
           menyVal = int.Parse(Console.ReadLine());

            switch (menyVal)
            {
                case 1:
                    if (File.Exists(filnamn))
                    {
                        // Skriver ut texten från filen
                        string filinnehåll = File.ReadAllText(filnamn);
                        Console.WriteLine("Här är filens innehåll:");
                        Console.WriteLine(filinnehåll);
                    }
                    break;

                case 2:
                    Console.WriteLine("Skriv in fem låtar");
                    for (int i = 0; i < 20; i++) {
                        songs[i] = Console.ReadLine();
                    
                    
                    }
                    File.WriteAllLines(filnamn, songs);
                    break;

                case 3:
                    Console.WriteLine("Vilken låt vill du ändra");
                    int låt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in en ny låt i topplistan");
                    songs[låt - 1] = Console.ReadLine();
                    File.WriteAllLines(filnamn, songs);
                    break;
               
                case 4:
                    Console.WriteLine("Sök efter en låt");
                    string sök = Console.ReadLine().ToLower();
                   
                    int finns = 0;  
                    for (int i = 0; i < songs.Length; i++) {
                        if (songs[i].ToLower().Contains(sök))
                        {
                            Console.WriteLine($"Låten {songs[i]} finns i spel listan på index {i}");
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
                case 5:
                    // Avslutar programmet
                    Console.WriteLine("Programmet avslutas");
                    Thread.Sleep(1000);
                    break;

                default:
                    // Om man inte skrev ett gilltigt alternativ
                    Console.WriteLine("Du skrev inte ett gilltigt alternativ, försök igen!");
                    break;


            }

           }
            
        }
    }
}
