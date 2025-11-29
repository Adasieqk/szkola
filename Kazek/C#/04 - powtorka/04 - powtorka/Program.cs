namespace powtorka
{
     //ZADANIE 4

    class Program
    {
        static void Main(string[] args)
        {
            Samochod ford = new Samochod();
            ford.LiczbaKol = 4;
            ford.Jedz();
            ford.ZapalSwiatla();
            Console.WriteLine($"Liczba kol: {ford.LiczbaKol}");
        }
    }

    class Pojazd
    {
        public int LiczbaKol;
        public void Jedz()
        {
            Console.WriteLine("Pojazd jedzie");
        }
    }

    class Samochod : Pojazd
    {
        public void ZapalSwiatla()
        {
            Console.WriteLine("Swiatla zapalone");
        }
    }






    // ZADANIE 5

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Pracownik nigga = new Pracownik();
    //        nigga.Nazwisko = "Nigga";
    //        nigga.PrzedstawSie();

    //        Kierownik niggaPremium = new Kierownik();
    //        niggaPremium.Nazwisko = "Nigga Premium";
    //        niggaPremium.Dzial = "Cotton";
    //        niggaPremium.PrzedstawSie();
    //        Console.WriteLine($"Dział: {niggaPremium.Dzial}");
    //    }
    //}

    //class Pracownik
    //{
    //    public string Nazwisko;
    //    public void PrzedstawSie()
    //    {
    //        Console.WriteLine($"Jestem pracownikiem i nazywam się {Nazwisko}");
    //    }
    //}

    //class Kierownik : Pracownik
    //{
    //    public string Dzial;
    //}






    // ZADANIE 6

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Kolo kolo = new Kolo();
    //        kolo.Promien = 10;
    //        kolo.ObliczPole();
    //        Console.WriteLine();

    //        Kwadrat kwadrat = new Kwadrat();
    //        kwadrat.Bok = 10;
    //        kwadrat.ObliczPole();
    //    }
    //}

    //class Figura
    //{
    //    public double ObliczPole()
    //    {
    //        return 0;
    //    }
    //}

    //class Kolo : Figura
    //{
    //    public double Promien = 0;
    //    public double Pole = 0;
    //    public override double ObliczPole()
    //    {
    //        if (Promien <= 0)
    //        {
    //            Console.WriteLine("Wprowadz poprawny promien");
    //        }
    //        else
    //        {
    //            Pole = (Math.PI * Promien * Promien);
    //            Pole = Math.Round(Pole, 5);
    //            Console.WriteLine($"Pole koła: {Pole}");
    //        }
    //    }
    //}

    //class Kwadrat : Figura
    //{
    //    public double Bok = 0;
    //    public double Pole = 0;

    //    public override double ObliczPole()
    //    {
    //        if (Bok <= 0)
    //        {
    //            Console.WriteLine("Wprowadz poprawna dlugosc boku");
    //        }
    //        else
    //        {
    //            Pole = Bok * Bok;
    //            Pole = Math.Round(Pole, 5);
    //            Console.WriteLine($"Pole kwadratu: {Pole}");
    //        }
    //    }
    //}






    // ZADANIE 7

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Pracownik prawcownik = new Pracownik("Paweł", "Programista", 14);
    //        prawcownik.PrzedstawPracownika();
    //    }
    //}

    //class Osoba
    //{
    //    private string Pesel;
    //    protected int Wiek;
    //    public string Imie;

    //    public Osoba(int Wiek, string Imie)
    //    {
    //        this.Wiek = Wiek;
    //        this.Imie = Imie;
    //    }

    //    public void PrzedstawSie()
    //    {
    //        Console.WriteLine($"Imię: {Imie}" + (Wiek > 0 ? $", wiek: {Wiek}" : ""));
    //    }
    //}

    //class Pracownik : Osoba
    //{
    //    public string Stanowisko;

    //    public Pracownik(string imie, string stanowisko, int wiek) : base(wiek, imie)
    //    {
    //        this.Stanowisko = stanowisko;
    //    }

    //    public void PrzedstawPracownika()
    //    {
    //        Console.WriteLine($"Imię: {Imie}, stanowisko: {Stanowisko}, wiek: {Wiek}");
    //    }
    //}






    // ZADANIE 8

    //class Produkt
    //{
    //    public string Nazwa;
    //    public decimal Cena;
    //}

    //class Koszyk
    //{
    //    private Produkt[] produkty = new Produkt[100]; 
    //    private int liczbaProduktow = 0;

    //    public void DodajProdukt(Produkt p)
    //    {
    //        if (liczbaProduktow < produkty.Length)
    //        {
    //            produkty[liczbaProduktow] = p;
    //            liczbaProduktow++;
    //            Console.WriteLine($"Dodano do koszyka: {p.Nazwa}, cena: {p.Cena} zł");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Koszyk jest pełny!");
    //        }
    //    }

    //    public void PokazKoszyk()
    //    {
    //        if (liczbaProduktow == 0)
    //        {
    //            Console.WriteLine("Koszyk jest pusty.");
    //            return;
    //        }

    //        decimal suma = 0;
    //        Console.WriteLine("\nZawartość koszyka:");
    //        for (int i = 0; i < liczbaProduktow; i++)
    //        {
    //            Console.WriteLine($"- {produkty[i].Nazwa}, cena: {produkty[i].Cena} zł");
    //            suma += produkty[i].Cena;
    //        }
    //        Console.WriteLine($"Suma cen: {suma} zł");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Produkt chleb = new Produkt() { Nazwa = "Chleb", Cena = 4.50m };
    //        Produkt mleko = new Produkt() { Nazwa = "Mleko", Cena = 3.20m };
    //        Produkt maslo = new Produkt() { Nazwa = "Masło", Cena = 7.99m };

    //        Koszyk koszyk = new Koszyk();

    //        koszyk.DodajProdukt(chleb);
    //        koszyk.DodajProdukt(mleko);
    //        koszyk.DodajProdukt(maslo);

    //        koszyk.PokazKoszyk();

    //        Console.ReadLine();
    //    }
    //}

}
