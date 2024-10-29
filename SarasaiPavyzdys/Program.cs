using System;

namespace SarasaiPavyzdys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> sveikiejiSkaiciai = new List<int>();
            Console.WriteLine("Kiek skaiciu noresite ivesti: ");
            int kiekis = int.Parse(Console.ReadLine());

            for(int i = 0; i < kiekis; i++)
            {
                Console.WriteLine($"Iveskite {i+1} skaiciu: ");
                sveikiejiSkaiciai.Add(int.Parse(Console.ReadLine()));
            }
            List<int> kitiSveikiejiSkaiciai = new List<int>();
            kitiSveikiejiSkaiciai.Add(5);
            kitiSveikiejiSkaiciai.Add(8);
            kitiSveikiejiSkaiciai.Add(19);


            sveikiejiSkaiciai.AddRange(kitiSveikiejiSkaiciai);
            sveikiejiSkaiciai.Remove(8);
            sveikiejiSkaiciai.Insert(1, -99);
            if(sveikiejiSkaiciai.Contains(-128))
            {
                Console.WriteLine("-128 yra sarase");
            }
            else
            {
                Console.WriteLine("-128 nera sarase");
            }
            
            int index = sveikiejiSkaiciai.IndexOf(19);

            foreach(int skaicius in sveikiejiSkaiciai)
            {
                Console.WriteLine(skaicius);
            }


        }
    }
}