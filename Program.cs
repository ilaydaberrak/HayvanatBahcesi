
using System;
using System.Collections.Generic;

namespace HayvanatBahcesiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hayvan> hayvanlar = new List<Hayvan>
            {
                new At("Arap Atı", 500, 7),
                new Kaplan("Bengal Kaplanı", 150, 5),
                new Sican("Park Sıçanı", 0.5, 1)
            };

            foreach (var h in hayvanlar)
            {
                Console.WriteLine($"{h.TurAdi} - Yaş: {h.Yas}, Ağırlık: {h.Agirlik} kg");
                Console.WriteLine($"Dozaj: {h.GetDosage()}");
                Console.WriteLine($"Beslenme Programı: {h.GetFeedSchedule()}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
