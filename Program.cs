using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ObliczPole();
             Console.WriteLine("Podaj dwie liczby");
             double a = Double.Parse(Console.ReadLine());
             double b = Double.Parse(Console.ReadLine());
             Kalkulator(a,b);
             

             
            Console.WriteLine("Podaj dlugosc ciagu");
            int ciag = int.Parse(Console.ReadLine());
            Console.WriteLine(ciag + " wyraz ciagu Fibonnaciego wynosi " + Fibbonacci(ciag));
            Console.ReadKey();
            */
            Console.WriteLine("Podaj ilosc liczb:");
            int silnia = int.Parse(Console.ReadLine());
            Console.WriteLine("Silnia " + silnia + " liczb wynosi " + Silnia(silnia));
            Console.ReadKey();
        }

        static void ObliczPole()
        {
            int a, b, pole;

            Console.WriteLine("Podaj bok a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b");
            b = int.Parse(Console.ReadLine());
            pole = a * b;
            Console.WriteLine("Pole wynosi: " + pole);
            Console.ReadLine();
            
        }
        static void Kalkulator(double a, double b)
        {
            double dodawanie, odejmowanie, mnozenie, dzielenie;
            dodawanie = a + b;
            odejmowanie = a - b;
            mnozenie = a * b;
            dzielenie = a / b;
            Console.WriteLine("Wynik dodawania liczby " + a + " i " + b + " : " + dodawanie);
            Console.WriteLine("Wynik odejmowania liczby " + a + " i " + b + " : " + odejmowanie);
            Console.WriteLine("Wynik mnozenia liczby " + a + " i " + b + " : " + mnozenie);
            Console.WriteLine("Wynik dzielenia liczby " + a + " i " + b + " : " + dzielenie);
            Console.ReadLine();
        }
        public static int Fibbonacci(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibbonacci(n - 1) + Fibbonacci(n - 2);
            }
            
        }
        public static int Silnia(int n)
        {
            int suma = 1;
            for (int i = 1; i <= n; i++)
            {
                suma *= i;
            }
            return suma;
        }
    }
}
