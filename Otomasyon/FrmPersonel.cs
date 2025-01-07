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
    public partial class FrmPersonel : Form
    {

        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();//sql sınıfından nesne yaratıldı
        //listele ile veritabanındaki kayıtların ekrana çekilmesi
        DbKutuphaneEntities db = new DbKutuphaneEntities();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_PERSONELLER", bgl.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtPersonelId.Text = "";
            txtPersonelAd.Text ="";
            txtPersonelSoyad.Text = "";
            MskPersonelTC.Text = "";
            MskPersonelTel.Text = "";
            txtPersonelMail.Text ="";
            txtPersonelAdres.Text ="";
            txtKullaniciAdi.Text = "";
            txtPersonelId.Text = "";
        }
        //Personel ekranı açıldığında bilgiler otomatik listelenecek
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            //listele();
            var kayitlar = db.TBL_PERSONELLER.ToList();
            gridControl1.DataSource = kayitlar;
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            
            //Veri tabanında kayıtlı isimlerin değiştirilerek gridview'e yazdırılması
            gridView.Columns[0].Caption = "ID";
            gridView.Columns[1].Caption = "Ad";
            gridView.Columns[2].Caption = "Soyad";
            gridView.Columns[3].Caption = "TC";
            gridView.Columns[4].Caption = "Tel.No";
            gridView.Columns[5].Caption = "e-posta";
            gridView.Columns[6].Caption = "Kullanıcı Adı";
            gridView.Columns[7].Caption = "Şifre";
            gridView.Columns[8].Caption = "";
            gridView.Columns[9].Caption = "Adres";           
        }

        //Personel bilgilerinin alınıp veritabanına kaydedilmesi
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER(personel_ad,personel_soyad,personel_TC,personel_tel,personel_mail,personel_kullanıciad,personel_adres,personel_sifre)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskPersonelTC.Text);
            komut.Parameters.AddWithValue("@p4", MskPersonelTel.Text);
            komut.Parameters.AddWithValue("@p5", txtPersonelMail.Text);
            komut.Parameters.AddWithValue("@p6", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p7", txtPersonelAdres.Text);
            komut.Parameters.AddWithValue("@p8", txtPersonelSifre.Text);

            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Personel Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        //Gridvieew'deki bilgilerin tıklanınca araçlara taşınması metodu
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtPersonelId.Text = dr["personel_id"].ToString();
                txtPersonelAd.Text = dr["personel_ad"].ToString();
                txtPersonelSoyad.Text = dr["personel_soyad"].ToString();
                MskPersonelTC.Text = dr["personel_TC"].ToString();
                MskPersonelTel.Text = dr["personel_tel"].ToString();
                txtPersonelMail.Text = dr["personel_mail"].ToString();
                txtPersonelAdres.Text = dr["personel_adres"].ToString();
                txtKullaniciAdi.Text = dr["personel_kullanıciad"].ToString();
            }
        }
        //Kayıtlı bilgilerin değiştirilmesi durumunda kayıtların güncellenmesi
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER set personel_ad=@p1,personel_soyad=@p2,personel_TC=@p3,personel_tel=@p4,personel_mail=@p5,personel_adres=@p6,personel_kullanıciad=@p7,personel_sifre=@p8 where personel_id=@p9",bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskPersonelTC.Text);
            komut.Parameters.AddWithValue("@p4", MskPersonelTel.Text);
            komut.Parameters.AddWithValue("@p5", txtPersonelMail.Text);
            komut.Parameters.AddWithValue("@p6", txtPersonelAdres.Text);
            komut.Parameters.AddWithValue("@p7", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p8", txtPersonelSifre.Text);
            komut.Parameters.AddWithValue("@p9", txtPersonelId.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Personel Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_PERSONELLER where personel_id=@p1", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtPersonelId.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Personel Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        //Araç kutusundaki bilgilerin veri tabanından silinmeden araç kutularından temizlenmesi
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
