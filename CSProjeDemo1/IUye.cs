using System;
namespace CSProjeDemo1
{
	public interface IUye
	{
		string Ad { get; set; }
		string Soyad { get; set; }
		int UyeNo { get; set; }
		List<Kitap> OduncKitaplar { get; set; }

		void KitapOduncAl(Kitap kitap);
		void KitapIadeEt(Kitap kitap);
	}
}

