using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otomasyon
{
    public partial class FrmOdunc : Form
    {
        public FrmOdunc()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        DbKutuphaneEntities db = new DbKutuphaneEntities();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_ODUNC", bgl.baglan());
            da.Fill(dt);
            gridControlOdunc.DataSource = dt;
        }
        private void FrmOdunc_Load(object sender, EventArgs e)
        {
            // Verileri al ve GridControl'e ata
            var kayitlar = db.TBL_KAYNAKLAR.ToList();
            gridControlKayitlar.DataSource = kayitlar;

            // GridControl'ün bağlı olduğu GridView'i al
            var gridView = gridControlKayitlar.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            // GridView'deki sütunlara erişim
            if (gridView != null)
            {
                // 12. sütunu görünmez yap
                gridView.Columns[12].Visible = false;
            }
            //Veri tabanında kayıtlı isimlerin değiştirilerek gridview'e yazdırılması
            gridView.Columns[0].Caption= "ID";
            gridView.Columns[1].Caption = "ISBN";
            gridView.Columns[2].Caption = "Kitap Adı";
            gridView.Columns[3].Caption = "Yazar";
            gridView.Columns[4].Caption = "Yayınevi";
            gridView.Columns[5].Caption = "Basım Tarihi";
            gridView.Columns[6].Caption = "Sayfa Sayısı";
            gridView.Columns[7].Caption = "Tür";
            gridView.Columns[8].Caption = "Ülke";
            gridView.Columns[9].Caption = "Dil";
            gridView.Columns[10].Caption = "Okuma Sayısı";
            gridView.Columns[11].Caption = "Raf";

            //Ödünç kitap tablosunun listelenmesi
            var odunc = db.TBL_ODUNC.ToList();
            gridControlOdunc.DataSource = odunc;

            // GridControl'ün bağlı olduğu GridView'i al
            var gridView1 = gridControlOdunc.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null)
            {
                // 12. sütunu görünmez yap
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Visible = false;
            }
            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "Kitap ID";
            gridView1.Columns[2].Caption = "Üye ID";
            gridView1.Columns[3].Caption = "Alış Tarihi";
            gridView1.Columns[4].Caption = "Son Tarih";
            gridView1.Columns[5].Caption = "Durum";
        }
        //TC'ye göre üyeler tablosundan kişinin bulunması ve isim yazdırılması
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string arananTC = MskOduncTC.Text;
            var kullanıcıVarMİ = db.TBL_UYELER.Where(x => x.uye_TC.Equals (arananTC)).FirstOrDefault();
            if (kullanıcıVarMİ != null)
            {
                txtUyeBul.Text = kullanıcıVarMİ.uye_ad + " " + kullanıcıVarMİ.uye_soyad;
            }
            else
            {
                MessageBox.Show("Belirtilen TC'ye sahip bir kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUyeBul.Text = ""; // Bulunamadığında temizle
            }

        }
        //Yazılan kitap ismine göre arama
        private void txtArananAd_EditValueChanged(object sender, EventArgs e)
        {
            string gelenAd = txtArananAd.Text;
            var bulunanKaynaklar = db.TBL_KAYNAKLAR.Where(x => x.kaynak_ad.Contains(gelenAd)).ToList();
            gridControlKayitlar.DataSource = bulunanKaynaklar;
        }
        //Yazar adına göre arama
        private void txtArananYazar_EditValueChanged(object sender, EventArgs e)
        {
            string gelenAd = txtArananYazar.Text;
            var bulunan = db.TBL_KAYNAKLAR.Where(x => x.kaynak_yazar.Contains(gelenAd)).ToList();
            gridControlKayitlar.DataSource = bulunan;
        }
        //Ödünç verme

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            //TC'nin alınması
            string gelenTC = MskOduncTC.Text;
            var secilenKisi = db.TBL_UYELER.Where(x => x.uye_TC.Equals(gelenTC)).FirstOrDefault();
            //Kitap id'sinin alınması
            var gridView = gridControlKayitlar.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            int secilenKitapId = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns[0]));
            var secilenKitap = db.TBL_KAYNAKLAR.Where(x => x.kaynak_id == secilenKitapId).FirstOrDefault();
            var mevcutOdunc = db.TBL_ODUNC.Where(o => o.kitap_id == secilenKitapId && o.durm == false).FirstOrDefault();

            if (mevcutOdunc != null)
            {
                MessageBox.Show("Bu kitap şu anda ödünç verilmiş durumda.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }
            else
            {

                MessageBox.Show("Seçilen kitap ödünç verildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Ödünç tablosunda yeni kayıt 
                TBL_ODUNC yeniOdunc = new TBL_ODUNC();
                yeniOdunc.kitap_id = secilenKitap.kaynak_id;
                yeniOdunc.kullanici_id = secilenKisi.uye_id;
                yeniOdunc.alis_tarih = DateTime.Today;
                yeniOdunc.veris_tarih = DateTime.Today.AddDays(1);
                yeniOdunc.durm = false;
                db.TBL_ODUNC.Add(yeniOdunc);
                secilenKitap.kaynak_adet += 1;
                db.SaveChanges();

                //Ödünç tablosunda yeni tablonun listelenmesi
                var odunc = db.TBL_ODUNC.ToList();
                gridControlOdunc.DataSource = odunc;
            }
        }
        //İade işlemi
        private void btnİadeAl_Click(object sender, EventArgs e)
        {

            // Silme işlemini yap
            SqlCommand komut = new SqlCommand("Delete from TBL_ODUNC where odunc_id=@p1", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtOduncId.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();            

            TBL_ODUNC yeniiade = new TBL_ODUNC();
            yeniiade.veris_tarih = DateTime.Today;
            yeniiade.durm = true;
           
            db.SaveChanges();

            // Kullanıcıya bilgi ver
            MessageBox.Show("İade alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
   
        }
    }
}
