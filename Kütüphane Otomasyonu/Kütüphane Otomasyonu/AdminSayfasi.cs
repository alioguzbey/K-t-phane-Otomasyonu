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
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;

        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_soyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getİd(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarihi(), kisi.getKullaniciAdi(), kisi.getsifre(), kisi.getyetki());
            }
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapIsmi(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYili());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, maskedTextBox1.Text, txt_kullanıcıadi.Text, txt_sifre.Text, txt_yetki.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void textleriDoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullanıcıadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string olusturmaTarihi = maskedTextBox1.Text;
            string kullaniciAdi = txt_kullanıcıadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, olusturmaTarihi, kullaniciAdi, sifre, yetki);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupbox_uyeislemleri.Controls.Count; i++)
            {
                if (groupbox_uyeislemleri.Controls[i] is TextBox || groupbox_uyeislemleri.Controls[i] is MaskedTextBox)
                {
                    groupbox_uyeislemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapId.Text, txt_kitapIsmi.Text, txt_kitapYazari.Text, txt_dil.Text, txt_yayınEvi.Text, txt_tur.Text, txt_adet.Text, txt_sayfa.Text, txt_basınYili.Text);
        }

        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapTemizle_Click(object sender, EventArgs e)
        {
            for(int i =0;i < groupBox_kitapIslemleri.Controls.Count; i++)
            {
                if (groupBox_kitapIslemleri.Controls[i]is TextBox)
                {
                    groupBox_kitapIslemleri.Controls[i].Text = string.Empty;    
                }
            }
        }

        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            string kiptaId = txt_kitapId.Text;
            string kitapIsmi = txt_kitapIsmi.Text;
            string kitapYazar=txt_kitapYazari.Text;
            string dil=txt_dil.Text;
            string yayinEvi = txt_yayınEvi.Text;
            string tur=txt_tur.Text;
            string adet=txt_adet.Text;  
            string sayfa=txt_sayfa.Text;
            string basinYili = txt_basınYili.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kiptaId,kitapIsmi,kitapYazar,dil,yayinEvi,tur,adet,sayfa,basinYili);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapIsmi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapYazari.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayınEvi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tur.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basınYili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kisiAra_Click(object sender, EventArgs e)
        {
            Kisi hedefkisi = null;

            int secileId = Convert.ToInt32(textBox1.Text);
            foreach  ( Kisi kisi in kisilerim)
            {
                if (kisi.getİd()==secileId)
                {
                    hedefkisi=kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getİd(), hedefkisi.getIsim(),hedefkisi.getSoyisim(),hedefkisi.getOlusturmaTarihi(),hedefkisi.getKullaniciAdi(),hedefkisi.getsifre(),hedefkisi.getyetki()) ;
        }

        private void btn_kisiYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach   (Kisi hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefkisi.getİd(), hedefkisi.getIsim(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmaTarihi(), hedefkisi.getKullaniciAdi(), hedefkisi.getsifre(), hedefkisi.getyetki());
            }
        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            Kitap hedefKitap = null;
            int kitapId = Convert.ToInt32(textBox2.Text);
            foreach (Kitap kitap in kitaplarim)
               
            {
                if (kitap.getKitapId()==kitapId)
                {
                    hedefKitap = kitap;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(),hedefKitap.getKitapIsmi(),hedefKitap.getKitapYazar(),hedefKitap.getKitapDili(),hedefKitap.getYayinEvi(),hedefKitap.getTur(),hedefKitap.getAdet(),hedefKitap.getSayfaSayisi(),hedefKitap.getBasimYili());
        }

        private void btn_kitapYenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove (dataGridView2.CurrentRow);    
            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsmi(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());
            }
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 loginSayfası=new Form1();
            loginSayfası.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı","Bilgilendirme ", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
