
namespace QLVT
{
    partial class frmThemCTDDH
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
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel1;
            System.Windows.Forms.Label dVTLabel;
            this.bds_sp_getCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.groupBox_VT = new System.Windows.Forms.GroupBox();
            this.sp_getVatTuConThieuCTPhieuGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_sp_getVatTuConThieuCTPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_VatTuChuaCo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bds_spgetVTChuaCo = new System.Windows.Forms.BindingSource(this.components);
            this.bds_sp_getVatTuChuaCo = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTDDHTableAdapter = new QLVT.DSTableAdapters.sp_getCTDDHTableAdapter();
            this.sp_getVatTuChuaCoTableAdapter = new QLVT.DSTableAdapters.sp_getVatTuChuaCoTableAdapter();
            this.spin_SoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox_InfoVT = new System.Windows.Forms.GroupBox();
            this.txt_DVT = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenVT = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaVT = new DevExpress.XtraEditors.TextEdit();
            this.spin_DonGia = new DevExpress.XtraEditors.SpinEdit();
            this.spgetCTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTPNTableAdapter = new QLVT.DSTableAdapters.sp_getCTPNTableAdapter();
            this.sp_getVTChuaCoTableAdapter = new QLVT.DSTableAdapters.sp_getVTChuaCoTableAdapter();
            this.sp_getVatTuConThieuCTPhieuTableAdapter = new QLVT.DSTableAdapters.sp_getVatTuConThieuCTPhieuTableAdapter();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel1 = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            this.groupBox_VT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuConThieuCTPhieuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVatTuConThieuCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_VatTuChuaCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_spgetVTChuaCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVatTuChuaCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_SoLuong.Properties)).BeginInit();
            this.groupBox_InfoVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_DonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCTPNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(15, 183);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(25, 243);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(61, 17);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(33, 43);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(53, 17);
            mAVTLabel.TabIndex = 10;
            mAVTLabel.Text = "Mã VT:";
            // 
            // tENVTLabel1
            // 
            tENVTLabel1.AutoSize = true;
            tENVTLabel1.Location = new System.Drawing.Point(25, 93);
            tENVTLabel1.Name = "tENVTLabel1";
            tENVTLabel1.Size = new System.Drawing.Size(59, 17);
            tENVTLabel1.TabIndex = 11;
            tENVTLabel1.Text = "Tên VT:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(33, 142);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(40, 17);
            dVTLabel.TabIndex = 16;
            dVTLabel.Text = "DVT:";
            // 
            // bds_sp_getCTDDH
            // 
            this.bds_sp_getCTDDH.DataMember = "sp_getCTDDH";
            this.bds_sp_getCTDDH.DataSource = this.DS;
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
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // groupBox_VT
            // 
            this.groupBox_VT.Controls.Add(this.sp_getVatTuConThieuCTPhieuGridControl);
            this.groupBox_VT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_VT.Location = new System.Drawing.Point(287, 0);
            this.groupBox_VT.Name = "groupBox_VT";
            this.groupBox_VT.Size = new System.Drawing.Size(582, 402);
            this.groupBox_VT.TabIndex = 3;
            this.groupBox_VT.TabStop = false;
            this.groupBox_VT.Text = "Vật tư";
            // 
            // sp_getVatTuConThieuCTPhieuGridControl
            // 
            this.sp_getVatTuConThieuCTPhieuGridControl.DataSource = this.bds_sp_getVatTuConThieuCTPhieu;
            this.sp_getVatTuConThieuCTPhieuGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_getVatTuConThieuCTPhieuGridControl.Location = new System.Drawing.Point(3, 18);
            this.sp_getVatTuConThieuCTPhieuGridControl.MainView = this.gridView_VatTuChuaCo;
            this.sp_getVatTuConThieuCTPhieuGridControl.Name = "sp_getVatTuConThieuCTPhieuGridControl";
            this.sp_getVatTuConThieuCTPhieuGridControl.Size = new System.Drawing.Size(576, 381);
            this.sp_getVatTuConThieuCTPhieuGridControl.TabIndex = 0;
            this.sp_getVatTuConThieuCTPhieuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_VatTuChuaCo});
            this.sp_getVatTuConThieuCTPhieuGridControl.MouseCaptureChanged += new System.EventHandler(this.sp_getVatTuConThieuCTPhieuGridControl_MouseCaptureChanged);
            // 
            // bds_sp_getVatTuConThieuCTPhieu
            // 
            this.bds_sp_getVatTuConThieuCTPhieu.DataMember = "sp_getVatTuConThieuCTPhieu";
            this.bds_sp_getVatTuConThieuCTPhieu.DataSource = this.DS;
            // 
            // gridView_VatTuChuaCo
            // 
            this.gridView_VatTuChuaCo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView_VatTuChuaCo.GridControl = this.sp_getVatTuConThieuCTPhieuGridControl;
            this.gridView_VatTuChuaCo.Name = "gridView_VatTuChuaCo";
            this.gridView_VatTuChuaCo.OptionsBehavior.Editable = false;
            this.gridView_VatTuChuaCo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_VatTuChuaCo_FocusedRowChanged);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
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
            // colDVT
            // 
            this.colDVT.Caption = "ĐVT";
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
            // bds_spgetVTChuaCo
            // 
            this.bds_spgetVTChuaCo.DataMember = "sp_getVTChuaCo";
            this.bds_spgetVTChuaCo.DataSource = this.DS;
            // 
            // bds_sp_getVatTuChuaCo
            // 
            this.bds_sp_getVatTuChuaCo.DataMember = "sp_getVatTuChuaCo";
            this.bds_sp_getVatTuChuaCo.DataSource = this.DS;
            // 
            // sp_getCTDDHTableAdapter
            // 
            this.sp_getCTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getVatTuChuaCoTableAdapter
            // 
            this.sp_getVatTuChuaCoTableAdapter.ClearBeforeFill = true;
            // 
            // spin_SoLuong
            // 
            this.spin_SoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_getCTDDH, "DONGIA", true));
            this.spin_SoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_SoLuong.Location = new System.Drawing.Point(92, 179);
            this.spin_SoLuong.Name = "spin_SoLuong";
            this.spin_SoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_SoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spin_SoLuong.Properties.IsFloatValue = false;
            this.spin_SoLuong.Properties.Mask.EditMask = "n0";
            this.spin_SoLuong.Properties.MaxValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spin_SoLuong.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_SoLuong.Size = new System.Drawing.Size(155, 34);
            this.spin_SoLuong.TabIndex = 7;
            this.spin_SoLuong.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.spin_SoLuong_InvalidValue);
            this.spin_SoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.spin_SoLuong_Validating);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_Them.Appearance.Options.UseBackColor = true;
            this.btn_Them.Location = new System.Drawing.Point(122, 293);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox_InfoVT
            // 
            this.groupBox_InfoVT.Controls.Add(dVTLabel);
            this.groupBox_InfoVT.Controls.Add(this.txt_DVT);
            this.groupBox_InfoVT.Controls.Add(this.txt_TenVT);
            this.groupBox_InfoVT.Controls.Add(this.txt_MaVT);
            this.groupBox_InfoVT.Controls.Add(this.spin_DonGia);
            this.groupBox_InfoVT.Controls.Add(tENVTLabel1);
            this.groupBox_InfoVT.Controls.Add(mAVTLabel);
            this.groupBox_InfoVT.Controls.Add(this.btn_Them);
            this.groupBox_InfoVT.Controls.Add(dONGIALabel);
            this.groupBox_InfoVT.Controls.Add(this.spin_SoLuong);
            this.groupBox_InfoVT.Controls.Add(sOLUONGLabel);
            this.groupBox_InfoVT.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_InfoVT.Location = new System.Drawing.Point(0, 0);
            this.groupBox_InfoVT.Name = "groupBox_InfoVT";
            this.groupBox_InfoVT.Size = new System.Drawing.Size(287, 402);
            this.groupBox_InfoVT.TabIndex = 0;
            this.groupBox_InfoVT.TabStop = false;
            this.groupBox_InfoVT.Text = "Thông tin";
            this.groupBox_InfoVT.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_DVT
            // 
            this.txt_DVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_getVatTuConThieuCTPhieu, "DVT", true));
            this.txt_DVT.Enabled = false;
            this.txt_DVT.Location = new System.Drawing.Point(92, 137);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Size = new System.Drawing.Size(155, 26);
            this.txt_DVT.TabIndex = 17;
            // 
            // txt_TenVT
            // 
            this.txt_TenVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_getVatTuConThieuCTPhieu, "TENVT", true));
            this.txt_TenVT.Enabled = false;
            this.txt_TenVT.Location = new System.Drawing.Point(92, 88);
            this.txt_TenVT.Name = "txt_TenVT";
            this.txt_TenVT.Size = new System.Drawing.Size(155, 26);
            this.txt_TenVT.TabIndex = 16;
            // 
            // txt_MaVT
            // 
            this.txt_MaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_getVatTuConThieuCTPhieu, "MAVT", true));
            this.txt_MaVT.Enabled = false;
            this.txt_MaVT.Location = new System.Drawing.Point(92, 38);
            this.txt_MaVT.Name = "txt_MaVT";
            this.txt_MaVT.Size = new System.Drawing.Size(155, 26);
            this.txt_MaVT.TabIndex = 15;
            // 
            // spin_DonGia
            // 
            this.spin_DonGia.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_DonGia.Location = new System.Drawing.Point(92, 234);
            this.spin_DonGia.Name = "spin_DonGia";
            this.spin_DonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_DonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spin_DonGia.Properties.IsFloatValue = false;
            this.spin_DonGia.Properties.Mask.EditMask = "n0";
            this.spin_DonGia.Properties.MaxValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spin_DonGia.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_DonGia.Size = new System.Drawing.Size(158, 34);
            this.spin_DonGia.TabIndex = 13;
            // 
            // spgetCTPNBindingSource
            // 
            this.spgetCTPNBindingSource.DataMember = "sp_getCTPN";
            this.spgetCTPNBindingSource.DataSource = this.DS;
            // 
            // sp_getCTPNTableAdapter
            // 
            this.sp_getCTPNTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getVTChuaCoTableAdapter
            // 
            this.sp_getVTChuaCoTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getVatTuConThieuCTPhieuTableAdapter
            // 
            this.sp_getVatTuConThieuCTPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 402);
            this.Controls.Add(this.groupBox_VT);
            this.Controls.Add(this.groupBox_InfoVT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmThemCTDDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chi tiết ĐĐH";
            this.Load += new System.EventHandler(this.fromThemChiTietDDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            this.groupBox_VT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuConThieuCTPhieuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVatTuConThieuCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_VatTuChuaCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_spgetVTChuaCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVatTuChuaCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_SoLuong.Properties)).EndInit();
            this.groupBox_InfoVT.ResumeLayout(false);
            this.groupBox_InfoVT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_DonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCTPNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DS DS;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox_VT;
        private System.Windows.Forms.BindingSource bds_sp_getCTDDH;
        private DSTableAdapters.sp_getCTDDHTableAdapter sp_getCTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bds_sp_getVatTuChuaCo;
        private DSTableAdapters.sp_getVatTuChuaCoTableAdapter sp_getVatTuChuaCoTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.GroupBox groupBox_InfoVT;
        public DevExpress.XtraEditors.SpinEdit spin_SoLuong;
        public DevExpress.XtraEditors.SpinEdit spin_DonGia;
        private System.Windows.Forms.BindingSource bds_spgetVTChuaCo;
        private System.Windows.Forms.BindingSource spgetCTPNBindingSource;
        private DSTableAdapters.sp_getCTPNTableAdapter sp_getCTPNTableAdapter;
        private DSTableAdapters.sp_getVTChuaCoTableAdapter sp_getVTChuaCoTableAdapter;
        private System.Windows.Forms.BindingSource bds_sp_getVatTuConThieuCTPhieu;
        private DSTableAdapters.sp_getVatTuConThieuCTPhieuTableAdapter sp_getVatTuConThieuCTPhieuTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_getVatTuConThieuCTPhieuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_VatTuChuaCo;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.TextEdit txt_TenVT;
        private DevExpress.XtraEditors.TextEdit txt_MaVT;
        private DevExpress.XtraEditors.TextEdit txt_DVT;
    }
}