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
    public partial class FrmArama : Form
    {
        public FrmArama()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        DbKutuphaneEntities db = new DbKutuphaneEntities();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_KAYNAKLAR", bgl.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmArama_Load(object sender, EventArgs e)
        {            
            var kayitlar = db.TBL_KAYNAKLAR.ToList();
            gridControl1.DataSource = kayitlar;
            // GridControl'ün bağlı olduğu GridView'i al
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            // GridView'deki sütunlara erişim
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string aramaad = txtAramaAd.Text;
            string aramayazar = txtAramaYazar.Text;
            string aramatur = cmbAramaTur.Text;
            string aramayayinevi = txtAramaYayınevi.Text;
            string aramaisbn = MskAramaISBN.Text;
            string aramaulke = txtAramaUlke.Text;
            string aramadil = txtAramaDil.Text;
            string aramaraf = txtAramaRaf.Text;
            int aramaId = 0;
            if (!int.TryParse(txtAramaId.Text, out aramaId))
            {
                aramaId = 0; // Eğer ID geçerli bir sayı değilse, varsayılan olarak 0 alır
            }
            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_KAYNAKLAR WHERE " +
                "(kaynak_ad LIKE @aramaad OR @aramaad='') AND"+
                "(kaynak_yazar LIKE @aramayazar OR @aramayazar='') AND"+
                "(kaynak_tur LIKE @aramatur OR @aramatur='') AND"+
                "(kaynak_yayinevi LIKE @aramayayinevi OR @aramayayinevi='') AND"+
                "(kaynak_isbn LIKE @aramaisbn OR @aramaisbn='') AND"+
                "(kaynak_ulke LIKE @aramaulke OR @aramaulke='') AND"+
                "(kaynak_dil LIKE @aramadil OR @aramadil='') AND"+
                "(kaynak_raf LIKE @aramaraf OR @aramaraf='') AND"+
                "(kaynak_id = @aramaId OR @aramaId=0)",bgl.baglan());
            komut.Parameters.AddWithValue("@aramaad","%"+aramaad+"%");
            komut.Parameters.AddWithValue("@aramayazar","%"+aramayazar+"%");
            komut.Parameters.AddWithValue("@aramatur", "%" + aramatur + "%");
            komut.Parameters.AddWithValue("@aramayayinevi", "%" + aramayayinevi + "%");
            komut.Parameters.AddWithValue("@aramaisbn","%"+aramaisbn+"%");
            komut.Parameters.AddWithValue("@aramaulke","%"+aramaulke+"%");
            komut.Parameters.AddWithValue("@aramadil","%"+aramadil+"%");
            komut.Parameters.AddWithValue("@aramaraf","%"+aramaraf+"%");
            komut.Parameters.AddWithValue("@aramaId",aramaId);

            
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.baglan().Close();
            gridControl1.DataSource = dt;
            MessageBox.Show("Filtreleme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
