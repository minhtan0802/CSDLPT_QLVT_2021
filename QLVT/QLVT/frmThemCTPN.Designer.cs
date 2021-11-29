
namespace QLVT
{
    partial class frmThemCTPN
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
            System.Windows.Forms.Label tENVTLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            this.DS = new QLVT.DS();
            this.bds_sp_CTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTDDHTableAdapter = new QLVT.DSTableAdapters.sp_getCTDDHTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox_VT = new System.Windows.Forms.GroupBox();
            this.sp_getVatTuConThieuCTPhieuGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_sp_getVatTuConThieuCTPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_getVTConThieuCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox_InfoVT = new System.Windows.Forms.GroupBox();
            this.txt_TENVT = new DevExpress.XtraEditors.TextEdit();
            this.txt_MAVT = new DevExpress.XtraEditors.TextEdit();
            this.spin_DonGia = new DevExpress.XtraEditors.SpinEdit();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.spin_SoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.bds_sp_getVTConThieuCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.bds_sp_getCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTPNTableAdapter = new QLVT.DSTableAdapters.sp_getCTPNTableAdapter();
            this.sp_getVTConThieuCTPNTableAdapter = new QLVT.DSTableAdapters.sp_getVTConThieuCTPNTableAdapter();
            this.sp_getVatTuConThieuCTPhieuTableAdapter = new QLVT.DSTableAdapters.sp_getVatTuConThieuCTPhieuTableAdapter();
            tENVTLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_CTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox_VT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuConThieuCTPhieuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVatTuConThieuCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_getVTConThieuCTPN)).BeginInit();
            this.groupBox_InfoVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TENVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_DonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_SoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVTConThieuCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // tENVTLabel1
            // 
            tENVTLabel1.AutoSize = true;
            tENVTLabel1.Location = new System.Drawing.Point(40, 81);
            tENVTLabel1.Name = "tENVTLabel1";
            tENVTLabel1.Size = new System.Drawing.Size(59, 17);
            tENVTLabel1.TabIndex = 22;
            tENVTLabel1.Text = "Tên VT:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(48, 31);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(53, 17);
            mAVTLabel.TabIndex = 21;
            mAVTLabel.Text = "Mã VT:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(37, 188);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(61, 17);
            dONGIALabel.TabIndex = 18;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(30, 129);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 17);
            sOLUONGLabel.TabIndex = 17;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_sp_CTDDH
            // 
            this.bds_sp_CTDDH.DataMember = "sp_getCTDDH";
            this.bds_sp_CTDDH.DataSource = this.DS;
            // 
            // sp_getCTDDHTableAdapter
            // 
            this.sp_getCTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.groupBox_VT);
            this.panelControl2.Controls.Add(this.groupBox_InfoVT);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1044, 327);
            this.panelControl2.TabIndex = 38;
            // 
            // groupBox_VT
            // 
            this.groupBox_VT.Controls.Add(this.sp_getVatTuConThieuCTPhieuGridControl);
            this.groupBox_VT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_VT.Location = new System.Drawing.Point(373, 0);
            this.groupBox_VT.Name = "groupBox_VT";
            this.groupBox_VT.Size = new System.Drawing.Size(671, 327);
            this.groupBox_VT.TabIndex = 2;
            this.groupBox_VT.TabStop = false;
            this.groupBox_VT.Text = "Chi tiết đơn đặt hàng";
            this.groupBox_VT.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sp_getVatTuConThieuCTPhieuGridControl
            // 
            this.sp_getVatTuConThieuCTPhieuGridControl.DataSource = this.bds_sp_getVatTuConThieuCTPhieu;
            this.sp_getVatTuConThieuCTPhieuGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_getVatTuConThieuCTPhieuGridControl.Location = new System.Drawing.Point(3, 18);
            this.sp_getVatTuConThieuCTPhieuGridControl.MainView = this.gridView_getVTConThieuCTPN;
            this.sp_getVatTuConThieuCTPhieuGridControl.Name = "sp_getVatTuConThieuCTPhieuGridControl";
            this.sp_getVatTuConThieuCTPhieuGridControl.Size = new System.Drawing.Size(665, 306);
            this.sp_getVatTuConThieuCTPhieuGridControl.TabIndex = 1;
            this.sp_getVatTuConThieuCTPhieuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_getVTConThieuCTPN});
            this.sp_getVatTuConThieuCTPhieuGridControl.MouseCaptureChanged += new System.EventHandler(this.sp_getVatTuConThieuCTPhieuGridControl_MouseCaptureChanged);
            // 
            // bds_sp_getVatTuConThieuCTPhieu
            // 
            this.bds_sp_getVatTuConThieuCTPhieu.DataMember = "sp_getVatTuConThieuCTPhieu";
            this.bds_sp_getVatTuConThieuCTPhieu.DataSource = this.DS;
            // 
            // gridView_getVTConThieuCTPN
            // 
            this.gridView_getVTConThieuCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView_getVTConThieuCTPN.GridControl = this.sp_getVatTuConThieuCTPhieuGridControl;
            this.gridView_getVTConThieuCTPN.Name = "gridView_getVTConThieuCTPN";
            this.gridView_getVTConThieuCTPN.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_getVTConThieuCTPN_FocusedRowChanged);
            // 
            // colMAVT
            // 
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
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.DisplayFormat.FormatString = "n0";
            this.colDVT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDVT.FieldName = "DONGIA";
            this.colDVT.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.DisplayFormat.FormatString = "n0";
            this.colSOLUONGTON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOLUONGTON.FieldName = "SOLUONG";
            this.colSOLUONGTON.GroupFormat.FormatString = "n0";
            this.colSOLUONGTON.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOLUONGTON.MinWidth = 25;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 94;
            // 
            // groupBox_InfoVT
            // 
            this.groupBox_InfoVT.Controls.Add(this.txt_TENVT);
            this.groupBox_InfoVT.Controls.Add(this.txt_MAVT);
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
            this.groupBox_InfoVT.Size = new System.Drawing.Size(373, 327);
            this.groupBox_InfoVT.TabIndex = 3;
            this.groupBox_InfoVT.TabStop = false;
            this.groupBox_InfoVT.Text = "Thông tin";
            this.groupBox_InfoVT.MouseCaptureChanged += new System.EventHandler(this.groupBox_InfoVT_MouseCaptureChanged);
            // 
            // txt_TENVT
            // 
            this.txt_TENVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_getVatTuConThieuCTPhieu, "TENVT", true));
            this.txt_TENVT.Enabled = false;
            this.txt_TENVT.Location = new System.Drawing.Point(107, 76);
            this.txt_TENVT.Name = "txt_TENVT";
            this.txt_TENVT.Size = new System.Drawing.Size(155, 26);
            this.txt_TENVT.TabIndex = 27;
            // 
            // txt_MAVT
            // 
            this.txt_MAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_getVatTuConThieuCTPhieu, "MAVT", true));
            this.txt_MAVT.Enabled = false;
            this.txt_MAVT.Location = new System.Drawing.Point(107, 22);
            this.txt_MAVT.Name = "txt_MAVT";
            this.txt_MAVT.Size = new System.Drawing.Size(155, 26);
            this.txt_MAVT.TabIndex = 26;
            // 
            // spin_DonGia
            // 
            this.spin_DonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spin_DonGia.Location = new System.Drawing.Point(107, 179);
            this.spin_DonGia.Name = "spin_DonGia";
            this.spin_DonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_DonGia.Properties.DisplayFormat.FormatString = "n0";
            this.spin_DonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spin_DonGia.Properties.IsFloatValue = false;
            this.spin_DonGia.Properties.Mask.EditMask = "n0";
            this.spin_DonGia.Properties.MaxValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spin_DonGia.Size = new System.Drawing.Size(158, 34);
            this.spin_DonGia.TabIndex = 23;
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_Them.Appearance.Options.UseBackColor = true;
            this.btn_Them.Location = new System.Drawing.Point(136, 234);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // spin_SoLuong
            // 
            this.spin_SoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spin_SoLuong.Location = new System.Drawing.Point(107, 125);
            this.spin_SoLuong.Name = "spin_SoLuong";
            this.spin_SoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_SoLuong.Properties.DisplayFormat.FormatString = "n0";
            this.spin_SoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spin_SoLuong.Properties.IsFloatValue = false;
            this.spin_SoLuong.Properties.Mask.EditMask = "n0";
            this.spin_SoLuong.Properties.MaxValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spin_SoLuong.Size = new System.Drawing.Size(155, 34);
            this.spin_SoLuong.TabIndex = 19;
            this.spin_SoLuong.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.spin_SoLuong_InvalidValue);
            this.spin_SoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.spin_SoLuong_Validating);
            // 
            // bds_sp_getVTConThieuCTPN
            // 
            this.bds_sp_getVTConThieuCTPN.DataMember = "sp_getVTConThieuCTPN";
            this.bds_sp_getVTConThieuCTPN.DataSource = this.DS;
            // 
            // bds_sp_getCTPN
            // 
            this.bds_sp_getCTPN.DataMember = "sp_getCTPN";
            this.bds_sp_getCTPN.DataSource = this.DS;
            // 
            // sp_getCTPNTableAdapter
            // 
            this.sp_getCTPNTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getVTConThieuCTPNTableAdapter
            // 
            this.sp_getVTConThieuCTPNTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getVatTuConThieuCTPhieuTableAdapter
            // 
            this.sp_getVatTuConThieuCTPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 370);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmThemCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chi tiết PN";
            this.Load += new System.EventHandler(this.frmThemCTPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_CTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox_VT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuConThieuCTPhieuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVatTuConThieuCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_getVTConThieuCTPN)).EndInit();
            this.groupBox_InfoVT.ResumeLayout(false);
            this.groupBox_InfoVT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TENVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_DonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_SoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVTConThieuCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bds_sp_CTDDH;
        private DS DS;
        private DSTableAdapters.sp_getCTDDHTableAdapter sp_getCTDDHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource bds_sp_getCTPN;
        private DSTableAdapters.sp_getCTPNTableAdapter sp_getCTPNTableAdapter;
        private System.Windows.Forms.BindingSource bds_sp_getVTConThieuCTPN;
        private DSTableAdapters.sp_getVTConThieuCTPNTableAdapter sp_getVTConThieuCTPNTableAdapter;
        private System.Windows.Forms.BindingSource bds_sp_getVatTuConThieuCTPhieu;
        private DSTableAdapters.sp_getVatTuConThieuCTPhieuTableAdapter sp_getVatTuConThieuCTPhieuTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_getVatTuConThieuCTPhieuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_getVTConThieuCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.GroupBox groupBox_VT;
        private System.Windows.Forms.GroupBox groupBox_InfoVT;
        public DevExpress.XtraEditors.SpinEdit spin_DonGia;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        public DevExpress.XtraEditors.SpinEdit spin_SoLuong;
        private DevExpress.XtraEditors.TextEdit txt_TENVT;
        private DevExpress.XtraEditors.TextEdit txt_MAVT;
    }
}