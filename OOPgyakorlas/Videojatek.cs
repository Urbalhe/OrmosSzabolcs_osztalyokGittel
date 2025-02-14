using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpGyakorlás
{
	internal class Videojatek
	{
		private string nev;
		private int szint;
		private int eletero;
		private int ero;

		public Videojatek(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public Videojatek(string nev, int ero)
		{
			this.nev = nev;
			this.ero = ero;
			szint = 1;
			eletero = 100;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }




		public void Tamadas()
		{
			Console.WriteLine($"A  {this.Nev} támad {this.Ero}-vel");
		}
		public void Gyogyulas(int mennyiseg)
		{
			this.Eletero += mennyiseg;
			Console.WriteLine($"A {this.Nev} gyógyult {mennyiseg}-el");
		}
		public void SzintLepes()
		{
			this.Szint++;
			Console.WriteLine($"A {this.Nev} szintet lépett");
		}

		public override string? ToString()
		{
			return $" {this.Nev}  : {this.Szint} : {this.Eletero} : {this.Ero}";
		}
	}
}