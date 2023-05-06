using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_T3_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasa klasa = new Klasa();
            Console.WriteLine("Czesc, jak masz na imie?");
            var Imie = klasa.Imie = Console.ReadLine();

            Console.WriteLine("Gdzie mieszkasz?");
            var Miejscowosc = klasa.Miejscowosc = Console.ReadLine();

            Console.WriteLine("W ktorym roku sie urodziles?");

            var dateOfBirth = int.Parse(Console.ReadLine());
            if(dateOfBirth > 1920 )
            {
                var wynik = 2023 - dateOfBirth;
            }
            else
            {
                Console.WriteLine("Niemozliwe!");
            }


            Console.WriteLine($"Masz na imie {Imie} i mieszkasz w {Miejscowosc} oraz masz {wynik} lat.");

        }
    }
}
