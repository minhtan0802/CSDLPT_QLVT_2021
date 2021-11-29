
namespace QLVT
{
    partial class frmDonDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.DS = new QLVT.DS();
            this.datHangTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.gc_DatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView_DatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bds_spgetCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.panelCtrl_DatHang = new DevExpress.XtraEditors.PanelControl();
            this.label_Kho = new System.Windows.Forms.Label();
            this.cmb_MaKho = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_MaNV = new DevExpress.XtraEditors.TextEdit();
            this.txt_NCC = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit_NgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txt_MDDH = new DevExpress.XtraEditors.TextEdit();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ThemCTDDH = new DevExpress.XtraEditors.SimpleButton();
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.groupBox_CTDDH = new System.Windows.Forms.GroupBox();
            this.gc_sp_getCTPhieu = new DevExpress.XtraGrid.GridControl();
            this.bds_sp_getCTPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_getCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_XoaCTDDH = new DevExpress.XtraEditors.SimpleButton();
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.sp_getVatTuChuaCoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getVatTuChuaCoTableAdapter = new QLVT.DSTableAdapters.sp_getVatTuChuaCoTableAdapter();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.CTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.sp_getCTDDHTableAdapter = new QLVT.DSTableAdapters.sp_getCTDDHTableAdapter();
            this.sp_getCTPhieuTableAdapter = new QLVT.DSTableAdapters.sp_getCTPhieuTableAdapter();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_spgetCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_DatHang)).BeginInit();
            this.panelCtrl_DatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            this.groupBox_CTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_sp_getCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_getCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuChuaCoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(65, 33);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(65, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã ĐĐH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(334, 33);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(68, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày lập:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(72, 99);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(60, 17);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà CC:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(348, 97);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(54, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã NV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(364, 221);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(0, 17);
            mAKHOLabel.TabIndex = 10;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnRefresh,
            this.barListItem1,
            this.btnThoat});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1621, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 720);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1621, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 663);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1621, 57);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 663);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "DANH SÁCH NHÂN VIÊN";
            this.barListItem1.Id = 6;
            this.barListItem1.Name = "barListItem1";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DatHang";
            this.bdsDatHang.DataSource = this.DS;
            // 
            // gc_DatHang
            // 
            this.gc_DatHang.DataSource = this.bdsDatHang;
            this.gc_DatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_DatHang.Location = new System.Drawing.Point(0, 107);
            this.gc_DatHang.MainView = this.gridView_DatHang;
            this.gc_DatHang.MenuManager = this.barManager1;
            this.gc_DatHang.Name = "gc_DatHang";
            this.gc_DatHang.Size = new System.Drawing.Size(1621, 251);
            this.gc_DatHang.TabIndex = 19;
            this.gc_DatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DatHang});
            this.gc_DatHang.Click += new System.EventHandler(this.datHangGridControl_Click);
            this.gc_DatHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gc_DatHang_KeyDown);
            this.gc_DatHang.MouseCaptureChanged += new System.EventHandler(this.datHangGridControl_MouseCaptureChanged);
            this.gc_DatHang.Move += new System.EventHandler(this.gc_DatHang_Move);
            // 
            // gridView_DatHang
            // 
            this.gridView_DatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView_DatHang.GridControl = this.gc_DatHang;
            this.gridView_DatHang.Name = "gridView_DatHang";
            this.gridView_DatHang.OptionsBehavior.Editable = false;
            this.gridView_DatHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_DatHang_FocusedRowChanged);
            this.gridView_DatHang.ColumnFilterChanged += new System.EventHandler(this.gridView_DatHang_ColumnFilterChanged);
            this.gridView_DatHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView_DatHang_KeyPress);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã ĐĐH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 127;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà cung cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // bds_spgetCTDDH
            // 
            this.bds_spgetCTDDH.DataMember = "sp_getCTDDH";
            this.bds_spgetCTDDH.DataSource = this.DS;
            // 
            // panelCtrl_DatHang
            // 
            this.panelCtrl_DatHang.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelCtrl_DatHang.Appearance.Options.UseBackColor = true;
            this.panelCtrl_DatHang.Controls.Add(mAKHOLabel);
            this.panelCtrl_DatHang.Controls.Add(this.label_Kho);
            this.panelCtrl_DatHang.Controls.Add(this.cmb_MaKho);
            this.panelCtrl_DatHang.Controls.Add(mANVLabel);
            this.panelCtrl_DatHang.Controls.Add(this.txt_MaNV);
            this.panelCtrl_DatHang.Controls.Add(nhaCCLabel);
            this.panelCtrl_DatHang.Controls.Add(this.txt_NCC);
            this.panelCtrl_DatHang.Controls.Add(nGAYLabel);
            this.panelCtrl_DatHang.Controls.Add(this.dateEdit_NgayLap);
            this.panelCtrl_DatHang.Controls.Add(masoDDHLabel);
            this.panelCtrl_DatHang.Controls.Add(this.txt_MDDH);
            this.panelCtrl_DatHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCtrl_DatHang.Enabled = false;
            this.panelCtrl_DatHang.Location = new System.Drawing.Point(0, 358);
            this.panelCtrl_DatHang.Name = "panelCtrl_DatHang";
            this.panelCtrl_DatHang.Size = new System.Drawing.Size(850, 362);
            this.panelCtrl_DatHang.TabIndex = 30;
            this.panelCtrl_DatHang.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCtrl_DatHang_Paint);
            // 
            // label_Kho
            // 
            this.label_Kho.AutoSize = true;
            this.label_Kho.Location = new System.Drawing.Point(74, 153);
            this.label_Kho.Name = "label_Kho";
            this.label_Kho.Size = new System.Drawing.Size(58, 17);
            this.label_Kho.TabIndex = 10;
            this.label_Kho.Text = "Mã kho:";
            // 
            // cmb_MaKho
            // 
            this.cmb_MaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDatHang, "MAKHO", true));
            this.cmb_MaKho.DataSource = this.khoBindingSource;
            this.cmb_MaKho.DisplayMember = "TENKHO";
            this.cmb_MaKho.Enabled = false;
            this.cmb_MaKho.FormattingEnabled = true;
            this.cmb_MaKho.Location = new System.Drawing.Point(140, 150);
            this.cmb_MaKho.Name = "cmb_MaKho";
            this.cmb_MaKho.Size = new System.Drawing.Size(123, 24);
            this.cmb_MaKho.TabIndex = 9;
            this.cmb_MaKho.ValueMember = "MAKHO";
            this.cmb_MaKho.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_MaKho_Validating);
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.DS;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MANV", true));
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(408, 94);
            this.txt_MaNV.MenuManager = this.barManager1;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(125, 26);
            this.txt_MaNV.TabIndex = 7;
            // 
            // txt_NCC
            // 
            this.txt_NCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NhaCC", true));
            this.txt_NCC.Location = new System.Drawing.Point(138, 96);
            this.txt_NCC.MenuManager = this.barManager1;
            this.txt_NCC.Name = "txt_NCC";
            this.txt_NCC.Size = new System.Drawing.Size(125, 26);
            this.txt_NCC.TabIndex = 5;
            this.txt_NCC.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txt_NCC_EditValueChanging);
            this.txt_NCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NCC_KeyPress);
            this.txt_NCC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_NCC_KeyUp);
            this.txt_NCC.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NCC_Validating);
            // 
            // dateEdit_NgayLap
            // 
            this.dateEdit_NgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NGAY", true));
            this.dateEdit_NgayLap.EditValue = null;
            this.dateEdit_NgayLap.Enabled = false;
            this.dateEdit_NgayLap.Location = new System.Drawing.Point(408, 30);
            this.dateEdit_NgayLap.MenuManager = this.barManager1;
            this.dateEdit_NgayLap.Name = "dateEdit_NgayLap";
            this.dateEdit_NgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayLap.Size = new System.Drawing.Size(125, 26);
            this.dateEdit_NgayLap.TabIndex = 3;
            // 
            // txt_MDDH
            // 
            this.txt_MDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MasoDDH", true));
            this.txt_MDDH.Enabled = false;
            this.txt_MDDH.Location = new System.Drawing.Point(138, 30);
            this.txt_MDDH.MenuManager = this.barManager1;
            this.txt_MDDH.Name = "txt_MDDH";
            this.txt_MDDH.Size = new System.Drawing.Size(125, 26);
            this.txt_MDDH.TabIndex = 1;
            this.txt_MDDH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MDDH_KeyPress);
            this.txt_MDDH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MDDH_Validating);
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // btn_ThemCTDDH
            // 
            this.btn_ThemCTDDH.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_ThemCTDDH.Appearance.Options.UseBackColor = true;
            this.btn_ThemCTDDH.Location = new System.Drawing.Point(251, 299);
            this.btn_ThemCTDDH.Name = "btn_ThemCTDDH";
            this.btn_ThemCTDDH.Size = new System.Drawing.Size(185, 43);
            this.btn_ThemCTDDH.TabIndex = 15;
            this.btn_ThemCTDDH.Text = "Thêm chi tiết đơn đặt hàng";
            this.btn_ThemCTDDH.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox_CTDDH
            // 
            this.groupBox_CTDDH.Controls.Add(this.gc_sp_getCTPhieu);
            this.groupBox_CTDDH.Controls.Add(this.btn_ThemCTDDH);
            this.groupBox_CTDDH.Controls.Add(this.btn_XoaCTDDH);
            this.groupBox_CTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_CTDDH.Location = new System.Drawing.Point(850, 358);
            this.groupBox_CTDDH.Name = "groupBox_CTDDH";
            this.groupBox_CTDDH.Size = new System.Drawing.Size(771, 362);
            this.groupBox_CTDDH.TabIndex = 39;
            this.groupBox_CTDDH.TabStop = false;
            this.groupBox_CTDDH.Text = "Chi tiết đơn đặt hàng";
            // 
            // gc_sp_getCTPhieu
            // 
            this.gc_sp_getCTPhieu.DataSource = this.bds_sp_getCTPhieu;
            this.gc_sp_getCTPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_sp_getCTPhieu.Location = new System.Drawing.Point(3, 18);
            this.gc_sp_getCTPhieu.MainView = this.gridView_getCTDDH;
            this.gc_sp_getCTPhieu.MenuManager = this.barManager1;
            this.gc_sp_getCTPhieu.Name = "gc_sp_getCTPhieu";
            this.gc_sp_getCTPhieu.Size = new System.Drawing.Size(765, 254);
            this.gc_sp_getCTPhieu.TabIndex = 35;
            this.gc_sp_getCTPhieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_getCTDDH});
            this.gc_sp_getCTPhieu.EditorKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gc_sp_getCTPhieu_EditorKeyPress);
            // 
            // bds_sp_getCTPhieu
            // 
            this.bds_sp_getCTPhieu.DataMember = "sp_getCTPhieu";
            this.bds_sp_getCTPhieu.DataSource = this.DS;
            // 
            // gridView_getCTDDH
            // 
            this.gridView_getCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDONGIA,
            this.colSOLUONG});
            this.gridView_getCTDDH.GridControl = this.gc_sp_getCTPhieu;
            this.gridView_getCTDDH.Name = "gridView_getCTDDH";
            this.gridView_getCTDDH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView_getCTDDH_KeyPress_1);
            this.gridView_getCTDDH.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView_getCTDDH_ValidatingEditor_1);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên VT";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.DisplayFormat.FormatString = "n0";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            this.colDONGIA.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.DisplayFormat.FormatString = "n0";
            this.colSOLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 3;
            this.colSOLUONG.Width = 94;
            // 
            // btn_XoaCTDDH
            // 
            this.btn_XoaCTDDH.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_XoaCTDDH.Appearance.Options.UseBackColor = true;
            this.btn_XoaCTDDH.Location = new System.Drawing.Point(501, 299);
            this.btn_XoaCTDDH.Name = "btn_XoaCTDDH";
            this.btn_XoaCTDDH.Size = new System.Drawing.Size(137, 43);
            this.btn_XoaCTDDH.TabIndex = 35;
            this.btn_XoaCTDDH.Text = "Xóa";
            this.btn_XoaCTDDH.Click += new System.EventHandler(this.btn_XoaCTDDH_Click);
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getVatTuChuaCoBindingSource
            // 
            this.sp_getVatTuChuaCoBindingSource.DataMember = "sp_getVatTuChuaCo";
            this.sp_getVatTuChuaCoBindingSource.DataSource = this.DS;
            // 
            // sp_getVatTuChuaCoTableAdapter
            // 
            this.sp_getVatTuChuaCoTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPN.DataSource = this.bdsDatHang;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDatHang;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1621, 50);
            this.panelControl1.TabIndex = 44;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chi nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(134, 15);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(323, 24);
            this.cmbChiNhanh.TabIndex = 5;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // sp_getCTDDHTableAdapter
            // 
            this.sp_getCTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getCTPhieuTableAdapter
            // 
            this.sp_getCTPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 747);
            this.Controls.Add(this.groupBox_CTDDH);
            this.Controls.Add(this.panelCtrl_DatHang);
            this.Controls.Add(this.gc_DatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDonDatHang";
            this.Text = "ĐƠN ĐẶT HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_spgetCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_DatHang)).EndInit();
            this.panelCtrl_DatHang.ResumeLayout(false);
            this.panelCtrl_DatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            this.groupBox_CTDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_sp_getCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_getCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuChuaCoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DatHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl panelCtrl_DatHang;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.GroupBox groupBox_CTDDH;
        public DevExpress.XtraBars.BarButtonItem btnThem;
        public DevExpress.XtraBars.BarButtonItem btnGhi;
        public DevExpress.XtraBars.BarButtonItem btnXoa;
        public DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraEditors.TextEdit txt_MaNV;
        private DevExpress.XtraEditors.TextEdit txt_NCC;
        private DevExpress.XtraEditors.DateEdit dateEdit_NgayLap;
        private DevExpress.XtraEditors.TextEdit txt_MDDH;
        private System.Windows.Forms.BindingSource sp_getVatTuChuaCoBindingSource;
        private DSTableAdapters.sp_getVatTuChuaCoTableAdapter sp_getVatTuChuaCoTableAdapter;
       
        public DS DS;
        public DevExpress.XtraEditors.SimpleButton btn_ThemCTDDH;
        public DevExpress.XtraEditors.SimpleButton btn_XoaCTDDH;
        private System.Windows.Forms.BindingSource bdsPN;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        public DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label_Kho;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        public System.Windows.Forms.BindingSource bds_spgetCTDDH;
        public DevExpress.XtraGrid.GridControl gc_DatHang;
        private DSTableAdapters.sp_getCTDDHTableAdapter sp_getCTDDHTableAdapter;
        private DSTableAdapters.sp_getCTPhieuTableAdapter sp_getCTPhieuTableAdapter;
        private DevExpress.XtraGrid.GridControl gc_sp_getCTPhieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_getCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        public System.Windows.Forms.BindingSource bds_sp_getCTPhieu;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.ComboBox cmb_MaKho;

        public DSTableAdapters.sp_getCTDDHTableAdapter Sp_getCTDDHTableAdapter { get => sp_getCTDDHTableAdapter; set => sp_getCTDDHTableAdapter = value; }
    }
}