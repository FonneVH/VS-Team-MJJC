using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    public class Speler
    {
        public int Score { get; set; }

            /// <summary>
            /// De plaatswaar de speler zich nu bevindt.
            /// </summary>
        public Plaats HuidigePlaats { get; set; }

            /// <summary>
            /// Bevat de voorwerpen die een speler bij zich heeft.
            /// Alleen verplaatsbare voorwwerpen kunnen in de rugzak steken.
            /// </summary>
        public List <Voorwerp> Rugzak { get; set; }

            /// <summary>
            /// Neem een voorwerp uit de rugzak en plaats het in de huidege ruimte 
            /// </summary>
            /// <param name="voorwerp">Het voorwerp om in de ruimte te leggen</param>
            /// <returns>of het gelukt is om het voorwerp in de ruimte te leggen </returns>

        public bool PlaatsVoorwerpenInRuimte (Voorwerp voorwerp)
        {
            //haal het voorwerpen uit de zak, plaats het in de ruimte.
            if (Rugzak.Contains(voorwerp))
            {
                Rugzak.Remove(voorwerp);
                HuidigePlaats.Voorwerpen.Add(voorwerp);
                return true;
            }
            return false;
        }
        public bool NeemVoorwerpUitRuimte(Voorwerp voorwerp)
        {
            // haal het voorwerp uit de ruimte, als het verplaatsbare is 
            // stop het in de rugzak
            int index = HuidigePlaats.Voorwerpen.IndexOf(voorwerp);
            if (index != -1)
            {
                Rugzak.Add(HuidigePlaats.Voorwerpen[index]);
                HuidigePlaats.Voorwerpen.RemoveAt(index);

            }
            return false;

        }


    }
}
