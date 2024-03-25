using System;
namespace CSProjeDemo1
{
	public class Uye:IUye
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public int UyeNo { get; set; }
		public List<Kitap> OduncKitaplar { get; set; }

		public Uye(string ad, string soyad, int uyeNo)
		{
			Ad = ad;
			Soyad = soyad;
			UyeNo = uyeNo;
			OduncKitaplar = new List<Kitap>();
		}

		public void KitapOduncAl(Kitap kitap)
		{
			if (kitap.Durum == Durum.Mevcut)
			{
				kitap.Durum = Durum.OduncVerildi;
				OduncKitaplar.Add(kitap);
				Console.WriteLine($"{kitap.Baslik} adlı kitap ödünç alındı.");
			}
			else
			{
				Console.WriteLine($"{kitap.Baslik} adlı kitap şu anda mevcut değil.");
			}
		}

		public void KitapIadeEt(Kitap kitap)
		{
			if (OduncKitaplar.Contains(kitap))
			{
				kitap.Durum = Durum.Mevcut;
				OduncKitaplar.Remove(kitap);
				Console.WriteLine($"{kitap.Baslik} adlı kitap iade edildi.");
			}
			else
			{
				Console.WriteLine($"{kitap.Baslik} adlı kitap zaten ödünçte değil.");
			}
		}
	}
}

