using denemeIki;


List<Musteri> musteriler = new List<Musteri>();
MusteriManager musteriManager = new MusteriManager();

musteriManager.Add(new Musteri(1,"Ali","Veli","1234567890"),musteriler);
musteriManager.Add(new Musteri(2,"Ayşe","Fatma","0987654321"),musteriler);
musteriManager.Add(new Musteri(3,"Mehmet","Ahmet","5432167890"),musteriler);
musteriManager.Add(new Musteri(4,"Zeynep","Zehra","0987654321"),musteriler);

Console.WriteLine("Müşteri Listesi:");
musteriManager.Listele(musteriler);

Console.WriteLine("Müşteri Silme:");
Console.WriteLine(musteriler[1].getAd());
musteriManager.Delete(musteriler[1],musteriler);
musteriManager.Listele(musteriler);