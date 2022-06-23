using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7.Exercitiu_1
{
    class ManaPoker
    {
        public Carte[] carti;

        public ManaPoker(Carte[] carti)
        {
            this.carti = carti;
        }

        /// <summary>
        /// Afiseaza in consola descrierea tuturor cartilor din mana de poker(numar si tip).
        /// </summary>
        public void TiparesteManaPoker()
        {
            foreach(Carte carte in carti)
            {
                carte.Tipareste();
            }
        }

        /// <summary>
        /// Afiseaza in consola tipul mainii de poker.
        /// </summary>
        public void TipManaPoker()
        {
            if(TipRoyalFlush() == true)
            {
                Console.WriteLine("Royal Flush");
            }else if(TipStraightFlush() == true)
            {
                Console.WriteLine("Straight Flush");
            }else if(FourOfAKind() != 0)
            {
                Console.WriteLine($"Four of a kind : {FourOfAKind()}");
            }
            else
            {
                Console.WriteLine("Mana comuna.");
            }
        }

        private bool TipRoyalFlush()
        {
            bool royalFlush = true;

            foreach (Carte carte in carti)
            {
                if(carte.Tip != TipCarte.InimaNeagra)
                {
                    royalFlush = false;
                }
            }
            if(royalFlush == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TipStraightFlush()
        {
            bool straightFlush = true;

            foreach (Carte carte in carti)
            {
                if (carte.Tip != TipCarte.InimaRosie)
                {
                    straightFlush = false;
                }
            }

            if (straightFlush == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private int FourOfAKind()
        {
            for(int i = 0; i < carti.Length; i++)
            {
                Carte carteReferinta = carti[i];
                int numarCartiLaFel = 0;

                foreach (Carte carte in carti)
                {
                    if(carteReferinta.Numar == carte.Numar)
                    {
                        numarCartiLaFel++;
                    }
                }

                if(numarCartiLaFel == 4)
                {
                    return carteReferinta.Numar;
                }
            }

            return 0;
        }
    }
}
