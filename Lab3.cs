using System;

namespace Lab3
{
    class Lab3
    {
        static void Main(string[] args)
        {
            //sumaTablicy();
            //zapelnienieTablicy();
            //kopiowanieTablicy();
            tab2D();
        }

        public static void sumaTablicy()
        {
            int sumParzyste = 0, sumNieparzyste = 0;
            int[] tab = new int[100];
            for (int i = 0; i <= tab.Length - 1; i++)
            {
                tab[i] = i;
                Console.WriteLine(tab[i]);
            }

            for (int j = 0; j <= tab.Length - 1; j++)
            {
                if (tab[j] % 2 == 0)
                {
                    sumParzyste += tab[j];
                }
                else
                {
                    sumNieparzyste += tab[j];
                }
            }
            Console.WriteLine("Suma liczb parzystych: " + sumParzyste);
            Console.WriteLine("Suma liczb nieparzystych: " + sumNieparzyste);
            Console.ReadKey();
        }
        public static void zapelnienieTablicy()
        {
            int n;
            Console.WriteLine("Podaj wielkosc tablicy: ");
            n = int.Parse(Console.ReadLine());
            int[] tab1 = new int[n];
            for (int i = 0; i <= tab1.Length - 1; i++)
            {
                Console.WriteLine("Podaj wartosc " + i + " tablicy: ");
                tab1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Tablica uzytkownika: ");
            for (int k = 0; k <= tab1.Length - 1; k++)
            {
                Console.WriteLine(tab1[k]);
            }
            Console.ReadKey();
        }
        public static void kopiowanieTablicy()
        {
            int[] tab1 = new int[] { 1, 4, 5, 6, 8, 9, 10, 11, 14, 15 };
            int[] tab2 = new int[10];

            for (int i = 0; i <= tab1.Length - 1; i++)
            {
                if (tab1[i] % 2 == 0)
                {
                    tab2[i] = tab1[i];
                }
            }
            for (int j = 0; j <= tab2.Length - 1; j++)
            {
                Console.WriteLine(tab2[j]);
            }
            Console.ReadKey();
        }
        public static void tab2D()
        {
            Random rnd = new Random();
            int[,] tab2d = new int[5, 5];
            for (int i = 0; i <= tab2d.Length - 1; i++)
            {
                for (int j = 0; j <= tab2d.Length - 1; j++)
                {
                    tab2d[i, j] = rnd.Next(1, 10);
                }
            }
            Console.WriteLine(tab2d);
            Console.ReadKey();


        }
    }
}
