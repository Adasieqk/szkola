using System;

namespace ksiazki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ksiazka ksiazka1 = new Ksiazka("1234567890123456789012345678901234567890", "1234567890123456789012345678901234567890", true);
            Ksiazka ksiazka2 = new Ksiazka("tytul2", "autor2", true);

            ksiazka1.WyswietlInformacje();
            ksiazka1.Wypozycz();
            ksiazka1.Wypozycz();
            ksiazka1.Zwroc();
            ksiazka1.Zwroc();

            Console.WriteLine();
            Console.WriteLine();

            ksiazka2.WyswietlInformacje();
            ksiazka2.Wypozycz();
            ksiazka2.Wypozycz();
            ksiazka2.Zwroc();
            ksiazka2.Zwroc();

            Console.ReadKey();
        }
    }

    class Ksiazka
    {
        private string tytul;
        private string autor;
        private bool dostepnosc = true;

        public Ksiazka(string tytul, string autor, bool dostepnosc)
        {
            if(tytul.Length > 30)
            {
                this.tytul = tytul.Substring(0, 30);
            }
            else
            {
                this.tytul = tytul;
            }

            if (autor.Length > 20)
            {
                this.autor = autor.Substring(0, 20);
            }
            else
            {
                this.autor = autor;
            }

            this.dostepnosc = dostepnosc;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Tytuł: {tytul}, Autor: {autor}, Dostepnosc: { dostepnosc} ");
        }

        public void Wypozycz()
        {
            if (dostepnosc)
            {
                dostepnosc = false;
                Console.WriteLine("Ksiazka została wypożyczona");
            }
            else
            {
                Console.WriteLine("Książka jest już wypożyczona");
            }
        }

        public void Zwroc()
        {
            if (dostepnosc)
            {
                Console.WriteLine("Ksiązka jest dostępna");
            }
            else
            {
                dostepnosc = true;
                Console.WriteLine("Ksiązka została zwrócona");
            }
        }
    }
}
