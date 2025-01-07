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
    public partial class FrmUyeler : Form
    {
        public FrmUyeler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();//sql sınıfından nesne yaratıldı
        //listele ile veritabanındaki kayıtların ekrana çekilmesi
        DbKutuphaneEntities db = new DbKutuphaneEntities();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_UYELER", bgl.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmUyeler_Load(object sender, EventArgs e)
        {
            //listele();
            var kayitlar = db.TBL_UYELER.ToList();
            gridControl1.DataSource = kayitlar;
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;


            //Veri tabanında kayıtlı isimlerin değiştirilerek gridview'e yazdırılması
            if (gridView != null)
            {
                // 12. sütunu görünmez yap
                gridView1.Columns[7].Visible = false;
                gridView1.Columns[10].Visible = false;
            }
            gridView.Columns[0].Caption = "ID";
            gridView.Columns[1].Caption = "Ad";
            gridView.Columns[2].Caption = "Soyad";
            gridView.Columns[3].Caption = "TC";
            gridView.Columns[4].Caption = "Tel.No";
            gridView.Columns[5].Caption = "e-posta";
            gridView.Columns[6].Caption = "Adres";
            gridView.Columns[7].Caption = "";
            gridView.Columns[8].Caption = "Cinsiyet";
            gridView.Columns[9].Caption = "Doğum Tarihi";

        }
        public string cinsiyet;
        //Üye bilgilerinin kaydedilmesi
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_UYELER(uye_ad,uye_soyad,uye_TC,uye_tel,uye_mail,uye_dTarihi,uye_adres,uye_cinsiyet)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtUyeAd.Text);
            komut.Parameters.AddWithValue("@p2", txtUyeSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskUyeTC.Text);
            komut.Parameters.AddWithValue("@p4", MskUyeTel.Text);
            komut.Parameters.AddWithValue("@p5", txtUyeMail.Text);
            komut.Parameters.AddWithValue("@p6", dEUyeDogumTarihi.Text);
            komut.Parameters.AddWithValue("@p7", txtUyeAdres.Text);
            if (radioButtonKadın.Checked == true)
            {
                komut.Parameters.AddWithValue("@p8",cinsiyet="K");
            }
            else
            {
                komut.Parameters.AddWithValue("@p8",cinsiyet="E");
            }
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Üye Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        //Veritabanındaki bilgilerin araç kutusuna aktarılması
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtUyeId.Text = dr["uye_id"].ToString();
                txtUyeAd.Text = dr["uye_ad"].ToString();
                txtUyeSoyad.Text = dr["uye_soyad"].ToString();
                MskUyeTC.Text = dr["uye_TC"].ToString();
                MskUyeTel.Text = dr["uye_tel"].ToString();
                txtUyeMail.Text = dr["uye_mail"].ToString();
                txtUyeAdres.Text = dr["uye_adres"].ToString();
                dEUyeDogumTarihi.Text = dr["uye_dTarihi"].ToString();
                if (dr["uye_cinsiyet"].ToString() == "E")
                {
                    radioButtonErkek.Checked = true;
                }
                else
                {
                    radioButtonKadın.Checked = true;
                }
            }
        }
        //GÜNCELLEME-ÜYELER
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_UYELER set uye_ad=@p1,uye_soyad=@p2,uye_TC=@p3,uye_tel=@p4,uye_mail=@p5,uye_adres=@p6,uye_dTarihi=@p7,uye_cinsiyet=@p8 where uye_id=@p9", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtUyeAd.Text);
            komut.Parameters.AddWithValue("@p2", txtUyeSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskUyeTC.Text);
            komut.Parameters.AddWithValue("@p4", MskUyeTel.Text);
            komut.Parameters.AddWithValue("@p5", txtUyeMail.Text);
            komut.Parameters.AddWithValue("@p6", txtUyeAdres.Text);
            komut.Parameters.AddWithValue("@p7", dEUyeDogumTarihi.Text);
            if (radioButtonKadın.Checked == true)
            {
                komut.Parameters.AddWithValue("@p8", cinsiyet = "K");
            }
            else
            {
                komut.Parameters.AddWithValue("@p8", cinsiyet = "E");
            }
            komut.Parameters.AddWithValue("@p9", txtUyeId.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Üye Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        //SİLME-ÜYELER
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Delete from TBL_UYELER where uye_id=@p1", bgl.baglan());
            //komut.Parameters.AddWithValue("@p1", txtUyeId.Text);
            //komut.ExecuteNonQuery();
            //bgl.baglan().Close();
            //MessageBox.Show("Üye Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //listele();
            // Bağlantı ve komut tanımlama
            SqlCommand komutKontrol = new SqlCommand("Select Count(*) from TBL_ODUNC where kullanici_id = @p1 and durm = 0", bgl.baglan());
            komutKontrol.Parameters.AddWithValue("@p1", txtUyeId.Text);

            // Üyenin ödünçte kitabı olup olmadığını kontrol et
            int oduncSayisi = Convert.ToInt32(komutKontrol.ExecuteScalar());
            bgl.baglan().Close();

            if (oduncSayisi > 0)
            {
                // Eğer ödünç kitap varsa, uyarı göster ve silme işlemini iptal et
                MessageBox.Show("Bu üye ödünç aldığı kitabı henüz iade etmediği için silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Ödünç kitap yoksa silme işlemini gerçekleştir
                SqlCommand komutSil = new SqlCommand("Delete from TBL_UYELER where uye_id = @p1", bgl.baglan());
                komutSil.Parameters.AddWithValue("@p1", txtUyeId.Text);
                komutSil.ExecuteNonQuery();
                bgl.baglan().Close();
                MessageBox.Show("Üye Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele(); // Üye listesi yenileniyor
            }

        }
        //TEMİZLE
        void temizle()
        {
            txtUyeId.Text = "";
            txtUyeAd.Text = "";
            txtUyeSoyad.Text = "";
            txtUyeMail.Text = "";
            txtUyeAdres.Text = "";
            MskUyeTC.Text = "";
            MskUyeTel.Text = "";
            dEUyeDogumTarihi.Text = "";
            radioButtonErkek.Checked = false;
            radioButtonKadın.Checked = false;
            
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
