using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpGyakorlás
{
	internal class Urhajo
	{
		private string nev;
		private int sebesseg;
		private int utaskapacitas;
		private int uzemanyagszint;

		public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagszint)
		{
			this.nev = nev;
			this.sebesseg = sebesseg;
			this.utaskapacitas = utaskapacitas;
			this.uzemanyagszint = uzemanyagszint;
		}

		public Urhajo(string nev, int utaskapacitas)
		{
			this.nev = nev;
			this.utaskapacitas = utaskapacitas;
			sebesseg = 0;
			uzemanyagszint = 100;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
		public int Uzemanyagszint { get => uzemanyagszint; set => uzemanyagszint = value; }




		public void Indulas()
		{
			this.Sebesseg += 100;
			this.Uzemanyagszint -= 10;
		}
		public void Tankolas(int mennyiseg)
		{
			this.uzemanyagszint += mennyiseg;
		}
		public void Landolas()
		{
			this.Sebesseg = 0;
		}










		public override string? ToString()
		{
			return $"{this.Nev}  Urhajo Sebessége : {this.Sebesseg}   ;{this.Utaskapacitas} ember fér el benne és {this.Uzemanyagszint} A tankja";
		}
	}
}
