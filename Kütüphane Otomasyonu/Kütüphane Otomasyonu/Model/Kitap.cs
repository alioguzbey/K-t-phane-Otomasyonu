using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu.Model
{
    public class Kitap
    {
        public int kitapId { get; set; }
        public string kitapIsmi { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimYil { get; set; }
        public Kitap()
        {

        }
        public Kitap(int kitapId, string kitapIsmi, string kitapYazar, string kitapDili, string yayinEvi, string tur, int adet, int sayfaSayisi, int basimYil)
        {
            this.kitapId = kitapId;
            this.kitapIsmi = kitapIsmi;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYil = basimYil;
        }

        public int getKitapId()
        {
            return this.kitapId;
        }

        public string getKitapIsmi()
        {
            return this.kitapIsmi;
        }
        public string getKitapYazar()
        {
            return this.kitapYazar;
        }
        public string getKitapDili()
        {
            return this.kitapDili;
        }
        public string getYayinEvi()
        {
            return this.yayinEvi;
           
            
        }
        public string getTur()
        {
            return this.tur;
        }
        public int getAdet()
        {
            return this.adet;
        }
        public int getSayfaSayisi()
        {
            return this.sayfaSayisi;
        }
        public int getBasimYili()
        {
            return this.basimYil;
        }
    }
}
