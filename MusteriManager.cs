using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace denemeIki
{
    public class MusteriManager
    {
        public void Add(Musteri musteri,List<Musteri> musteriler){
            Console.WriteLine("Müşteri eklendi: " + musteri.getAd());
            musteriler.Add(musteri);
        }
        public void Delete(Musteri musteri,List<Musteri> musteriler){
            Console.WriteLine("Müşteri silindi: " + musteri.getAd());
            musteriler.Remove(musteri);
        }
        public void Listele(List<Musteri> musteriler){
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı: " + musteri.getAd());
                Console.WriteLine("Müşteri Soyadı: " + musteri.getSoyad());
                Console.WriteLine("Müşteri Telefonu: " + musteri.getTelefon());
                Console.WriteLine("Müşteri Id: " + musteri.getId());
                Console.WriteLine("*********************");
            }
        }
    }
}