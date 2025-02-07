using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlas
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;  //Adattagok
		private string mufaj;
		private bool megjelent;

		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)  //Konstruktor (itt minden tag)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}

		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;      //Konstruktor (csak 2 tag)
			hosszPercekben = 120;
			mufaj = "ismeretlen";
			megjelent = false;
		}

		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }  //Propertik
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }



		public void Jatszas()
		{
			if (this.Megjelent)
			{
                Console.WriteLine("A film elkezdődött.");
            }
			else
			{
                Console.WriteLine("A film nem kezdődött el.");
            }
		}

		public void MufajModositas(string ujMufaj)
		{
			Mufaj = ujMufaj;
		}

		public void HosszNovelese(int percek)
		{
			HosszPercekben += percek;
		}

		public override string? ToString()   //Jobb klikk, quick action 
		{
			return $"A film címe: {this.Cim}, rendezője: {this.Rendezo}, Hossza(percben): {this.HosszPercekben}, műfaja: {this.Mufaj} és hogy megjelent-e: {this.Megjelent}";
		}
	}




}
