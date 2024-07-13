using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace denemeIki
{
    public class Musteri
    {
        private int id;
        private string ad;
        private string soyad;
        private string telefon;

        public Musteri(int id, string ad, string soyad, string telefon){
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.telefon = telefon;
            
        }

        public int getId(){
            return id;
        }
        public void setId(int id){
            this.id = id;
        }
        public string getAd(){
            return ad;
        }
        public void setAd(string ad){
            this.ad = ad;
        }
        public string getSoyad(){
            return soyad;
        }
        public void setSoyad(string soyad){
            this.soyad = soyad;
        }
        public string getTelefon(){
            return telefon;
        }
        public void setTelefon(string telefon){
            this.telefon = telefon;
        }

         

    }
}