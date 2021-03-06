
namespace QLVT
{
    partial class frmPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
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
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.CTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.PhieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.gc_DDH = new DevExpress.XtraGrid.GridControl();
            this.gridView_DDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCtrl_CTPN = new DevExpress.XtraEditors.PanelControl();
            this.gc_sp_getCTPhieu = new DevExpress.XtraGrid.GridControl();
            this.bds_sp_getCTPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_CTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_xoaCTPN = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemCTPN = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.bds_spgetCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTPNPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.panelCtrl_PN = new DevExpress.XtraEditors.PanelControl();
            this.panelCtrl_ThemPN = new DevExpress.XtraEditors.PanelControl();
            this.label_Kho = new System.Windows.Forms.Label();
            this.txt_MaNV = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaSoDDH = new DevExpress.XtraEditors.TextEdit();
            this.txt_date = new DevExpress.XtraEditors.DateEdit();
            this.txt_MaPN = new DevExpress.XtraEditors.TextEdit();
            this.cmb_Kho2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_PhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView_PN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.sp_getCTPNTableAdapter = new QLVT.DSTableAdapters.sp_getCTPNTableAdapter();
            this.panelCtrl_DDH = new DevExpress.XtraEditors.PanelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.bds_sp_getCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTDDHTableAdapter = new QLVT.DSTableAdapters.sp_getCTDDHTableAdapter();
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTPhieuTableAdapter = new QLVT.DSTableAdapters.sp_getCTPhieuTableAdapter();
            this.sp_getVatTuConThieuCTPhieuTableAdapter = new QLVT.DSTableAdapters.sp_getVatTuConThieuCTPhieuTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_CTPN)).BeginInit();
            this.panelCtrl_CTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_sp_getCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_spgetCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_PN)).BeginInit();
            this.panelCtrl_PN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_ThemPN)).BeginInit();
            this.panelCtrl_ThemPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Kho2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_DDH)).BeginInit();
            this.panelCtrl_DDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(65, 37);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(54, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã PN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(328, 69);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(68, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày lập:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(328, 32);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(65, 17);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Mã ĐĐH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(577, 35);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(77, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã NV lập:";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
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
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1608, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 754);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1608, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 697);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1608, 57);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 697);
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
            // bdsDH
            // 
            this.bdsDH.DataMember = "DatHang";
            this.bdsDH.DataSource = this.DS;
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
            this.tableAdapterManager.CTPNTableAdapter = this.CTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.PhieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // PhieuNhapTableAdapter
            // 
            this.PhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // gc_DDH
            // 
            this.gc_DDH.DataSource = this.bdsDH;
            this.gc_DDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_DDH.Location = new System.Drawing.Point(0, 47);
            this.gc_DDH.MainView = this.gridView_DDH;
            this.gc_DDH.MenuManager = this.barManager1;
            this.gc_DDH.Name = "gc_DDH";
            this.gc_DDH.Size = new System.Drawing.Size(737, 515);
            this.gc_DDH.TabIndex = 5;
            this.gc_DDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DDH});
            this.gc_DDH.Click += new System.EventHandler(this.gc_DDH_Click);
            this.gc_DDH.MouseCaptureChanged += new System.EventHandler(this.datHangGridControl_MouseCaptureChanged);
            // 
            // gridView_DDH
            // 
            this.gridView_DDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView_DDH.GridControl = this.gc_DDH;
            this.gridView_DDH.Name = "gridView_DDH";
            this.gridView_DDH.OptionsBehavior.Editable = false;
            this.gridView_DDH.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_DDH_FocusedRowChanged);
            this.gridView_DDH.ColumnFilterChanged += new System.EventHandler(this.gridView_DDH_ColumnFilterChanged);
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
            this.colMasoDDH.Width = 107;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày lập";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà CC";
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
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // panelCtrl_CTPN
            // 
            this.panelCtrl_CTPN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCtrl_CTPN.Controls.Add(this.gc_sp_getCTPhieu);
            this.panelCtrl_CTPN.Controls.Add(this.btn_xoaCTPN);
            this.panelCtrl_CTPN.Controls.Add(this.btn_ThemCTPN);
            this.panelCtrl_CTPN.Controls.Add(this.panelControl4);
            this.panelCtrl_CTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrl_CTPN.Location = new System.Drawing.Point(0, 286);
            this.panelCtrl_CTPN.Name = "panelCtrl_CTPN";
            this.panelCtrl_CTPN.Size = new System.Drawing.Size(871, 361);
            this.panelCtrl_CTPN.TabIndex = 11;
            // 
            // gc_sp_getCTPhieu
            // 
            this.gc_sp_getCTPhieu.DataSource = this.bds_sp_getCTPhieu;
            this.gc_sp_getCTPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_sp_getCTPhieu.Location = new System.Drawing.Point(0, 47);
            this.gc_sp_getCTPhieu.MainView = this.gridView_CTPN;
            this.gc_sp_getCTPhieu.MenuManager = this.barManager1;
            this.gc_sp_getCTPhieu.Name = "gc_sp_getCTPhieu";
            this.gc_sp_getCTPhieu.Size = new System.Drawing.Size(871, 172);
            this.gc_sp_getCTPhieu.TabIndex = 11;
            this.gc_sp_getCTPhieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CTPN});
            this.gc_sp_getCTPhieu.EditorKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sp_getCTPhieuGridControl_EditorKeyPress);
            this.gc_sp_getCTPhieu.MouseCaptureChanged += new System.EventHandler(this.sp_getCTPhieuGridControl_MouseCaptureChanged);
            this.gc_sp_getCTPhieu.Validating += new System.ComponentModel.CancelEventHandler(this.sp_getCTPhieuGridControl_Validating);
            // 
            // bds_sp_getCTPhieu
            // 
            this.bds_sp_getCTPhieu.DataMember = "sp_getCTPhieu";
            this.bds_sp_getCTPhieu.DataSource = this.DS;
            // 
            // gridView_CTPN
            // 
            this.gridView_CTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDONGIA,
            this.colSOLUONG});
            this.gridView_CTPN.GridControl = this.gc_sp_getCTPhieu;
            this.gridView_CTPN.Name = "gridView_CTPN";
            this.gridView_CTPN.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_CTPN_FocusedRowChanged);
            this.gridView_CTPN.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CTPN_CellValueChanging);
            this.gridView_CTPN.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_CTPN_ValidateRow);
            this.gridView_CTPN.MouseLeave += new System.EventHandler(this.gridView_CTPN_MouseLeave);
            this.gridView_CTPN.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView_CTPN_ValidatingEditor_1);
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
            // btn_xoaCTPN
            // 
            this.btn_xoaCTPN.Enabled = false;
            this.btn_xoaCTPN.Location = new System.Drawing.Point(445, 240);
            this.btn_xoaCTPN.Name = "btn_xoaCTPN";
            this.btn_xoaCTPN.Size = new System.Drawing.Size(94, 29);
            this.btn_xoaCTPN.TabIndex = 11;
            this.btn_xoaCTPN.Text = "Xóa";
            this.btn_xoaCTPN.Click += new System.EventHandler(this.btn_xoaCTPN_Click);
            // 
            // btn_ThemCTPN
            // 
            this.btn_ThemCTPN.Enabled = false;
            this.btn_ThemCTPN.Location = new System.Drawing.Point(309, 240);
            this.btn_ThemCTPN.Name = "btn_ThemCTPN";
            this.btn_ThemCTPN.Size = new System.Drawing.Size(94, 29);
            this.btn_ThemCTPN.TabIndex = 10;
            this.btn_ThemCTPN.Text = "Thêm CTPN";
            this.btn_ThemCTPN.Click += new System.EventHandler(this.btn_ThemCTPN_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.label3);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(871, 47);
            this.panelControl4.TabIndex = 9;
            this.panelControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "CHI TIẾT PHIẾU NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bds_spgetCTPN
            // 
            this.bds_spgetCTPN.DataMember = "sp_getCTPN";
            this.bds_spgetCTPN.DataSource = this.DS;
            // 
            // fKCTPNPhieuNhapBindingSource
            // 
            this.fKCTPNPhieuNhapBindingSource.DataMember = "FK_CTPN_PhieuNhap";
            this.fKCTPNPhieuNhapBindingSource.DataSource = this.bdsPN;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPN.DataSource = this.bdsDH;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.cmbChiNhanh);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 57);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1608, 50);
            this.panelControl2.TabIndex = 45;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
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
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Enabled = false;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(134, 15);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(323, 24);
            this.cmbChiNhanh.TabIndex = 5;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // panelCtrl_PN
            // 
            this.panelCtrl_PN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCtrl_PN.Controls.Add(this.panelCtrl_CTPN);
            this.panelCtrl_PN.Controls.Add(this.panelCtrl_ThemPN);
            this.panelCtrl_PN.Controls.Add(this.gc_PhieuNhap);
            this.panelCtrl_PN.Controls.Add(this.panelControl5);
            this.panelCtrl_PN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrl_PN.Location = new System.Drawing.Point(737, 107);
            this.panelCtrl_PN.Name = "panelCtrl_PN";
            this.panelCtrl_PN.Size = new System.Drawing.Size(871, 647);
            this.panelCtrl_PN.TabIndex = 46;
            this.panelCtrl_PN.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCtrl_PN_Paint);
            // 
            // panelCtrl_ThemPN
            // 
            this.panelCtrl_ThemPN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCtrl_ThemPN.Controls.Add(this.label_Kho);
            this.panelCtrl_ThemPN.Controls.Add(mANVLabel);
            this.panelCtrl_ThemPN.Controls.Add(this.txt_MaNV);
            this.panelCtrl_ThemPN.Controls.Add(masoDDHLabel);
            this.panelCtrl_ThemPN.Controls.Add(this.txt_MaSoDDH);
            this.panelCtrl_ThemPN.Controls.Add(nGAYLabel);
            this.panelCtrl_ThemPN.Controls.Add(this.txt_date);
            this.panelCtrl_ThemPN.Controls.Add(mAPNLabel);
            this.panelCtrl_ThemPN.Controls.Add(this.txt_MaPN);
            this.panelCtrl_ThemPN.Controls.Add(this.cmb_Kho2);
            this.panelCtrl_ThemPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCtrl_ThemPN.Enabled = false;
            this.panelCtrl_ThemPN.Location = new System.Drawing.Point(0, 154);
            this.panelCtrl_ThemPN.Name = "panelCtrl_ThemPN";
            this.panelCtrl_ThemPN.Size = new System.Drawing.Size(871, 132);
            this.panelCtrl_ThemPN.TabIndex = 12;
            // 
            // label_Kho
            // 
            this.label_Kho.AutoSize = true;
            this.label_Kho.Location = new System.Drawing.Point(61, 75);
            this.label_Kho.Name = "label_Kho";
            this.label_Kho.Size = new System.Drawing.Size(58, 17);
            this.label_Kho.TabIndex = 10;
            this.label_Kho.Text = "Mã kho:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MANV", true));
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(660, 29);
            this.txt_MaNV.MenuManager = this.barManager1;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(125, 26);
            this.txt_MaNV.TabIndex = 7;
            // 
            // txt_MaSoDDH
            // 
            this.txt_MaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MasoDDH", true));
            this.txt_MaSoDDH.Enabled = false;
            this.txt_MaSoDDH.Location = new System.Drawing.Point(414, 29);
            this.txt_MaSoDDH.MenuManager = this.barManager1;
            this.txt_MaSoDDH.Name = "txt_MaSoDDH";
            this.txt_MaSoDDH.Size = new System.Drawing.Size(125, 26);
            this.txt_MaSoDDH.TabIndex = 5;
            this.txt_MaSoDDH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MaSoDDH_Validating);
            // 
            // txt_date
            // 
            this.txt_date.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.txt_date.EditValue = null;
            this.txt_date.Enabled = false;
            this.txt_date.Location = new System.Drawing.Point(415, 66);
            this.txt_date.MenuManager = this.barManager1;
            this.txt_date.Name = "txt_date";
            this.txt_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_date.Size = new System.Drawing.Size(125, 26);
            this.txt_date.TabIndex = 3;
            // 
            // txt_MaPN
            // 
            this.txt_MaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAPN", true));
            this.txt_MaPN.Location = new System.Drawing.Point(122, 34);
            this.txt_MaPN.MenuManager = this.barManager1;
            this.txt_MaPN.Name = "txt_MaPN";
            this.txt_MaPN.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MaPN_Properties_Validating);
            this.txt_MaPN.Size = new System.Drawing.Size(125, 26);
            this.txt_MaPN.TabIndex = 1;
            this.txt_MaPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaPN_KeyPress);
            this.txt_MaPN.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MaPN_Validating);
            this.txt_MaPN.Validated += new System.EventHandler(this.txt_MaPN_Validated);
            // 
            // cmb_Kho2
            // 
            this.cmb_Kho2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAKHO", true));
            this.cmb_Kho2.Location = new System.Drawing.Point(125, 70);
            this.cmb_Kho2.MenuManager = this.barManager1;
            this.cmb_Kho2.Name = "cmb_Kho2";
            this.cmb_Kho2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Kho2.Properties.DataSource = this.bdsKho;
            this.cmb_Kho2.Properties.DisplayMember = "MAKHO";
            this.cmb_Kho2.Properties.NullText = "";
            this.cmb_Kho2.Properties.PopupSizeable = false;
            this.cmb_Kho2.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmb_Kho2.Properties.ValueMember = "MAKHO";
            this.cmb_Kho2.Size = new System.Drawing.Size(125, 26);
            this.cmb_Kho2.TabIndex = 11;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.DS;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gc_PhieuNhap
            // 
            this.gc_PhieuNhap.DataSource = this.bdsPN;
            this.gc_PhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_PhieuNhap.Location = new System.Drawing.Point(0, 47);
            this.gc_PhieuNhap.MainView = this.gridView_PN;
            this.gc_PhieuNhap.MenuManager = this.barManager1;
            this.gc_PhieuNhap.Name = "gc_PhieuNhap";
            this.gc_PhieuNhap.Size = new System.Drawing.Size(871, 107);
            this.gc_PhieuNhap.TabIndex = 10;
            this.gc_PhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PN});
            this.gc_PhieuNhap.MouseCaptureChanged += new System.EventHandler(this.phieuNhapGridControl_MouseCaptureChanged);
            // 
            // gridView_PN
            // 
            this.gridView_PN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY1,
            this.colMasoDDH1,
            this.colMANV1,
            this.colMAKHO1});
            this.gridView_PN.GridControl = this.gc_PhieuNhap;
            this.gridView_PN.Name = "gridView_PN";
            this.gridView_PN.OptionsBehavior.Editable = false;
            this.gridView_PN.OptionsView.ShowGroupPanel = false;
            this.gridView_PN.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView_PN_ValidatingEditor);
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã PN";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 107;
            // 
            // colNGAY1
            // 
            this.colNGAY1.Caption = "Ngày lập";
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.MinWidth = 25;
            this.colNGAY1.Name = "colNGAY1";
            this.colNGAY1.Visible = true;
            this.colNGAY1.VisibleIndex = 1;
            this.colNGAY1.Width = 94;
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.Caption = "Mã ĐĐH";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.MinWidth = 25;
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 2;
            this.colMasoDDH1.Width = 94;
            // 
            // colMANV1
            // 
            this.colMANV1.Caption = "Mã NV ";
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 25;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 3;
            this.colMANV1.Width = 94;
            // 
            // colMAKHO1
            // 
            this.colMAKHO1.Caption = "Mã kho";
            this.colMAKHO1.FieldName = "MAKHO";
            this.colMAKHO1.MinWidth = 25;
            this.colMAKHO1.Name = "colMAKHO1";
            this.colMAKHO1.Visible = true;
            this.colMAKHO1.VisibleIndex = 4;
            this.colMAKHO1.Width = 94;
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.label2);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(871, 47);
            this.panelControl5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "PHIẾU NHẬP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sp_getCTPNTableAdapter
            // 
            this.sp_getCTPNTableAdapter.ClearBeforeFill = true;
            // 
            // panelCtrl_DDH
            // 
            this.panelCtrl_DDH.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCtrl_DDH.Controls.Add(this.gc_DDH);
            this.panelCtrl_DDH.Controls.Add(this.panelControl8);
            this.panelCtrl_DDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCtrl_DDH.Location = new System.Drawing.Point(0, 107);
            this.panelCtrl_DDH.Name = "panelCtrl_DDH";
            this.panelCtrl_DDH.Size = new System.Drawing.Size(737, 647);
            this.panelCtrl_DDH.TabIndex = 56;
            // 
            // panelControl8
            // 
            this.panelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl8.Controls.Add(this.label4);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl8.Location = new System.Drawing.Point(0, 0);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(737, 47);
            this.panelControl8.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "ĐƠN ĐẶT HÀNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.DS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // bds_sp_getCTDDH
            // 
            this.bds_sp_getCTDDH.DataMember = "sp_getCTDDH";
            this.bds_sp_getCTDDH.DataSource = this.DS;
            // 
            // sp_getCTDDHTableAdapter
            // 
            this.sp_getCTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataSource = this.DS;
            this.dSBindingSource.Position = 0;
            // 
            // sp_getCTPhieuTableAdapter
            // 
            this.sp_getCTPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getVatTuConThieuCTPhieuTableAdapter
            // 
            this.sp_getVatTuConThieuCTPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1608, 781);
            this.Controls.Add(this.panelCtrl_PN);
            this.Controls.Add(this.panelCtrl_DDH);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuNhap";
            this.Text = "-";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_CTPN)).EndInit();
            this.panelCtrl_CTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_sp_getCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_spgetCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_PN)).EndInit();
            this.panelCtrl_PN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_ThemPN)).EndInit();
            this.panelCtrl_ThemPN.ResumeLayout(false);
            this.panelCtrl_ThemPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Kho2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_DDH)).EndInit();
            this.panelCtrl_DDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.panelControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        public DevExpress.XtraBars.BarButtonItem btnThem;
        public DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        public DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDH;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_DDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DSTableAdapters.PhieuNhapTableAdapter PhieuNhapTableAdapter;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelCtrl_CTPN;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelCtrl_PN;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraGrid.GridControl gc_PhieuNhap;
        private System.Windows.Forms.BindingSource bdsPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO1;
        private System.Windows.Forms.BindingSource fKCTPNPhieuNhapBindingSource;
        private DevExpress.XtraEditors.PanelControl panelCtrl_DDH;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PanelControl panelCtrl_ThemPN;
        private DevExpress.XtraEditors.TextEdit txt_MaNV;
        private DevExpress.XtraEditors.TextEdit txt_MaSoDDH;
        private DevExpress.XtraEditors.DateEdit txt_date;
        private DevExpress.XtraEditors.TextEdit txt_MaPN;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.Label label_Kho;
        public System.Windows.Forms.BindingSource bds_spgetCTPN;
        public DSTableAdapters.sp_getCTPNTableAdapter sp_getCTPNTableAdapter;
        public DS DS;
        public DevExpress.XtraEditors.SimpleButton btn_ThemCTPN;
        private System.Windows.Forms.BindingSource bds_sp_getCTDDH;
        private DSTableAdapters.sp_getCTDDHTableAdapter sp_getCTDDHTableAdapter;
        public DevExpress.XtraEditors.SimpleButton btn_xoaCTPN;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private DSTableAdapters.sp_getCTPhieuTableAdapter sp_getCTPhieuTableAdapter;
        private DSTableAdapters.sp_getVatTuConThieuCTPhieuTableAdapter sp_getVatTuConThieuCTPhieuTableAdapter;
        private DevExpress.XtraGrid.GridControl gc_sp_getCTPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        public System.Windows.Forms.BindingSource bds_sp_getCTPhieu;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_CTPN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.GridLookUpEdit cmb_Kho2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}