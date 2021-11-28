
namespace QLVT
{
    partial class frmThemCTPX
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
            System.Windows.Forms.Label label1;
            this.groupBox_InfoVT = new System.Windows.Forms.GroupBox();
            this.txt_TENVT = new DevExpress.XtraEditors.TextEdit();
            this.bds_sp_getVatTuConThieuCTPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.txt_MAVT = new DevExpress.XtraEditors.TextEdit();
            this.txt_DonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.spin_SoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.spin_DonGia = new DevExpress.XtraEditors.SpinEdit();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.bds_sp_getVTChuaCo = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_VT = new System.Windows.Forms.GroupBox();
            this.sp_getVatTuConThieuCTPhieuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView_VatTuChuaCo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.sp_getVTChuaCoTableAdapter = new QLVT.DSTableAdapters.sp_getVTChuaCoTableAdapter();
            this.sp_getVatTuConThieuCTPhieuTableAdapter = new QLVT.DSTableAdapters.sp_getVatTuConThieuCTPhieuTableAdapter();
            tENVTLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox_InfoVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TENVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVatTuConThieuCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_SoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_DonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVTChuaCo)).BeginInit();
            this.groupBox_VT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuConThieuCTPhieuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_VatTuChuaCo)).BeginInit();
            this.SuspendLayout();
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
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(33, 43);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(53, 17);
            mAVTLabel.TabIndex = 10;
            mAVTLabel.Text = "Mã VT:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(22, 245);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(61, 17);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(16, 188);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 140);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 17);
            label1.TabIndex = 19;
            label1.Text = "Đơn vị tính:";
            // 
            // groupBox_InfoVT
            // 
            this.groupBox_InfoVT.Controls.Add(this.txt_TENVT);
            this.groupBox_InfoVT.Controls.Add(this.txt_MAVT);
            this.groupBox_InfoVT.Controls.Add(this.txt_DonViTinh);
            this.groupBox_InfoVT.Controls.Add(label1);
            this.groupBox_InfoVT.Controls.Add(this.spin_SoLuong);
            this.groupBox_InfoVT.Controls.Add(this.spin_DonGia);
            this.groupBox_InfoVT.Controls.Add(tENVTLabel1);
            this.groupBox_InfoVT.Controls.Add(mAVTLabel);
            this.groupBox_InfoVT.Controls.Add(this.btn_Them);
            this.groupBox_InfoVT.Controls.Add(dONGIALabel);
            this.groupBox_InfoVT.Controls.Add(sOLUONGLabel);
            this.groupBox_InfoVT.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_InfoVT.Location = new System.Drawing.Point(0, 0);
            this.groupBox_InfoVT.Name = "groupBox_InfoVT";
            this.groupBox_InfoVT.Size = new System.Drawing.Size(341, 390);
            this.groupBox_InfoVT.TabIndex = 1;
            this.groupBox_InfoVT.TabStop = false;
            this.groupBox_InfoVT.Text = "Thông tin";
            // 
            // txt_TENVT
            // 
            this.txt_TENVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_getVatTuConThieuCTPhieu, "TENVT", true));
            this.txt_TENVT.Enabled = false;
            this.txt_TENVT.Location = new System.Drawing.Point(92, 88);
            this.txt_TENVT.Name = "txt_TENVT";
            this.txt_TENVT.Size = new System.Drawing.Size(190, 26);
            this.txt_TENVT.TabIndex = 22;
            // 
            // bds_sp_getVatTuConThieuCTPhieu
            // 
            this.bds_sp_getVatTuConThieuCTPhieu.DataMember = "sp_getVatTuConThieuCTPhieu";
            this.bds_sp_getVatTuConThieuCTPhieu.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_MAVT
            // 
            this.txt_MAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sp_getVatTuConThieuCTPhieu, "MAVT", true));
            this.txt_MAVT.Enabled = false;
            this.txt_MAVT.Location = new System.Drawing.Point(92, 38);
            this.txt_MAVT.Name = "txt_MAVT";
            this.txt_MAVT.Size = new System.Drawing.Size(190, 26);
            this.txt_MAVT.TabIndex = 21;
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.Enabled = false;
            this.txt_DonViTinh.Location = new System.Drawing.Point(90, 135);
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Size = new System.Drawing.Size(192, 26);
            this.txt_DonViTinh.TabIndex = 20;
            // 
            // spin_SoLuong
            // 
            this.spin_SoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spin_SoLuong.Location = new System.Drawing.Point(90, 179);
            this.spin_SoLuong.Name = "spin_SoLuong";
            this.spin_SoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_SoLuong.Properties.DisplayFormat.FormatString = "n0";
            this.spin_SoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spin_SoLuong.Properties.EditFormat.FormatString = "n0";
            this.spin_SoLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spin_SoLuong.Properties.IsFloatValue = false;
            this.spin_SoLuong.Properties.Mask.EditMask = "n0";
            this.spin_SoLuong.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spin_SoLuong.Size = new System.Drawing.Size(192, 34);
            this.spin_SoLuong.TabIndex = 17;
            this.spin_SoLuong.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.spin_SoLuong_InvalidValue);
            this.spin_SoLuong.EditValueChanged += new System.EventHandler(this.spin_SoLuong_EditValueChanged);
            this.spin_SoLuong.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spin_SoLuong_EditValueChanging);
            this.spin_SoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spin_SoLuong_KeyDown);
            this.spin_SoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.spin_SoLuong_Validating);
            // 
            // spin_DonGia
            // 
            this.spin_DonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spin_DonGia.Location = new System.Drawing.Point(89, 236);
            this.spin_DonGia.Name = "spin_DonGia";
            this.spin_DonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_DonGia.Properties.DisplayFormat.FormatString = "n0";
            this.spin_DonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spin_DonGia.Properties.EditFormat.FormatString = "n0";
            this.spin_DonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spin_DonGia.Properties.IsFloatValue = false;
            this.spin_DonGia.Properties.Mask.EditMask = "n0";
            this.spin_DonGia.Properties.MaxValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spin_DonGia.Size = new System.Drawing.Size(192, 34);
            this.spin_DonGia.TabIndex = 16;
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_Them.Appearance.Options.UseBackColor = true;
            this.btn_Them.Location = new System.Drawing.Point(119, 311);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // bds_sp_getVTChuaCo
            // 
            this.bds_sp_getVTChuaCo.DataMember = "sp_getVTChuaCo";
            this.bds_sp_getVTChuaCo.DataSource = this.DS;
            // 
            // groupBox_VT
            // 
            this.groupBox_VT.Controls.Add(this.sp_getVatTuConThieuCTPhieuGridControl);
            this.groupBox_VT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_VT.Location = new System.Drawing.Point(341, 0);
            this.groupBox_VT.Name = "groupBox_VT";
            this.groupBox_VT.Size = new System.Drawing.Size(618, 390);
            this.groupBox_VT.TabIndex = 4;
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
            this.sp_getVatTuConThieuCTPhieuGridControl.Size = new System.Drawing.Size(612, 369);
            this.sp_getVatTuConThieuCTPhieuGridControl.TabIndex = 0;
            this.sp_getVatTuConThieuCTPhieuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_VatTuChuaCo});
            this.sp_getVatTuConThieuCTPhieuGridControl.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.sp_getVatTuConThieuCTPhieuGridControl_FocusedViewChanged);
            this.sp_getVatTuConThieuCTPhieuGridControl.MouseCaptureChanged += new System.EventHandler(this.sp_getVatTuConThieuCTPhieuGridControl_MouseCaptureChanged);
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
            // sp_getVTChuaCoTableAdapter
            // 
            this.sp_getVTChuaCoTableAdapter.ClearBeforeFill = true;
            // 
            // sp_getVatTuConThieuCTPhieuTableAdapter
            // 
            this.sp_getVatTuConThieuCTPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 390);
            this.Controls.Add(this.groupBox_VT);
            this.Controls.Add(this.groupBox_InfoVT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThemCTPX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chi tiết PX";
            this.Load += new System.EventHandler(this.frmThemCTPX_Load);
            this.groupBox_InfoVT.ResumeLayout(false);
            this.groupBox_InfoVT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TENVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVatTuConThieuCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_SoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_DonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVTChuaCo)).EndInit();
            this.groupBox_VT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuConThieuCTPhieuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_VatTuChuaCo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_InfoVT;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.GroupBox groupBox_VT;
        private DevExpress.XtraEditors.SpinEdit spin_SoLuong;
        private DS DS;
        private DevExpress.XtraEditors.SpinEdit spin_DonGia;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bds_sp_getVTChuaCo;
        private DSTableAdapters.sp_getVTChuaCoTableAdapter sp_getVTChuaCoTableAdapter;
        private DevExpress.XtraEditors.TextEdit txt_DonViTinh;
        private System.Windows.Forms.BindingSource bds_sp_getVatTuConThieuCTPhieu;
        private DSTableAdapters.sp_getVatTuConThieuCTPhieuTableAdapter sp_getVatTuConThieuCTPhieuTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_getVatTuConThieuCTPhieuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_VatTuChuaCo;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.TextEdit txt_MAVT;
        private DevExpress.XtraEditors.TextEdit txt_TENVT;
    }
}