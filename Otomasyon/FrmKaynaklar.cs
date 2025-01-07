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
    public partial class FrmKaynaklar : Form
    {
        public FrmKaynaklar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        DbKutuphaneEntities db = new DbKutuphaneEntities();
        //LİSTELEME
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_KAYNAKLAR", bgl.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        //ARAÇ KUTUSUNDAKİ BİLGİLERİN TEMİZLENMESİ İÇİN METOT
        void temizle()
        {
            txtKaynakId.Text = "";
            txtKaynakAd.Text = "";
            //txtKaynakAdet.Text = "";
            txtKaynakBaskı.Text = "";
            txtKaynakDil.Text = "";
            txtKaynakRaf.Text = "";
            txtKaynakSayfa.Text = "";
            txtKaynakUlke.Text = "";
            txtKaynakYayınevi.Text = "";
            txtYazarAd.Text = "";
            cmbKaynakTur.Text = "";
            //txtKaynakTur.Text = "";
            MskISBN.Text = "";
        }
        //KİTAP LİSTELEME METODU HER SEFERİNDE ÇAĞRILIYOR
        private void FrmKaynaklar_Load(object sender, EventArgs e)
        {
            //listele();
            var kayitlar = db.TBL_KAYNAKLAR.ToList();
            gridControl1.DataSource = kayitlar;

            // GridControl'ün bağlı olduğu GridView'i al
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null)
            {
                // 12. sütunu görünmez yap
                gridView.Columns[12].Visible = false;
            }

            //Veri tabanında kayıtlı isimlerin değiştirilerek gridview'e yazdırılması
            gridView.Columns[0].Caption = "ID";
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

        }
        //KİTAP EKLEME
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_KAYNAKLAR(kaynak_ad,kaynak_isbn,kaynak_yazar,kaynak_yayinevi,kaynak_basımtarihi,kaynak_sayfa,kaynak_tur,kaynak_ulke,kaynak_dil,kaynak_raf,kaynak_adet)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtKaynakAd.Text);
            komut.Parameters.AddWithValue("@p2", MskISBN.Text);
            komut.Parameters.AddWithValue("@p3", txtYazarAd.Text);
            komut.Parameters.AddWithValue("@p4", txtKaynakYayınevi.Text);
            komut.Parameters.AddWithValue("@p5", txtKaynakBaskı.Text);
            komut.Parameters.AddWithValue("@p6", txtKaynakSayfa.Text);
            komut.Parameters.AddWithValue("@p7", cmbKaynakTur.Text);
            komut.Parameters.AddWithValue("@p8", txtKaynakUlke.Text);
            komut.Parameters.AddWithValue("@p9", txtKaynakDil.Text);
            komut.Parameters.AddWithValue("@p10", txtKaynakRaf.Text);
            komut.Parameters.AddWithValue("@p11", 0);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kaynak Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        //BİLGİLERİN ARAÇ KUTULRINA TAŞINMASI
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtKaynakId.Text = dr["kaynak_id"].ToString();
                txtKaynakAd.Text = dr["kaynak_ad"].ToString();
                txtKaynakSayfa.Text = dr["kaynak_sayfa"].ToString();
                txtKaynakBaskı.Text = dr["kaynak_basımtarihi"].ToString();
                txtKaynakDil.Text = dr["kaynak_dil"].ToString();
                txtKaynakRaf.Text = dr["kaynak_raf"].ToString();
                cmbKaynakTur.Text = dr["kaynak_tur"].ToString();
                txtKaynakUlke.Text = dr["kaynak_ulke"].ToString();
                txtKaynakYayınevi.Text = dr["kaynak_yayinevi"].ToString();
                txtYazarAd.Text = dr["kaynak_yazar"].ToString();
                //txtKaynakAdet.Text = dr["kaynak_adet"].ToString();
                MskISBN.Text = dr["kaynak_isbn"].ToString();
            }
        }
        //GÜNCELLEME
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_KAYNAKLAR set kaynak_ad=@p1,kaynak_yazar=@p2,kaynak_isbn=@p3,kaynak_yayinevi=@p4,kaynak_basımtarihi=@p5,kaynak_sayfa=@p6,kaynak_tur=@p7,kaynak_ulke=@p8,kaynak_dil=@p9,kaynak_raf=@p10 where kaynak_id=@p11", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtKaynakAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazarAd.Text);
            komut.Parameters.AddWithValue("@p3", MskISBN.Text);
            komut.Parameters.AddWithValue("@p4", txtKaynakYayınevi.Text);
            komut.Parameters.AddWithValue("@p5", txtKaynakBaskı.Text);
            komut.Parameters.AddWithValue("@p6", txtKaynakSayfa.Text);
            komut.Parameters.AddWithValue("@p7", cmbKaynakTur.Text);
            komut.Parameters.AddWithValue("@p8", txtKaynakUlke.Text);
            komut.Parameters.AddWithValue("@p9", txtKaynakDil.Text);          
            komut.Parameters.AddWithValue("@p10", txtKaynakRaf.Text);
            //komut.Parameters.AddWithValue("@p11", 0);
            komut.Parameters.AddWithValue("@p11", txtKaynakId.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kaynak Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        //SİLME
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_KAYNAKLAR where kaynak_id=@p1", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtKaynakId.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kaynak Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        //TEMİZLE 
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
