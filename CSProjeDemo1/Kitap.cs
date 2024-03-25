using System;
namespace CSProjeDemo1
{
	public abstract class Kitap
	{
		public string ISBN { get; set; }
		public string Baslik { get; set; }
		public string Yazar { get; set; }
		public int YayinYili { get; set; }
		public Durum Durum { get; set; }

		public Kitap(string isbn, string baslik, string yazar, int yayinYili)
		{
			ISBN = isbn;
			Baslik = baslik;
			Yazar = yazar;
			YayinYili = yayinYili;
			Durum = Durum.Mevcut;
		}

		public abstract string KitapTuru();
	}
}

