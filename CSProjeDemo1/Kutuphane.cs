using System;
namespace CSProjeDemo1
{
	public class Kutuphane
	{
		private List<Kitap> kitaplar;
		private List<IUye> uyeler;

		public Kutuphane()
		{
			kitaplar = new List<Kitap>();
			uyeler = new List<IUye>();
		}

		public void KitapEkle(Kitap kitap)
		{
			kitaplar.Add(kitap);
			Console.WriteLine($"{kitap.Baslik} adlı kitap kütüphaneye eklendi.");
		}

		public void UyeEkle(IUye uye)
		{
			uyeler.Add(uye);
			Console.WriteLine($"{uye.Ad} {uye.Soyad} adlı üye kütüphaneye eklendi.");
		}

		public void KitaplariGoruntule()
		{
			Console.WriteLine("Kütüphanedeki Kitaplar:");
			foreach (var kitap in kitaplar)
			{
				Console.WriteLine($"- {kitap.Baslik} ({kitap.KitapTuru()}), Durum: {kitap.Durum}");
			}
		}

		public void UyeleriGoruntule()
		{
			Console.WriteLine("Kütüphane Üyeleri:");
			foreach (var uye in uyeler)
			{
				Console.WriteLine($"- {uye.Ad} {uye.Soyad} ({uye.UyeNo})");
			}
		}
	}
}

