using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DbKutuphaneEntities db = new DbKutuphaneEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string gelenAd = txtKullaniciAd.Text;
            string gelenSifre = txtSifre.Text;

            var personel = db.TBL_PERSONELLER.Where(x=>x.personel_kullanıciad.Equals(gelenAd)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel == null)
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Başarılı giriş yaptınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Login başarılıysa OK döndür
                this.Close(); // Login formunu kapat
            }
        }
    }
}
