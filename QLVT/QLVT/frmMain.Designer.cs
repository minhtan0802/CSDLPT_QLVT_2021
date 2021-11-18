
namespace QLVT
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LapPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LapDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btn_InDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_InVT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_InBangKeNX = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_VatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Kho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.rib_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_DanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_NghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_DangNhap,
            this.btn_TaoTaiKhoan,
            this.btn_DangXuat,
            this.btn_NhanVien,
            this.btn_LapPhieu,
            this.barButtonItem2,
            this.btn_LapDDH,
            this.btn_InDSNV,
            this.btn_InVT,
            this.btn_InBangKeNX,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btn_VatTu,
            this.btn_Kho,
            this.barButtonItem6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 25;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rib_HeThong,
            this.rib_DanhMuc,
            this.rib_NghiepVu,
            this.rib_BaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1602, 193);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Caption = "Đăng nhập";
            this.btn_DangNhap.Id = 1;
            this.btn_DangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.Image")));
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangNhap_ItemClick);
            // 
            // btn_TaoTaiKhoan
            // 
            this.btn_TaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btn_TaoTaiKhoan.Enabled = false;
            this.btn_TaoTaiKhoan.Id = 2;
            this.btn_TaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoTaiKhoan.ImageOptions.Image")));
            this.btn_TaoTaiKhoan.Name = "btn_TaoTaiKhoan";
            this.btn_TaoTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_TaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TaoTaiKhoan_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Enabled = false;
            this.btn_DangXuat.Id = 3;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Caption = "Nhân viên";
            this.btn_NhanVien.Id = 4;
            this.btn_NhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.ImageOptions.Image")));
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhanVien_ItemClick);
            // 
            // btn_LapPhieu
            // 
            this.btn_LapPhieu.Caption = "Lập phiếu nhập/ xuất";
            this.btn_LapPhieu.Id = 5;
            this.btn_LapPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LapPhieu.ImageOptions.Image")));
            this.btn_LapPhieu.Name = "btn_LapPhieu";
            this.btn_LapPhieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_LapPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LapPhieu_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Phiếu các nv lập trong năm";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_LapDDH
            // 
            this.btn_LapDDH.Caption = "Lập đơn đặt hàng";
            this.btn_LapDDH.Id = 11;
            this.btn_LapDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LapDDH.ImageOptions.Image")));
            this.btn_LapDDH.Name = "btn_LapDDH";
            this.btn_LapDDH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_LapDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LapDDH_ItemClick);
            // 
            // btn_InDSNV
            // 
            this.btn_InDSNV.Caption = "In danh sách Nhân viên";
            this.btn_InDSNV.Id = 12;
            this.btn_InDSNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InDSNV.ImageOptions.Image")));
            this.btn_InDSNV.Name = "btn_InDSNV";
            this.btn_InDSNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_InVT
            // 
            this.btn_InVT.Caption = "In danh mục vật tư";
            this.btn_InVT.Id = 16;
            this.btn_InVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InVT.ImageOptions.Image")));
            this.btn_InVT.Name = "btn_InVT";
            this.btn_InVT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_InBangKeNX
            // 
            this.btn_InBangKeNX.Caption = "In bảng kê nhập xuất";
            this.btn_InBangKeNX.Id = 17;
            this.btn_InBangKeNX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InBangKeNX.ImageOptions.Image")));
            this.btn_InBangKeNX.Name = "btn_InBangKeNX";
            this.btn_InBangKeNX.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đơn đặt hàng chưa có phiếu nhập";
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tình hình hoạt động của NV";
            this.barButtonItem3.Id = 19;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tổng hợp nhập xuất";
            this.barButtonItem4.Id = 20;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Tình hình nhập xuất";
            this.barButtonItem5.Id = 21;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_VatTu
            // 
            this.btn_VatTu.Caption = "Vật tư";
            this.btn_VatTu.Id = 22;
            this.btn_VatTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_VatTu.ImageOptions.Image")));
            this.btn_VatTu.Name = "btn_VatTu";
            this.btn_VatTu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_VatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_VatTu_ItemClick);
            // 
            // btn_Kho
            // 
            this.btn_Kho.Caption = "Kho";
            this.btn_Kho.Id = 23;
            this.btn_Kho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kho.ImageOptions.Image")));
            this.btn_Kho.Name = "btn_Kho";
            this.btn_Kho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Kho_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "TEST";
            this.barButtonItem6.Id = 24;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // rib_HeThong
            // 
            this.rib_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rib_HeThong.Name = "rib_HeThong";
            this.rib_HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_TaoTaiKhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rib_DanhMuc
            // 
            this.rib_DanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rib_DanhMuc.Name = "rib_DanhMuc";
            this.rib_DanhMuc.Text = "Danh mục";
            this.rib_DanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_VatTu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Kho);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rib_NghiepVu
            // 
            this.rib_NghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.rib_NghiepVu.Name = "rib_NghiepVu";
            this.rib_NghiepVu.Text = "Nghiệp vụ";
            this.rib_NghiepVu.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_LapPhieu);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_LapDDH);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // rib_BaoCao
            // 
            this.rib_BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rib_BaoCao.Name = "rib_BaoCao";
            this.rib_BaoCao.Text = "Báo cáo";
            this.rib_BaoCao.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_InDSNV);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_InVT);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_InBangKeNX);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1602, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(52, 20);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 608);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ VẬT TƯ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.BarButtonItem btn_NhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_LapPhieu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_DanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_NghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btn_LapDDH;
        private DevExpress.XtraBars.BarButtonItem btn_InDSNV;
        private DevExpress.XtraBars.BarButtonItem btn_InVT;
        private DevExpress.XtraBars.BarButtonItem btn_InBangKeNX;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        public DevExpress.XtraBars.BarButtonItem btn_DangNhap;
        private DevExpress.XtraBars.BarButtonItem btn_VatTu;
        private DevExpress.XtraBars.BarButtonItem btn_Kho;
        public DevExpress.XtraBars.BarButtonItem btn_TaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

