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
    public partial class FrmAnaModül : Form
    {
        public FrmAnaModül()
        {
            InitializeComponent();
        }
      
        FrmPersonel frm1;
        FrmUyeler frm2;
        FrmKaynaklar frm3;
        FrmArama frm4;
        FrmOdunc frm5;
        FrmRapor frm6;
        private void btnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
                //personeller sekmesi 1 kez açılacak ve kapandığına tekrar açılabilecek
            {
                frm1 = new FrmPersonel();
                frm1.MdiParent = this;//personelin parent'i frmanamodül
                frm1.Show();
            }
        }
        
        private void btnUye_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm1.IsDisposed)
            //üyeler sekmesi 1 kez açılacak ve kapandığına tekrar açılabilecek
            {
                frm2 = new FrmUyeler();
                frm2.MdiParent = this;//üyenin parent'i frmanamodül
                frm2.Show();
            }
        }

        private void btnKitap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            //kaynaklar sekmesi 1 kez açılacak ve kapandığına tekrar açılabilecek
            {
                frm3 = new FrmKaynaklar();
                frm3.MdiParent = this;//kaynak parent'i frmanamodül
                frm3.Show();
            }
        }

        private void btnFiltre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            //arama sekmesi 1 kez açılacak ve kapandığına tekrar açılabilecek
            {
                frm4 = new FrmArama();
                frm4.MdiParent = this;//arama parent'i frmanamodül
                frm4.Show();
            }
        }

        private void btnOdunc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            //ödünç sekmesi 1 kez açılacak ve kapandığına tekrar açılabilecek
            {
                frm5 = new FrmOdunc();
                frm5.MdiParent = this;//ödünç parent'i frmanamodül
                frm5.Show();
            }
        }

        private void btnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            //rapor sekmesi 1 kez açılacak ve kapandığına tekrar açılabilecek
            {
                frm6 = new FrmRapor();
                frm6.MdiParent = this;//Rapor parent'i frmanamodül
                frm6.Show();
            }
        }
    }
}
