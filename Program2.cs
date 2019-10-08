using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            trojkaPit();
            //tabliczkaMnozenia();
        }
            static void trojkaPit() {
                int a, b, c;
                Console.WriteLine("Podaj 3 liczby:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) {
                    Console.WriteLine("Prawda");

                }
                else
                {
                    Console.WriteLine("Falsz");
                }
            }

        static void tabliczkaMnozenia()
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(" ");
                int j = 0;
                for (j=1; j<=10; j++)
                {
                    Console.Write(" " + i * j + "");
                }
            }
            Console.ReadLine();
        }
        static void LiczbaPI()
        {

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Sqrt(Math.PI));
            Console.WriteLine();
        }
        static void ObjKuli()
        {
            double r, V;
            Console.WriteLine("Podaj r: ");
            r = double.Parse(Console.ReadLine());
            V = 4/3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine("Obj kuli o promieniu " + r + " wynosi " + V);
        }
        static void pierwRownKwadratowego()
        {
            double a1, b1, c1, x1, x2, delta;
            Console.WriteLine("Podaj a, b ,c rownania kwadratowego");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            c1 = double.Parse(Console.ReadLine());

            delta = Math.Pow(b1, 2) - 4 * a1 * c1;

            if (delta > 0)
            {
                x1 = (-b1 - Math.Sqrt(delta) / 2 * a1);
                x2 = (-b1 + Math.Sqrt(delta) / 2 * a1);

                Console.WriteLine("Pierwiastek x1 wynosi " + x1 + " Pierwiastek x2 wynosi " + x2);
            }
            else if (delta == 0)
            {
                x1 = -b1 / 2 * a1;
                Console.WriteLine("Pierwiastek wynosi " + x1);
            }
            else
            {
                Console.WriteLine("Nie ma pierwiastków");
            }
        }

        static void NiewiadomaX()
        {
            double A2, B2, x2;
            Console.WriteLine("Podaj A i B rownania Ax=B");
            A2 = double.Parse(Console.ReadLine());
            if(A2 == 0)
            {
                Console.WriteLine("A wynosi 0. Podaj inna liczbe");
                NiewiadomaX();
            }
            
            B2 = double.Parse(Console.ReadLine());

            x2 = B2 / A2;
            Console.WriteLine("Niewiadoma x wynosi " + x);

        }

        }
    }

