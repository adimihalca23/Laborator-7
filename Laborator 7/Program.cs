using Laborator_7.Exercitiu_1;
using Laborator_7.Exercitiu_2;
using System;

namespace Laborator_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex2();
        }

        static void Ex1()
        {
            Carte carte1 = new Carte(1, TipCarte.InimaRosie);
            Carte carte2 = new Carte(2, TipCarte.InimaRosie);
            Carte carte3 = new Carte(3, TipCarte.InimaRosie);
            Carte carte4 = new Carte(4, TipCarte.InimaRosie);
            Carte carte5 = new Carte(5, TipCarte.InimaRosie);

            Carte[] carti1 = new Carte[5];
            carti1[0] = carte1;
            carti1[1] = carte2;
            carti1[2] = carte3;
            carti1[3] = carte4;
            carti1[4] = carte5;
            ManaPoker manaPoker1 = new ManaPoker(carti1);

            Carte carte6 = new Carte(1, TipCarte.InimaNeagra);
            Carte carte7 = new Carte(2, TipCarte.InimaNeagra);
            Carte carte8 = new Carte(3, TipCarte.InimaNeagra);
            Carte carte9 = new Carte(4, TipCarte.InimaNeagra);
            Carte carte10 = new Carte(5, TipCarte.InimaNeagra);

            Carte[] carti2 = new Carte[5];
            carti2[0] = carte6;
            carti2[1] = carte7;
            carti2[2] = carte8;
            carti2[3] = carte9;
            carti2[4] = carte10;
            ManaPoker manaPoker2 = new ManaPoker(carti2);

            Carte carte11 = new Carte(10, TipCarte.Trifoi);
            Carte carte12 = new Carte(10, TipCarte.Romb);
            Carte carte13 = new Carte(10, TipCarte.InimaRosie);
            Carte carte14 = new Carte(10, TipCarte.InimaRosie);
            Carte carte15 = new Carte(1, TipCarte.InimaNeagra);

            Carte[] carti3 = new Carte[5];
            carti3[0] = carte11;
            carti3[1] = carte12;
            carti3[2] = carte13;
            carti3[3] = carte14;
            carti3[4] = carte15;
            ManaPoker manaPoker3 = new ManaPoker(carti3);

            Carte carte16 = new Carte(1, TipCarte.InimaRosie);
            Carte carte17 = new Carte(1, TipCarte.Trifoi);
            Carte carte18 = new Carte(1, TipCarte.Romb);
            Carte carte19 = new Carte(1, TipCarte.InimaRosie);
            Carte carte20 = new Carte(15, TipCarte.Trifoi);

            Carte[] carti4 = new Carte[5];
            carti4[0] = carte16;
            carti4[1] = carte17;
            carti4[2] = carte18;
            carti4[3] = carte19;
            carti4[4] = carte20;
            ManaPoker manaPoker4 = new ManaPoker(carti4);

            manaPoker1.TiparesteManaPoker();

            manaPoker1.TipManaPoker();
            manaPoker2.TipManaPoker();
            manaPoker3.TipManaPoker();
            manaPoker4.TipManaPoker();
        }


        static void Ex2()
        {
            ContBancar contBancar = new ContBancar(TipCont.Curent);
            contBancar.Depunere(258.7);
            contBancar.InterogareSold();

            contBancar.Retragere(54.3);
            contBancar.InterogareSold();

            contBancar.RecalculareSold(5);
            contBancar.InterogareSold();
        }
    }
}
