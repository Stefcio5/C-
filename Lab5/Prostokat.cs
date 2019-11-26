using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Prostokat
    {
        public Prostokat(int dlugosc, int szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        private int dlugosc { get; set; }
        private int szerokosc { get; set; }

        private int Powierzchnia() => dlugosc * szerokosc;
        private int Obwod() => 2 * (dlugosc + szerokosc);

        public void Prezentuj()
        {
            Console.WriteLine("Pole powierzchni prostokąta wynosi: ", Powierzchnia());
            Console.WriteLine("Obwód prostokąta wynosi: ", Obwod());

        }
    }
}
