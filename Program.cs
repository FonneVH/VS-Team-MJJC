using KamersModel;
using System;

namespace KamersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //maak spelomgeving aan
            //maak speler
            //plaats speler in spelomgeving
            //begin spel
            var spelomgeving = MaakSpelOmgevingAan();
            var speler = MaakSpeler();
            spelomgeving.VoegSpelerToe(speler);
            Speel(spelomgeving);
        }

        

        private static void Speel(Level spelomgeving)
        {
            string command = "";
            while(command !="stop")
            {
                
                switch(command)
                {
                    case "toon plaats":
                        // zoek de plaats waar de speler zich bevindt.
                        // geef de naam van die plaats 
                        foreach (var plaats in spelomgeving.Plaatsen)
                        {
                            if (plaats.Speler != null)
                            {
                                Console.WriteLine(plaats.Plaatsnaam);
                            }
                        }

                        break;
                    case "help":
                        break;
                    default:
                        Console.WriteLine("Mogelijke commando's");
                        Console.WriteLine("help : toon deze help");
                        Console.WriteLine(" toon plaats: geef de plaats waar de speler zich bevindt.");
                        break;
                }
                command = Console.ReadLine().Trim();
            }
            
        }

        private static Speler MaakSpeler()
        {
            var speler = new Speler();
            return speler;
        }

        private static Level MaakSpelOmgevingAan()
        {
            var plaats = new Plaats("Kortrijk");
            return new Level(plaats);
        }
       
    }
}
