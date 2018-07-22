using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalklulatorKonsolowy
{
    class Program
    {
        static void Main(string[] args)
        {



            do
            {


                Console.WriteLine("Co chcesz policzyć?");
                Console.WriteLine($"{(int)Działania.Dodawanie}) Dodawanie");
                Console.WriteLine($"{(int)Działania.Odejmowanie}) Odejmowanie");
                Console.WriteLine($"{(int)Działania.Mnożenie}) Mnożenie");
                Console.WriteLine($"{(int)Działania.Dzielenie}) Dzielenie");
                Kalkulator();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            void Kalkulator() { 
                var key = Console.ReadKey();
                var keyChar = int.Parse(key.KeyChar.ToString());
                var działanie = (Działania)keyChar;
                Console.WriteLine($"Twoje działanie to {działanie} ");

                switch (działanie)
                {
                    case Działania.Dodawanie: {
                            var a = PobierzPierwsza();
                            var b = PobierzDruga();
                            Dodawanie(a,b);
                            break;
                        }
                    case Działania.Odejmowanie: {
                            var a = PobierzPierwsza();
                            var b = PobierzDruga();
                            Odejmowanie(a,b);
                            break; }
                    case Działania.Mnożenie: {
                            var a = PobierzPierwsza();
                            var b = PobierzDruga();
                            Mnożenie(a,b);
                            break; }
                    case Działania.Dzielenie: {
                            var a = PobierzPierwsza();
                            var b = PobierzDruga();
                            Dzielenie(a,b);
                            break; }
                }

                int PobierzPierwsza()
                {
                    Console.WriteLine("Podaj pierwszą liczbę");
                    var first = Console.ReadLine();
                    var firstInt = int.Parse(first);
                    return firstInt;
                }

                int PobierzDruga()
                {
                    Console.WriteLine("Podaj drugą liczbę");
                    var second = Console.ReadLine();
                    var secondInt = int.Parse(second);
                    return secondInt;
                }

                void Dodawanie(int a, int b)
                {
                    Console.WriteLine("Wynik dodawania to: "+(a+b));
                }

                void Odejmowanie(int a, int b)
                {
                    Console.WriteLine("Wynik odejmowania to: " + (a - b));
                }

                void Mnożenie(int a, int b)
                {
                    Console.WriteLine("Wynik mnożenia to: " + (a * b));
                }

                void Dzielenie(int a, int b)
                {
                    if (b != 0) {
                        Console.WriteLine("Wynik dzielenia to: " + (a / b));
                    } else
                    {
                        Console.WriteLine("Cholero nie dziel przez zero!");
                    }
                
                }
                Console.WriteLine("Jeśli chcesz coś policzyć wciśnij dowolny klawisz");
                Console.WriteLine("W przeciwnym razie kliknij Escape");
            }

            Console.WriteLine();
            Console.ReadKey();
        }

    

        public enum Działania
        {
            Dodawanie = 1,
            Odejmowanie = 2,
            Mnożenie = 3,
            Dzielenie =4
        }
    }
}
