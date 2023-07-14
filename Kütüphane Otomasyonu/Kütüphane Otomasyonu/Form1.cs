using Kütüphane_Otomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();

        List<Kitap>kitaplarım=new List<Kitap>();    

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullanıcıAdı.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullanıcıAdi, sifre = "";
            kullanıcıAdi = txt_kullanıcıAdı.Text;
            sifre = txt_sifre.Text;
            bool kontrol = false;
                

            foreach (Kisi kisi in kisilerim)
            {
                if (kullanıcıAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getsifre() && kisi.getyetki() == "admin")
                {
                    // Admin sayfasına yönlendirdik
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,kitaplarım);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true; 
                    break;
                    
                }
                else if (kullanıcıAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getsifre() && kisi.getyetki() == "uye")
                {
                    UyeSayfası uyeSayfası = new UyeSayfası(kitaplarım);
                    uyeSayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                

            }
            if (!kontrol)
            {
                MessageBox.Show("Hatalı şifre veya kullanıcı adı.","Eror" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1,"Ali","Oğuzbey",DateTime.Now,"ali","1","admin"));
            kisilerim.Add(new Kisi(2, "Burhan", "Ertuğrul", DateTime.Now, "baver", "1234", "uye"));
            kisilerim.Add(new Kisi(3, "Alihan", "Er", DateTime.Now, "alihan", "12345", "uye"));
            kisilerim.Add(new Kisi(4, "Yakup", "Taylan", DateTime.Now, "yakup", "123456", "uye"));



            kitaplarım.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            kitaplarım.Add(new Kitap(2,"Tutunamayanlar","Oğuz Atay","Türkçe","İletişim Yayıncılık","Roman",350,760, 2015));
            kitaplarım.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "Roman", 100, 350, 2010));
            kitaplarım.Add(new Kitap(4,"Küçük Prens", "Antoine de Saint-Exupéry", "İngilizce","Can Çocuk Yayınları","Roman",50,60,2018));
            kitaplarım.Add(new Kitap(5,"Kürk Montlu Madonna", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman",50,220,2015));
            //kitaplarım.Add(new Kitap(6,"Tehlikeli Oyunlar","Oğuz Atay","Türkçe","İletişim Yayıncılık","Roman",420,500,2018));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
