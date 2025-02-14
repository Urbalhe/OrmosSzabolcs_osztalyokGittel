using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpGyakorlás
{
	internal class Kem
	{


		private string kodnev;
		private string orszag;
		private int veszelySzint;
		private int sikerEsely;

		public Kem(string kodnev, string orszag, int veszelySzint, int sikerEsej)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = veszelySzint;
			this.sikerEsely = sikerEsej;
		}

		public Kem(string kodnev, string orszag)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			veszelySzint = 5;
			sikerEsely = 50;
		}

		public string Kodnev { get => kodnev; set => kodnev = value; }
		public string Orszag { get => orszag; set => orszag = value; }
		public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
		public int SikerEsej { get => sikerEsely; set => sikerEsely = value; }

		public void KuldetesInditasa()
		{
			Console.WriteLine($"A küldetés elindult {this.Kodnev} számára");
		}
		public void VeszelySzintNovelese(int mennyiseg)
		{
			this.VeszelySzint += mennyiseg;
		}
		public void SikerEsejNovelese(int szazalek)
		{
			this.SikerEsej += szazalek;
		}






		public override string? ToString()
		{
			return $"{this.Kodnev}, {this.orszag}, {this.VeszelySzint}, {this.SikerEsej}";
		}
	}
}