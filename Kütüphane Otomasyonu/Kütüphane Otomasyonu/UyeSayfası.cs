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
    public partial class UyeSayfası : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfası(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 loginSayfası = new Form1();
            loginSayfası.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UyeSayfası_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapId(), kitap.getKitapIsmi(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYili());
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int kitapId = Convert.ToInt32(txt_kitapId.Text);
            Kitap hedefKitap=null;
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == kitapId)
                {
                    hedefKitap=kitap;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsmi(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsmi(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
