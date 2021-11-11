
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bds_sp_CTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTDDHTableAdapter = new QLVT.DSTableAdapters.sp_getCTDDHTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_ThemVaoCTPN = new System.Windows.Forms.Button();
            this.gc_sp_getCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView_getCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bds_sp_getCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTPNTableAdapter = new QLVT.DSTableAdapters.sp_getCTPNTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.mAPNToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mAPNToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_CTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_sp_getCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_getCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPN)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(920, 46);
            this.panelControl1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT ĐƠN ĐẶT HÀNG";
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
            this.panelControl2.Controls.Add(this.btn_ThemVaoCTPN);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 250);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(920, 295);
            this.panelControl2.TabIndex = 38;
            // 
            // btn_ThemVaoCTPN
            // 
            this.btn_ThemVaoCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemVaoCTPN.Location = new System.Drawing.Point(204, 6);
            this.btn_ThemVaoCTPN.Name = "btn_ThemVaoCTPN";
            this.btn_ThemVaoCTPN.Size = new System.Drawing.Size(294, 42);
            this.btn_ThemVaoCTPN.TabIndex = 0;
            this.btn_ThemVaoCTPN.Text = "Thêm CTPN";
            this.btn_ThemVaoCTPN.UseVisualStyleBackColor = true;
            this.btn_ThemVaoCTPN.Click += new System.EventHandler(this.btn_ThemVaoCTPN_Click);
            // 
            // gc_sp_getCTDDH
            // 
            this.gc_sp_getCTDDH.DataSource = this.bds_sp_CTDDH;
            this.gc_sp_getCTDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_sp_getCTDDH.Location = new System.Drawing.Point(0, 46);
            this.gc_sp_getCTDDH.MainView = this.gridView_getCTDDH;
            this.gc_sp_getCTDDH.Name = "gc_sp_getCTDDH";
            this.gc_sp_getCTDDH.Size = new System.Drawing.Size(920, 204);
            this.gc_sp_getCTDDH.TabIndex = 39;
            this.gc_sp_getCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_getCTDDH});
            // 
            // gridView_getCTDDH
            // 
            this.gridView_getCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDONGIA,
            this.colSOLUONG});
            this.gridView_getCTDDH.GridControl = this.gc_sp_getCTDDH;
            this.gridView_getCTDDH.Name = "gridView_getCTDDH";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
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
            this.colTENVT.Caption = "Tên vật tư";
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
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 3;
            this.colSOLUONG.Width = 94;
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
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAPNToolStripLabel,
            this.mAPNToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 545);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(920, 31);
            this.fillToolStrip.TabIndex = 40;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // mAPNToolStripLabel
            // 
            this.mAPNToolStripLabel.Name = "mAPNToolStripLabel";
            this.mAPNToolStripLabel.Size = new System.Drawing.Size(54, 28);
            this.mAPNToolStripLabel.Text = "MAPN:";
            // 
            // mAPNToolStripTextBox
            // 
            this.mAPNToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mAPNToolStripTextBox.Name = "mAPNToolStripTextBox";
            this.mAPNToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 28);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // frmThemCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 335);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gc_sp_getCTDDH);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmThemCTPN";
            this.Text = "Thêm chi tiết PN";
            this.Load += new System.EventHandler(this.frmThemCTPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_CTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_sp_getCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_getCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPN)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bds_sp_CTDDH;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.sp_getCTDDHTableAdapter sp_getCTDDHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btn_ThemVaoCTPN;
        private DevExpress.XtraGrid.GridControl gc_sp_getCTDDH;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_getCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private System.Windows.Forms.BindingSource bds_sp_getCTPN;
        private DSTableAdapters.sp_getCTPNTableAdapter sp_getCTPNTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel mAPNToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mAPNToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}