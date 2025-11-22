using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Timers;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ZADANIE 1

            //int[] tablica = new int[5] { 5, 10, 15, 20, 25 };

            //foreach (int el in tablica)
            //{
            //    Console.WriteLine(el);
            //}





            //ZADANIE 2

            //int[] tablica = new int[5];

            //for(int i = 0; i < tablica.Length; i++)
            //{
            //    tablica [i] = i + 1;
            //}

            //foreach(int el in tablica)
            //{
            //    Console.WriteLine(el);
            //}





            //ZADANIE 3

            //int[] tab = new int[6] { 1, 2, 3, 4, 5, 6 };
            //int ileParzystych = 0;

            //foreach (int el in tab)
            //{
            //    if (el % 2 == 0)
            //    {
            //        ileParzystych++;
            //    }
            //}
            //Console.WriteLine(ileParzystych);





            //ZADANIE 4

            //int[] tab1 = new int[5];
            //int[] tab2 = new int[5];
            //int[] sumaTablic = new int[5];

            //Console.WriteLine("Podaj 5 liczb do tab1:");
            //for (int i = 0; i < tab1.Length; i++)
            //{
            //    Console.WriteLine($"Element {i + 1}: ");
            //    tab1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Podaj 5 liczb do tab2:");
            //for (int i = 0; i < tab2.Length; i++)
            //{
            //    Console.WriteLine($"Element {i + 1}: ");
            //    tab2[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < sumaTablic.Length; i++)
            //{
            //    sumaTablic[i] = tab1[i] + tab2[i];
            //}

            //void Wyswietl(int[] tablica)
            //{
            //    foreach (int el in tablica)
            //    {
            //        Console.WriteLine(el + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Wyswietl(tab1);
            //Wyswietl(tab2);
            //Wyswietl(sumaTablic);





            //ZADANIE 5

            //int[] tab = new int[5];
            //int suma = 0;
            //int srednia;

            //Console.WriteLine("Wprowadz 5 liczb calkowitych (oddziel enterem)");

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int el in tab)
            //{
            //    suma += el;
            //}

            //srednia = suma / tab.Length;
            //Console.WriteLine($"Srednia: {srednia}");





            //ZADANIE 6

            //int[] tab = new int[10];
            //Random rand = new Random();
            //int[] rev = new int[10];

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = rand.Next(1, 101);
            //}

            //foreach (int el in tab)
            //{
            //    Console.Write(el + " ");
            //}

            //Console.WriteLine();

            //int n = tab.Length / 2;
            //for (int i = 0; i < n; i++)
            //{
            //    int temp = tab[i];   
            //    rev[i] = tab[tab.Length - i - 1];
            //    tab[n - 1 - i] = temp;   
            //}

            //Console.WriteLine();





            // ZADANIE 7

            //int[] tab = new int[10];
            //Random rand = new Random();

            //int min = 100;
            //int max = 0;

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = rand.Next(1, 101);
            //}

            //foreach (int el in tab)
            //{
            //    if(el < min)
            //    {
            //        min = el;
            //    }
            //    else if(el > max)
            //    {
            //        max = el;
            //    }
            //    Console.Write(el + " ");
            //}

            //Console.WriteLine($"Max: {max}, Min: {min}");





            // ZADANIE 8                     // wthelly

            int[] tablica = new int[20];
            Random rand = new Random();
            int[] wystapienia = new int[21];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rand.Next(-10, 11);
            }

            Console.WriteLine("Wylosowane liczby:");

            foreach (var liczba in tablica)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();

            foreach (var liczba in tablica)
            {
                wystapienia[liczba + 10]++; 
            }

            Console.WriteLine("Wystąpienia:");

            for (int i = 0; i < wystapienia.Length; i++)
            {
                if (wystapienia[i] > 0)
                {
                    Console.WriteLine($"{i - 10} - {wystapienia[i]}");
                }
            }
        }
     }

}

