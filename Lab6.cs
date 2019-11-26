namespace Lab6
{
    class Lab6
    {
        static void Main(string[] args)
        {
            Lparzyste();
            //SzczesliwyNumerek();
            //MinMax();
        }


        public static void Lparzyste()
        {
            int l1, l2, x1, x2;
            Console.WriteLine("Podaj dwie liczby:");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());

            x1 = (l1 % 2 == 0) ? l1 : l1 + 1;
            x2 = (l2 % 2 == 0) ? l2 : l2 - 1;
            for (int i = x1; i < x2; i += 2)
            {
                Console.WriteLine($"Liczba parzysta: {i}");
            }

            /*
            for (int i = l1; i < l2; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"Liczba parzysta: {i}");
                }
                else
                {
                    continue;
                }
            }
            */
            Console.ReadKey();
        }
        public static void SzczesliwyNumerek()
        {
            Random rand = new Random();
            int z = rand.Next(9) + 1;
            int proba = 0;
            Console.WriteLine(z);

            do
            {
                Console.WriteLine("Podaj numer: ");
                int c = int.Parse(Console.ReadLine());
                proba++;


                if (proba >= 4)
                {
                    Console.WriteLine("Niestety do czterech razy sztuka");
                    Console.WriteLine("Gramy dalej (t/n)?");
                    string a = Console.ReadLine();
                    if (a == "t")
                    {
                        SzczesliwyNumerek();
                    }
                    else
                    {
                        //Environment.Exit(1);
                         break;
                    }                   
                }

                else if (c != z)
                {
                    Console.WriteLine("Sprobuj jeszcze raz");                 
                }               
                else
                {
                    Console.WriteLine($"Brawo, zgadles liczbe {z} za {proba} razem");
                    Console.ReadKey();

                     break;
                }
            } while (true);

        }
        public static void MinMax()
        {
            int liczba, max = 0, imax = 0, min = 20, imin = 0;
            bool isEnd = false;


            while (!isEnd)
            {
                Console.Write("Podaj liczbę z przedziału <0, 20> (-1 kończy program): ");
                liczba = int.Parse(Console.ReadLine());

                if (liczba == -1)
                {
                    isEnd = true;
                }
                else if (liczba < 0 || liczba > 20)
                {
                    Console.Write("Podaj liczbę z przedziału <0, 20>: ");
                    liczba = int.Parse(Console.ReadLine());

                }

                else if (liczba > max && liczba <= 20)
                {
                    imax = 0;
                    imax++;
                    max = liczba;
                }
                else if (liczba == max)
                {
                    imax++;
                }
                if (liczba < min && liczba >= 0)
                {
                    imin = 0;
                    imin++;
                    min = liczba;
                }
                else if (liczba == min)
                {
                    imin++;
                }

            }
            Console.WriteLine($"Maksimum równe {max}, liczba powtórzeń {imax}");
            Console.WriteLine($"Minimum równe {min}, liczba powtórzeń {imin}");
            Console.ReadKey();


        }

    }


}
