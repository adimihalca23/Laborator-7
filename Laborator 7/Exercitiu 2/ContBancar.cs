using System;

namespace Laborator_7.Exercitiu_2
{
    class ContBancar
    {
        public TipCont TipCont { get; set; }
        public double Sold { get; set; }

        public ContBancar(TipCont TipCont)
        {
            this.TipCont = TipCont;
            Sold = 0.00;
        }

        /// <summary>
        /// Afiseaza soldul curent in consola.
        /// </summary>
        public void InterogareSold()
        {
            Console.WriteLine($"Soldul contului este de: {Sold} RON.");
        }

        /// <summary>
        /// Adauga suma la valoarea soldului curent
        /// </summary>
        /// <param name="suma"></param>
        public void Depunere(double suma)
        {
            if(suma <= 0)
            {
                throw new Exception("Suma depusa trebuie sa fie mai mare decat 0!!");
            }
            else
            {
                Sold += suma;
            }
        }

        /// <summary>
        /// Scade suma din valoarea soldului curent
        /// </summary>
        /// <param name="suma"></param>
        public void Retragere(double suma)
        {
            if (suma > Sold)
            {
                throw new Exception("Suma extrasa depaseste valoarea soldului curent.");
            }
            else
            {
                Sold -= suma;
            }
        }

        /// <summary>
        /// Calculeaza valoarea dobanzii din soldul curent pe care o adauga la soldul curent.
        /// </summary>
        /// <param name="dobanda"></param>
        public void RecalculareSold(double dobanda)
        {
            double valoareDobanda = Sold * dobanda / 100;
            Sold += valoareDobanda;
        }
    }
}
