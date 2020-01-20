using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EserciziLibrary;

namespace Esercizi
{
    class EserciziConsole
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            double d = 0;
            double inverso = 0;
            int max = 0;
            int min = 0;
            int n = 0;
            long fattoriale = 0;
            Console.Write("Inserisci un numero per il fattoriale: ");
            n = int.Parse(Console.ReadLine());
            fattoriale = Matematica.CalcolaFattoriale(n);
            Console.WriteLine($"Il fattoriale è {fattoriale}");

            Console.Write("Inserisci tre numeri è ti stampo il massimo: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Inserisci un numero: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Inserisci un numero: ");
            c = int.Parse(Console.ReadLine());
            max = Matematica.MaggioreTra(a, b, c);
            Console.WriteLine($"Il massimo è {max}");

            Console.Write("Inserisci tre numeri è ti stampo il minimo: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Inserisci un numero: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Inserisci un numero: ");
            c = int.Parse(Console.ReadLine());
            min = Matematica.MinoreTra(a, b, c);
            Console.WriteLine($"Il minimo è {min}");

            Console.Write("Inserisci un numero e ti stampo l'inverso ");
            d = double.Parse(Console.ReadLine());
            inverso = Matematica.Inverso(d);
            Console.WriteLine($"L'inverso è {inverso}");

            Console.ReadLine();
        }
    }
}
