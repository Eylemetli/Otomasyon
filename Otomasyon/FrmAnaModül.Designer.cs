namespace Otomasyon
{
    partial class FrmAnaModül
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaModül));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonel = new DevExpress.XtraBars.BarButtonItem();
            this.btnKitap = new DevExpress.XtraBars.BarButtonItem();
            this.btnFiltre = new DevExpress.XtraBars.BarButtonItem();
            this.btnRapor = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdunc = new DevExpress.XtraBars.BarButtonItem();
            this.btnKatalog = new DevExpress.XtraBars.BarButtonItem();
            this.btnUye = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnPersonel,
            this.btnKitap,
            this.btnFiltre,
            this.btnRapor,
            this.btnOdunc,
            this.btnKatalog,
            this.btnUye});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1300, 176);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ANA SAYFA";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnPersonel
            // 
            this.btnPersonel.Caption = "PERSONEL";
            this.btnPersonel.Id = 2;
            this.btnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.ImageOptions.Image")));
            this.btnPersonel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonel.ImageOptions.LargeImage")));
            this.btnPersonel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonel_ItemClick);
            // 
            // btnKitap
            // 
            this.btnKitap.Caption = "KİTAP ENVANTERİ";
            this.btnKitap.Id = 3;
            this.btnKitap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKitap.ImageOptions.Image")));
            this.btnKitap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKitap.ImageOptions.LargeImage")));
            this.btnKitap.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitap.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKitap_ItemClick);
            // 
            // btnFiltre
            // 
            this.btnFiltre.Caption = "ARAMA-FİLTRELEME";
            this.btnFiltre.Id = 4;
            this.btnFiltre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltre.ImageOptions.Image")));
            this.btnFiltre.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFiltre.ImageOptions.LargeImage")));
            this.btnFiltre.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltre.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFiltre_ItemClick);
            // 
            // btnRapor
            // 
            this.btnRapor.Caption = "RAPORLAMA VE İSTATİSTİK";
            this.btnRapor.Id = 5;
            this.btnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRapor.ImageOptions.Image")));
            this.btnRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRapor.ImageOptions.LargeImage")));
            this.btnRapor.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRapor_ItemClick);
            // 
            // btnOdunc
            // 
            this.btnOdunc.Caption = "ÖDÜNÇ ALMA-İADE YÖNETİMİ";
            this.btnOdunc.Id = 6;
            this.btnOdunc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdunc.ImageOptions.Image")));
            this.btnOdunc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOdunc.ImageOptions.LargeImage")));
            this.btnOdunc.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdunc.ItemAppearance.Normal.Options.UseFont = true;
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdunc_ItemClick);
            // 
            // btnKatalog
            // 
            this.btnKatalog.Caption = "KATALOGLAMA";
            this.btnKatalog.Id = 7;
            this.btnKatalog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKatalog.ImageOptions.Image")));
            this.btnKatalog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKatalog.ImageOptions.LargeImage")));
            this.btnKatalog.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKatalog.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKatalog.Name = "btnKatalog";
            // 
            // btnUye
            // 
            this.btnUye.Caption = "ÜYELER";
            this.btnUye.Id = 8;
            this.btnUye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUye.ImageOptions.Image")));
            this.btnUye.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUye.ImageOptions.LargeImage")));
            this.btnUye.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUye.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUye.Name = "btnUye";
            this.btnUye.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUye_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "KÜTÜPHANE YÖNETİM SİSTEMİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersonel);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKitap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFiltre);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRapor);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOdunc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUye);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaModül
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 730);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmAnaModül";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIRAT LİBRARY";
            //this.Load += new System.EventHandler(this.FrmAnaModül_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnPersonel;
        private DevExpress.XtraBars.BarButtonItem btnKitap;
        private DevExpress.XtraBars.BarButtonItem btnFiltre;
        private DevExpress.XtraBars.BarButtonItem btnRapor;        
        private DevExpress.XtraBars.BarButtonItem btnOdunc;
        private DevExpress.XtraBars.BarButtonItem btnKatalog;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnUye;
    }
}

