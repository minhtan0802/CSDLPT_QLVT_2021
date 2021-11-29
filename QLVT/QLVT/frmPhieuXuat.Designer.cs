
namespace QLVT
{
    partial class frmPhieuXuat
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuat));
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.DS = new QLVT.DS();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.gc_PhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gridView_PX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCtrl_PX = new DevExpress.XtraEditors.PanelControl();
            this.txt_MaNV = new DevExpress.XtraEditors.TextEdit();
            this.txt_KH = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit_NgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txt_MAPX = new DevExpress.XtraEditors.TextEdit();
            this.label_Kho = new System.Windows.Forms.Label();
            this.cmb_MaKho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_CTPX = new System.Windows.Forms.GroupBox();
            this.sp_getCTPhieuGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_sp_getCTPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_CTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_ThemCTPX = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaCTPX = new DevExpress.XtraEditors.SimpleButton();
            this.bds_getCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTPXTableAdapter = new QLVT.DSTableAdapters.sp_getCTPXTableAdapter();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT.DSTableAdapters.CTPXTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.sp_getCTPhieuTableAdapter = new QLVT.DSTableAdapters.sp_getCTPhieuTableAdapter();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            mANVLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_PX)).BeginInit();
            this.panelCtrl_PX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            this.groupBox_CTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getCTPhieuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_getCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(334, 33);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(68, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày lập:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(32, 33);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(100, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã phiếu xuất:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(52, 80);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(77, 17);
            hOTENKHLabel.TabIndex = 12;
            hOTENKHLabel.Text = "Họ tên KH:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1685, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 708);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1685, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 651);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1685, 57);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 651);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "DANH SÁCH NHÂN VIÊN";
            this.barListItem1.Id = 6;
            this.barListItem1.Name = "barListItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1685, 50);
            this.panelControl1.TabIndex = 45;
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
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.DS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // gc_PhieuXuat
            // 
            this.gc_PhieuXuat.DataSource = this.bdsPX;
            this.gc_PhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_PhieuXuat.Location = new System.Drawing.Point(0, 107);
            this.gc_PhieuXuat.MainView = this.gridView_PX;
            this.gc_PhieuXuat.MenuManager = this.barManager1;
            this.gc_PhieuXuat.Name = "gc_PhieuXuat";
            this.gc_PhieuXuat.Size = new System.Drawing.Size(1685, 220);
            this.gc_PhieuXuat.TabIndex = 46;
            this.gc_PhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PX});
            this.gc_PhieuXuat.Click += new System.EventHandler(this.gc_PhieuXuat_Click);
            this.gc_PhieuXuat.MouseCaptureChanged += new System.EventHandler(this.phieuXuatGridControl_MouseCaptureChanged);
            // 
            // gridView_PX
            // 
            this.gridView_PX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView_PX.GridControl = this.gc_PhieuXuat;
            this.gridView_PX.Name = "gridView_PX";
            this.gridView_PX.OptionsBehavior.Editable = false;
            this.gridView_PX.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNGAY, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_PX.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_PX_FocusedRowChanged);
            // 
            // colMAPX
            // 
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 25;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 107;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 107;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // panelCtrl_PX
            // 
            this.panelCtrl_PX.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelCtrl_PX.Appearance.Options.UseBackColor = true;
            this.panelCtrl_PX.Controls.Add(this.txt_MaNV);
            this.panelCtrl_PX.Controls.Add(hOTENKHLabel);
            this.panelCtrl_PX.Controls.Add(this.txt_KH);
            this.panelCtrl_PX.Controls.Add(this.dateEdit_NgayLap);
            this.panelCtrl_PX.Controls.Add(this.txt_MAPX);
            this.panelCtrl_PX.Controls.Add(this.label_Kho);
            this.panelCtrl_PX.Controls.Add(this.cmb_MaKho);
            this.panelCtrl_PX.Controls.Add(mANVLabel);
            this.panelCtrl_PX.Controls.Add(nGAYLabel);
            this.panelCtrl_PX.Controls.Add(masoDDHLabel);
            this.panelCtrl_PX.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCtrl_PX.Enabled = false;
            this.panelCtrl_PX.Location = new System.Drawing.Point(0, 327);
            this.panelCtrl_PX.Name = "panelCtrl_PX";
            this.panelCtrl_PX.Size = new System.Drawing.Size(946, 381);
            this.panelCtrl_PX.TabIndex = 47;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MANV", true));
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(408, 92);
            this.txt_MaNV.MenuManager = this.barManager1;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(125, 26);
            this.txt_MaNV.TabIndex = 14;
            // 
            // txt_KH
            // 
            this.txt_KH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "HOTENKH", true));
            this.txt_KH.Location = new System.Drawing.Point(138, 77);
            this.txt_KH.MenuManager = this.barManager1;
            this.txt_KH.Name = "txt_KH";
            this.txt_KH.Size = new System.Drawing.Size(125, 26);
            this.txt_KH.TabIndex = 13;
            this.txt_KH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KH_KeyPress);
            this.txt_KH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_KH_Validating);
            // 
            // dateEdit_NgayLap
            // 
            this.dateEdit_NgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.dateEdit_NgayLap.EditValue = null;
            this.dateEdit_NgayLap.Enabled = false;
            this.dateEdit_NgayLap.Location = new System.Drawing.Point(408, 28);
            this.dateEdit_NgayLap.MenuManager = this.barManager1;
            this.dateEdit_NgayLap.Name = "dateEdit_NgayLap";
            this.dateEdit_NgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayLap.Size = new System.Drawing.Size(125, 26);
            this.dateEdit_NgayLap.TabIndex = 12;
            // 
            // txt_MAPX
            // 
            this.txt_MAPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAPX", true));
            this.txt_MAPX.Location = new System.Drawing.Point(138, 30);
            this.txt_MAPX.MenuManager = this.barManager1;
            this.txt_MAPX.Name = "txt_MAPX";
            this.txt_MAPX.Size = new System.Drawing.Size(125, 26);
            this.txt_MAPX.TabIndex = 11;
            this.txt_MAPX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MAPX_KeyPress);
            this.txt_MAPX.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAPX_Validating);
            // 
            // label_Kho
            // 
            this.label_Kho.AutoSize = true;
            this.label_Kho.Location = new System.Drawing.Point(74, 126);
            this.label_Kho.Name = "label_Kho";
            this.label_Kho.Size = new System.Drawing.Size(58, 17);
            this.label_Kho.TabIndex = 10;
            this.label_Kho.Text = "Mã kho:";
            // 
            // cmb_MaKho
            // 
            this.cmb_MaKho.DataSource = this.bdsKho;
            this.cmb_MaKho.DisplayMember = "TENKHO";
            this.cmb_MaKho.Enabled = false;
            this.cmb_MaKho.FormattingEnabled = true;
            this.cmb_MaKho.Location = new System.Drawing.Point(140, 123);
            this.cmb_MaKho.Name = "cmb_MaKho";
            this.cmb_MaKho.Size = new System.Drawing.Size(123, 24);
            this.cmb_MaKho.TabIndex = 9;
            this.cmb_MaKho.ValueMember = "MAKHO";
            this.cmb_MaKho.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_MaKho_Validating);
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.DS;
            // 
            // groupBox_CTPX
            // 
            this.groupBox_CTPX.Controls.Add(this.sp_getCTPhieuGridControl);
            this.groupBox_CTPX.Controls.Add(this.btn_ThemCTPX);
            this.groupBox_CTPX.Controls.Add(this.btn_XoaCTPX);
            this.groupBox_CTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_CTPX.Location = new System.Drawing.Point(946, 327);
            this.groupBox_CTPX.Name = "groupBox_CTPX";
            this.groupBox_CTPX.Size = new System.Drawing.Size(739, 381);
            this.groupBox_CTPX.TabIndex = 48;
            this.groupBox_CTPX.TabStop = false;
            this.groupBox_CTPX.Text = "Chi tiết phiếu xuất";
            // 
            // sp_getCTPhieuGridControl
            // 
            this.sp_getCTPhieuGridControl.DataSource = this.bds_sp_getCTPhieu;
            this.sp_getCTPhieuGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sp_getCTPhieuGridControl.Location = new System.Drawing.Point(3, 18);
            this.sp_getCTPhieuGridControl.MainView = this.gridView_CTPX;
            this.sp_getCTPhieuGridControl.MenuManager = this.barManager1;
            this.sp_getCTPhieuGridControl.Name = "sp_getCTPhieuGridControl";
            this.sp_getCTPhieuGridControl.Size = new System.Drawing.Size(733, 232);
            this.sp_getCTPhieuGridControl.TabIndex = 35;
            this.sp_getCTPhieuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CTPX});
            this.sp_getCTPhieuGridControl.EditorKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sp_getCTPhieuGridControl_EditorKeyPress);
            // 
            // bds_sp_getCTPhieu
            // 
            this.bds_sp_getCTPhieu.DataMember = "sp_getCTPhieu";
            this.bds_sp_getCTPhieu.DataSource = this.DS;
            // 
            // gridView_CTPX
            // 
            this.gridView_CTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDONGIA,
            this.colSOLUONG});
            this.gridView_CTPX.GridControl = this.sp_getCTPhieuGridControl;
            this.gridView_CTPX.Name = "gridView_CTPX";
            this.gridView_CTPX.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView_CTPX_ValidatingEditor_1);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = " Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
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
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            this.colDONGIA.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 3;
            this.colSOLUONG.Width = 94;
            // 
            // btn_ThemCTPX
            // 
            this.btn_ThemCTPX.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_ThemCTPX.Appearance.Options.UseBackColor = true;
            this.btn_ThemCTPX.Enabled = false;
            this.btn_ThemCTPX.Location = new System.Drawing.Point(161, 274);
            this.btn_ThemCTPX.Name = "btn_ThemCTPX";
            this.btn_ThemCTPX.Size = new System.Drawing.Size(185, 43);
            this.btn_ThemCTPX.TabIndex = 15;
            this.btn_ThemCTPX.Text = "Thêm chi tiết phiếu xuất";
            this.btn_ThemCTPX.Click += new System.EventHandler(this.btn_ThemCTPX_Click);
            // 
            // btn_XoaCTPX
            // 
            this.btn_XoaCTPX.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_XoaCTPX.Appearance.Options.UseBackColor = true;
            this.btn_XoaCTPX.Enabled = false;
            this.btn_XoaCTPX.Location = new System.Drawing.Point(422, 274);
            this.btn_XoaCTPX.Name = "btn_XoaCTPX";
            this.btn_XoaCTPX.Size = new System.Drawing.Size(137, 43);
            this.btn_XoaCTPX.TabIndex = 35;
            this.btn_XoaCTPX.Text = "Xóa";
            this.btn_XoaCTPX.Click += new System.EventHandler(this.btn_XoaCTPX_Click);
            // 
            // bds_getCTPX
            // 
            this.bds_getCTPX.DataMember = "sp_getCTPX";
            this.bds_getCTPX.DataSource = this.DS;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // sp_getCTPXTableAdapter
            // 
            this.sp_getCTPXTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "CTPX";
            this.bdsCTPX.DataSource = this.DS;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getCTPhieuTableAdapter
            // 
            this.sp_getCTPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 735);
            this.Controls.Add(this.groupBox_CTPX);
            this.Controls.Add(this.panelCtrl_PX);
            this.Controls.Add(this.gc_PhieuXuat);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuXuat";
            this.Text = "PHIẾU XUẤT";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_PX)).EndInit();
            this.panelCtrl_PX.ResumeLayout(false);
            this.panelCtrl_PX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            this.groupBox_CTPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_getCTPhieuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_getCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        public DevExpress.XtraBars.BarButtonItem btnThem;
        public DevExpress.XtraBars.BarButtonItem btnGhi;
        public DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        public DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.BindingSource bdsPX;
        private DS DS;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_PhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl panelCtrl_PX;
        private System.Windows.Forms.Label label_Kho;
        private System.Windows.Forms.GroupBox groupBox_CTPX;
        public DevExpress.XtraEditors.SimpleButton btn_ThemCTPX;
        public DevExpress.XtraEditors.SimpleButton btn_XoaCTPX;
        private DevExpress.XtraEditors.TextEdit txt_KH;
        private DevExpress.XtraEditors.DateEdit dateEdit_NgayLap;
        private DevExpress.XtraEditors.TextEdit txt_MAPX;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DSTableAdapters.sp_getCTPXTableAdapter sp_getCTPXTableAdapter;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        public System.Windows.Forms.BindingSource bdsVatTu;
        public System.Windows.Forms.BindingSource bdsCTPX;
        public System.Windows.Forms.BindingSource bds_getCTPX;
        private DevExpress.XtraEditors.TextEdit txt_MaNV;
        private System.Windows.Forms.ComboBox cmb_MaKho;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DSTableAdapters.sp_getCTPhieuTableAdapter sp_getCTPhieuTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_getCTPhieuGridControl;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_CTPX;
        public System.Windows.Forms.BindingSource bds_sp_getCTPhieu;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}