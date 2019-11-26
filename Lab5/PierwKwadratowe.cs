using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class PierwKwadratowe
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        private double delta { get; set; }
        private double x1 { get; set; }
        private double x2 { get; set; }



        public void Wczytaj()
        {
            start:
            Console.WriteLine("Podaj a");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Podaj a != 0");
                goto start;
            }

            Console.WriteLine("Podaj b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c");
            c = int.Parse(Console.ReadLine());

        }

        public void Oblicz()
        {
            delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                x2 = (-b + Math.Sqrt(delta)) / 2 * a;               
            }

            else if (delta == 0)
            {              
                x1 = -b / 2 * a;              
            }
            else
            {              
            }
        }

        public void Wyswietl()
        {

            if (delta > 0)
            {
                Console.WriteLine($"Pierwiastki równania kwadratowego wynoszą {Math.Round(x1, 2)} i {Math.Round(x2, 2)}");
            }
            else if (delta == 0)   
            {
                Console.WriteLine($"Pierwiastek równania kwadratowego wynosi {Math.Round(x1, 2)}");
            }
            else
            {
                Console.WriteLine("Nie ma pierwiastków");
            }
            Console.ReadKey();
        }
    }
}
