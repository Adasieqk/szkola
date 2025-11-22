namespace _02___klasa_produkt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produkt produkt1 = new Produkt(0, "sok");
            Produkt produkt2 = new Produkt(1, "chleb");
            produkt1.Cena = 3;
            produkt2.Cena = 6;

            produkt1.OpiszProdukt();
            produkt2.OpiszProdukt();

            Console.WriteLine(Produkt.LiczbaProduktow);

            Console.ReadKey();
        }
    }

    class Produkt
    {
        private int numerID;
        private string nazwa;
        private double cena;
        public static int LiczbaProduktow = 0;

        public double Cena
        {
            get
            {
                return cena;
            }
            set
            {
                cena = value;
            }
        }

        public Produkt()
        {
            numerID = 0;
            cena = 0;
            nazwa = "";
            LiczbaProduktow++;
        }

        public Produkt(int numerID, string nazwa)
        {
            this.numerID = numerID;
            this.nazwa = nazwa;
            this.cena = 0;
            LiczbaProduktow++;
        }

        public Produkt(Produkt inny)
        {
            this.numerID = inny.numerID;
            this.nazwa = inny.nazwa;
            LiczbaProduktow++;
            this.cena = 0;
        }

        public void OpiszProdukt()
        {
            Console.WriteLine(string.IsNullOrEmpty(nazwa) ? "Produkt nieznany" : $"Produkt: {nazwa}, ID: {numerID}, cena: {cena} PLN");
        }

    }
}