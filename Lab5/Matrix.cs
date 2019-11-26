using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Matrix
    {
        int[,] matrix;
        Random rand;

        public void Uruchom()
        {
            rand = new Random();
            matrix = new int[10, 10];
            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = rand.Next(0, 9);
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            
        }

        public void Wyswietl()
        {
            int suma = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {               
                Console.WriteLine(" ");
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (i == j)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.Write("{0} ", matrix[i, j]);
                    suma += matrix[i, j];
                }
            }
            Console.ResetColor();
            Console.WriteLine($"Suma liczb po przekątnej wynosi: {suma}");
            Console.ReadKey();           
            
        }
    }
}
