using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1. Sprawdź czy liczba jest parzysta");
                Console.WriteLine("2. Liczby parzyste");

                var input = Console.ReadLine();

                switch (int.Parse(input))
                {
                    case 1:
                        {
                            DisplayNumberIsEven();
                            break;
                        }
                    case 2:
                        break;

                    case 0: return;
                }
            }
        }

        static void DisplayNumberIsEven()
        {
            Console.WriteLine("Podaj liczbę");

            var input = Console.ReadLine();

            /*if (int.Parse(input) % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }*/

            Console.WriteLine("Liczba jest (0)", NumberIsEven(int.Parse(input)) ? "parzysta" : "nieparzysta" ); 
        }

        static bool NumberIsEven(int number)
        {
            return number % 2 == 0;
        }

        //zad 2
        static void ParzysteWypisz(int n)
        {
            for(int i = 0; i<n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i, " ");
                }
            }
        }


        //zad 4
        static void Silnia(int n)
        {
            int wynik = 1;

        }

        //zad 5
        static void Game() //zalacz biblioteke random!!
        {
            var random = new Random();
            var number = random.Next(1, 101);//1-100

            int count = 0;
            int shoot;

            do
            {
                count++;
                Console.WriteLine("podaj liczbe");
                var input = Console.ReadLine();
                shoot = int.Parse(input);

            }
            while (shoot != number);

            Console.WriteLine("zgadłeś za ", count, " razem");
            Console.WriteLine($"zgadłeś za { count} razem");
        }

        //zad 6
        static void MetryNaCenty()
        {
            Console.WriteLine("Podaj jednostkę");
            int liczba = 

        }
    }
}
