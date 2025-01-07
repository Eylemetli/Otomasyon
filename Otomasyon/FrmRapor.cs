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
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }
        DbKutuphaneEntities db = new DbKutuphaneEntities();
        sqlBaglantisi bgl = new sqlBaglantisi();
        void listeleKaynak()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_KAYNAKLAR", bgl.baglan());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        void listeleOdunc()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_ODUNC", bgl.baglan());
            da.Fill(dt);            
            gridControl4.DataSource = dt;
            
        }

        private void btnToplamKitap_Click(object sender, EventArgs e)
        {            
            listeleKaynak();
            
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBL_KAYNAKLAR", bgl.baglan());
            int toplamKitapSayisi = Convert.ToInt32(komut.ExecuteScalar());
            bgl.baglan().Close();

            // Kitap sayısını textbox'a yazdır
            txtToplamKitap.Text = toplamKitapSayisi.ToString();
            
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {           
            listeleOdunc();
            
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBL_ODUNC", bgl.baglan());
            int toplamOdunc = Convert.ToInt32(komut.ExecuteScalar());
            bgl.baglan().Close();

            txtOdunc.Text = toplamOdunc.ToString();
            
        }

        private void btnCokOkunanlar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter komut = new SqlDataAdapter(@"SELECT kaynak_ad, kaynak_adet FROM TBL_KAYNAKLAR ORDER BY kaynak_adet DESC", bgl.baglan());
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void btnGecikenKitap_Click(object sender, EventArgs e)
        {
            SqlDataAdapter komut = new SqlDataAdapter(@"SELECT TBL_KAYNAKLAR.kaynak_ad, TBL_ODUNC.alis_tarih, TBL_ODUNC.veris_tarih
                                                      FROM TBL_KAYNAKLAR
                                                      JOIN TBL_ODUNC ON TBL_KAYNAKLAR.kaynak_id = TBL_ODUNC.kitap_id
                                                      WHERE TBL_ODUNC.durm = 0
                                                      AND TBL_ODUNC.veris_tarih < GETDATE()
                                                      ORDER BY TBL_ODUNC.veris_tarih; ", bgl.baglan());
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl2.DataSource = dt;


        }
    }
}
