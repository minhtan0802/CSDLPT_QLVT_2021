
namespace QLVT
{
    partial class frmVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.DS = new QLVT.DS();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.VatTuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tb_MaVatTu = new System.Windows.Forms.TextBox();
            this.tb_TenVatTu = new System.Windows.Forms.TextBox();
            this.tb_DonViTinh = new System.Windows.Forms.TextBox();
            this.nud_SoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.panelCtrl_VatTu = new DevExpress.XtraEditors.PanelControl();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.CTPXTableAdapter = new QLVT.DSTableAdapters.CTPXTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.CTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.CTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuongTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_VatTu)).BeginInit();
            this.panelCtrl_VatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(147, 41);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(70, 17);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(141, 106);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(76, 17);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên vật tư:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(454, 41);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(79, 17);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(445, 100);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(92, 17);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số lượng tồn:";
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
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnRefresh,
            this.barListItem1,
            this.btnThoat,
            this.btnDSNV});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDSNV),
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
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
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
            // btnDSNV
            // 
            this.btnDSNV.Caption = "In danh sách vật tư";
            this.btnDSNV.Id = 8;
            this.btnDSNV.Name = "btnDSNV";
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
            this.barDockControlTop.Size = new System.Drawing.Size(809, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 593);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(809, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 563);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(809, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 563);
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
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // VatTuTableAdapter
            // 
            this.VatTuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.VatTuTableAdapter;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVatTu;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVatTu.Location = new System.Drawing.Point(0, 30);
            this.gcVatTu.MainView = this.gridView1;
            this.gcVatTu.MenuManager = this.barManager1;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(809, 233);
            this.gcVatTu.TabIndex = 5;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.gcVatTu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 25;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 94;
            // 
            // tb_MaVatTu
            // 
            this.tb_MaVatTu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "MAVT", true));
            this.tb_MaVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaVatTu.Location = new System.Drawing.Point(223, 38);
            this.tb_MaVatTu.Name = "tb_MaVatTu";
            this.tb_MaVatTu.Size = new System.Drawing.Size(174, 22);
            this.tb_MaVatTu.TabIndex = 1;
            // 
            // tb_TenVatTu
            // 
            this.tb_TenVatTu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "TENVT", true));
            this.tb_TenVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenVatTu.Location = new System.Drawing.Point(223, 97);
            this.tb_TenVatTu.Name = "tb_TenVatTu";
            this.tb_TenVatTu.Size = new System.Drawing.Size(174, 22);
            this.tb_TenVatTu.TabIndex = 3;
            // 
            // tb_DonViTinh
            // 
            this.tb_DonViTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "DVT", true));
            this.tb_DonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DonViTinh.Location = new System.Drawing.Point(563, 38);
            this.tb_DonViTinh.Name = "tb_DonViTinh";
            this.tb_DonViTinh.Size = new System.Drawing.Size(174, 22);
            this.tb_DonViTinh.TabIndex = 5;
            // 
            // nud_SoLuongTon
            // 
            this.nud_SoLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsVatTu, "SOLUONGTON", true));
            this.nud_SoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SoLuongTon.Location = new System.Drawing.Point(563, 97);
            this.nud_SoLuongTon.Name = "nud_SoLuongTon";
            this.nud_SoLuongTon.Size = new System.Drawing.Size(80, 22);
            this.nud_SoLuongTon.TabIndex = 7;
            // 
            // panelCtrl_VatTu
            // 
            this.panelCtrl_VatTu.Controls.Add(sOLUONGTONLabel);
            this.panelCtrl_VatTu.Controls.Add(this.nud_SoLuongTon);
            this.panelCtrl_VatTu.Controls.Add(dVTLabel);
            this.panelCtrl_VatTu.Controls.Add(this.tb_DonViTinh);
            this.panelCtrl_VatTu.Controls.Add(tENVTLabel);
            this.panelCtrl_VatTu.Controls.Add(this.tb_TenVatTu);
            this.panelCtrl_VatTu.Controls.Add(mAVTLabel);
            this.panelCtrl_VatTu.Controls.Add(this.tb_MaVatTu);
            this.panelCtrl_VatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrl_VatTu.Location = new System.Drawing.Point(0, 263);
            this.panelCtrl_VatTu.Name = "panelCtrl_VatTu";
            this.panelCtrl_VatTu.Size = new System.Drawing.Size(809, 330);
            this.panelCtrl_VatTu.TabIndex = 6;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVatTu;
            // 
            // CTPXTableAdapter
            // 
            this.CTPXTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVatTu;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDDH.DataSource = this.bdsVatTu;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // frmVatTu
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 613);
            this.Controls.Add(this.panelCtrl_VatTu);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VẬT TƯ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuongTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrl_VatTu)).EndInit();
            this.panelCtrl_VatTu.ResumeLayout(false);
            this.panelCtrl_VatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnDSNV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DS DS;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DSTableAdapters.VattuTableAdapter VatTuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.PanelControl panelCtrl_VatTu;
        private System.Windows.Forms.NumericUpDown nud_SoLuongTon;
        private System.Windows.Forms.TextBox tb_DonViTinh;
        private System.Windows.Forms.TextBox tb_TenVatTu;
        private System.Windows.Forms.TextBox tb_MaVatTu;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DSTableAdapters.CTPXTableAdapter CTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
    }
}