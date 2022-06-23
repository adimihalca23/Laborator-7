using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_7.Exercitiu_1
{
    class Carte
    {
        public int Numar { get; set; }
        public TipCarte Tip { get; set; }

        public Carte(int numar, TipCarte tip)
        {
            if(numar <= 0 || numar > 14)
            {
                throw new ArgumentOutOfRangeException(nameof(numar), $"Numarul trebuie sa fie intre 1 si 14.");
            }
            this.Numar = numar;
            this.Tip = tip;
        }

        /// <summary>
        /// Afiseza in consola numarul si tipul cartii.
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine($"Numar carte: {Numar}");
            Console.WriteLine($"Tip carte: {Tip}");
        }
    }
}
