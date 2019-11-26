using System;

namespace Lab4
{
    class Lab4
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5] { 2, 4, 6, 7, 12 };
            //temperatureConversion(40);
            //numberSum(15);
            //loadNumbers();
            //MultiplyArray(array1, 3);
            //PowerFunction(5, 3);
            //Factorial(4);
            
            Console.ReadKey();
        }

        

        private static void temperatureConversion(double temp)
        {
            Console.WriteLine($" {temp}F -> { (temp - 32) / 1.8}C");
        }

        private static void numberSum(int number)
        {
            int num = number;
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;

            }
            Console.WriteLine($"Suma cyfr {num} wynosi {sum}");
        }

        private static void loadNumbers()
        {
            int a, b, x;
            Console.WriteLine("Podaj liczby a, b, x");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            isNumberBetween(a, b, x);
        }

        private static void isNumberBetween(int a, int b, int x)
        {
            if (x > a || x < b)
            {
                Console.WriteLine("x znajduje sie w przedziale");

            }
            else
            {
                Console.WriteLine("x NIE znajduje sie w przedziale");
            }

        }

        private static void MultiplyArray(int[] array, int y)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= y;
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }

        private static void PowerFunction(int num, int pow)
        {
            int result = num;
            for (int i = 0; i < pow - 1; i++)
            {
                result *= num;
            }

            Console.WriteLine(result);
        }

        public static void Factorial(int n)
        {
            int suma = 1;
            for (int i = 1; i <= n; i++)
            {
                suma *= i;
            }
            Console.WriteLine(suma);


        }
    }
}
