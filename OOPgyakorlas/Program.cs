﻿using OOpGyakorlás;

namespace OOPgyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{

            Console.WriteLine("1.Feladat");
            Konyv konyv1 = new("A kis herceg", "Antoine", 1943, 96, 2500);
			Konyv konyv2 = new("Ez még készül", "Én");

			Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(1000);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");




            Film film1 = new("Nagymenők", "Scorsese", 180, "Gengszterfilm", true);

			Film film2 = new("Keresztapa", "Francis Ford Copolla");

			Console.WriteLine(film1.ToString());
            Console.WriteLine("");
			film1.HosszNovelese(20);            //Itt növeltem a film perceit
			Console.WriteLine(film1.ToString());

            Console.WriteLine("");

            Console.WriteLine(film2.ToString());
            Console.WriteLine("");
			film2.MufajModositas("Kultuszfilm"); //Itt módosítottam a műfajaát
			Console.WriteLine(film2.ToString());

			Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("");



			Videojatek jatek1 = new("SuperMario", 100);
            Console.WriteLine(jatek1);

			Videojatek jatek2 = new("Franklin", 200, 100, 50);
			Console.WriteLine(jatek2);

			Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("");

			Urhajo urhajo1 = new("MilleniumFalcon", 100, 100, 100);
            Console.WriteLine(urhajo1);


            Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("");

			Kem kem1 = new("007JamesBond", "NagyBrittania", 10, 80);
            Console.WriteLine(kem1);


        }


	}
}
