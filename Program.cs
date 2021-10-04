using System;
using System.Collections.Generic;

namespace Elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); //A véletlen szám generálás elindítása
            Console.WriteLine("A 30 nap legmagasabb hőmérsékletének adatai:");
            List<int> homersekletek = new List<int>(); //A lista létrehozása
            int n; //Ennyi nap
            Console.Write("Mennyi nap adatai legyenek generálva: ");
            n = Convert.ToInt32(Console.ReadLine()); //Beolvasás
            for (int i = 0; i < n; i++) //n nap adatai lesznek generálva
            {
                int x = r.Next(25, 36); //A max. hőmérséklet határai 25°C-35°C
                homersekletek.Add(x); //A listához új elemet adunk
                Console.WriteLine($"{i+1}. nap maximum hőmérséklete: {x}°C");
            }
            //Mekkora volt az átlagos legmagasabb hőmérséklet?
            double atlag = 0; //Ebbe kerül az átlag
            for (int i = 0; i < n; i++) //A lista végigolvasása
            {
                atlag += homersekletek[i]; //Az elemek összeadása
            }
            /*atlag /= 30.0; //Az átlag kiszámítása*/
            atlag /= n * 1.0;
            Console.WriteLine($"Az átlagos legmagasabb hőmérséklet: {atlag:N2}°C");
            Console.ReadKey();
        }
    }
}
