using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby:");

            int wynik = 0;
            do
            {
                int liczba = int.Parse(Console.ReadLine());
                if (liczba == 0) //exit
                    break;
                else
                { wynik += liczba; } //sum

            } while (true);
            Console.WriteLine("Suma wprowadzonych liczb to {0}", wynik);
        }
    }
}
