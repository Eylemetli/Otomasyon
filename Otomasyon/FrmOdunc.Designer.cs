namespace Otomasyon
{
    partial class FrmOdunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdunc));
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlKayitlar = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlOdunc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtOduncId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskOduncTC = new System.Windows.Forms.MaskedTextBox();
            this.btnİadeAl = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnOduncVer = new DevExpress.XtraEditors.SimpleButton();
            this.txtUyeBul = new DevExpress.XtraEditors.TextEdit();
            this.txtArananYazar = new DevExpress.XtraEditors.TextEdit();
            this.txtArananAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOduncId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUyeBul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArananYazar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArananAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(377, 5);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl2.Size = new System.Drawing.Size(903, 536);
            this.xtraTabControl2.TabIndex = 8;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.xtraTabControl3);
            this.xtraTabPage3.Controls.Add(this.gridControlOdunc);
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(896, 486);
            this.xtraTabPage3.Text = "Ödünç kitaplar";
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Location = new System.Drawing.Point(-3, 219);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage5;
            this.xtraTabControl3.Size = new System.Drawing.Size(903, 275);
            this.xtraTabControl3.TabIndex = 9;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage5});
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.gridControlKayitlar);
            this.xtraTabPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage5.ImageOptions.Image")));
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(896, 225);
            this.xtraTabPage5.Text = "Tüm Kitaplar";
            // 
            // gridControlKayitlar
            // 
            this.gridControlKayitlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKayitlar.Location = new System.Drawing.Point(0, 0);
            this.gridControlKayitlar.MainView = this.gridView3;
            this.gridControlKayitlar.Name = "gridControlKayitlar";
            this.gridControlKayitlar.Size = new System.Drawing.Size(896, 225);
            this.gridControlKayitlar.TabIndex = 0;
            this.gridControlKayitlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlKayitlar;
            this.gridView3.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridControlOdunc
            // 
            this.gridControlOdunc.Location = new System.Drawing.Point(3, 3);
            this.gridControlOdunc.MainView = this.gridView1;
            this.gridControlOdunc.Name = "gridControlOdunc";
            this.gridControlOdunc.Size = new System.Drawing.Size(890, 210);
            this.gridControlOdunc.TabIndex = 0;
            this.gridControlOdunc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlOdunc;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 16);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(364, 521);
            this.xtraTabControl1.TabIndex = 9;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(357, 487);
            this.xtraTabPage1.Text = "Ödünç Bilgi";
            // 
            // txtOduncId
            // 
            this.txtOduncId.Location = new System.Drawing.Point(120, 365);
            this.txtOduncId.Name = "txtOduncId";
            this.txtOduncId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOduncId.Properties.Appearance.Options.UseFont = true;
            this.txtOduncId.Size = new System.Drawing.Size(228, 28);
            this.txtOduncId.TabIndex = 52;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 368);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 22);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "ÖDÜNÇ ID:";
            // 
            // MskOduncTC
            // 
            this.MskOduncTC.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskOduncTC.Location = new System.Drawing.Point(117, 67);
            this.MskOduncTC.Mask = "00000000000";
            this.MskOduncTC.Name = "MskOduncTC";
            this.MskOduncTC.Size = new System.Drawing.Size(228, 29);
            this.MskOduncTC.TabIndex = 50;
            this.MskOduncTC.ValidatingType = typeof(int);
            // 
            // btnİadeAl
            // 
            this.btnİadeAl.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİadeAl.Appearance.Options.UseFont = true;
            this.btnİadeAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİadeAl.ImageOptions.Image")));
            this.btnİadeAl.Location = new System.Drawing.Point(143, 416);
            this.btnİadeAl.Name = "btnİadeAl";
            this.btnİadeAl.Size = new System.Drawing.Size(168, 55);
            this.btnİadeAl.TabIndex = 49;
            this.btnİadeAl.Text = "İADE AL";
            this.btnİadeAl.Click += new System.EventHandler(this.btnİadeAl_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(33, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 22);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "ÜYE:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(143, 116);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(168, 55);
            this.simpleButton2.TabIndex = 46;
            this.simpleButton2.Text = "KİŞİ BUL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOduncVer.Appearance.Options.UseFont = true;
            this.btnOduncVer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOduncVer.ImageOptions.Image")));
            this.btnOduncVer.Location = new System.Drawing.Point(143, 290);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(168, 55);
            this.btnOduncVer.TabIndex = 45;
            this.btnOduncVer.Text = "ÖDÜNÇ VER";
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // txtUyeBul
            // 
            this.txtUyeBul.Location = new System.Drawing.Point(117, 24);
            this.txtUyeBul.Name = "txtUyeBul";
            this.txtUyeBul.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUyeBul.Properties.Appearance.Options.UseFont = true;
            this.txtUyeBul.Size = new System.Drawing.Size(228, 28);
            this.txtUyeBul.TabIndex = 44;
            // 
            // txtArananYazar
            // 
            this.txtArananYazar.Location = new System.Drawing.Point(120, 231);
            this.txtArananYazar.Name = "txtArananYazar";
            this.txtArananYazar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArananYazar.Properties.Appearance.Options.UseFont = true;
            this.txtArananYazar.Size = new System.Drawing.Size(228, 28);
            this.txtArananYazar.TabIndex = 43;
            this.txtArananYazar.EditValueChanged += new System.EventHandler(this.txtArananYazar_EditValueChanged);
            // 
            // txtArananAd
            // 
            this.txtArananAd.Location = new System.Drawing.Point(118, 197);
            this.txtArananAd.Name = "txtArananAd";
            this.txtArananAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArananAd.Properties.Appearance.Options.UseFont = true;
            this.txtArananAd.Size = new System.Drawing.Size(228, 28);
            this.txtArananAd.TabIndex = 41;
            this.txtArananAd.EditValueChanged += new System.EventHandler(this.txtArananAd_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(43, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 22);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "TC:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 241);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 22);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "YAZAR AD:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 197);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 22);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "KAYNAK AD:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtOduncId);
            this.panelControl1.Controls.Add(this.MskOduncTC);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.btnOduncVer);
            this.panelControl1.Controls.Add(this.txtUyeBul);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.btnİadeAl);
            this.panelControl1.Controls.Add(this.txtArananAd);
            this.panelControl1.Controls.Add(this.txtArananYazar);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(6, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(351, 476);
            this.panelControl1.TabIndex = 53;
            // 
            // FrmOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 553);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.xtraTabControl2);
            this.Name = "FrmOdunc";
            this.Text = "ÖDÜNÇ-İADE";
            this.Load += new System.EventHandler(this.FrmOdunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOduncId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUyeBul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArananYazar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArananAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControlOdunc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraGrid.GridControl gridControlKayitlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnİadeAl;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnOduncVer;
        private DevExpress.XtraEditors.TextEdit txtUyeBul;
        private DevExpress.XtraEditors.TextEdit txtArananYazar;
        private DevExpress.XtraEditors.TextEdit txtArananAd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox MskOduncTC;
        private DevExpress.XtraEditors.TextEdit txtOduncId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}