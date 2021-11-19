
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
            this.gc_sp_getVTConThieuCTPN = new DevExpress.XtraGrid.GridControl();
            this.bds_sp_getVTConThieuCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_getVTConThieuCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_ThemVaoCTPN = new System.Windows.Forms.Button();
            this.bds_sp_getCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getCTPNTableAdapter = new QLVT.DSTableAdapters.sp_getCTPNTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.mAPNToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mAPNToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.maPNToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.maPNToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.maDDHToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maDDHToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.maDDHToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.maDDHToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.sp_getVTConThieuCTPNTableAdapter = new QLVT.DSTableAdapters.sp_getVTConThieuCTPNTableAdapter();
            this.fillToolStrip4 = new System.Windows.Forms.ToolStrip();
            this.maDDHToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.maDDHToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_CTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_sp_getVTConThieuCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVTConThieuCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_getVTConThieuCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPN)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.fillToolStrip1.SuspendLayout();
            this.fillToolStrip2.SuspendLayout();
            this.fillToolStrip3.SuspendLayout();
            this.fillToolStrip4.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(302, 9);
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
            this.panelControl2.Controls.Add(this.gc_sp_getVTConThieuCTPN);
            this.panelControl2.Controls.Add(this.btn_ThemVaoCTPN);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 46);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(920, 330);
            this.panelControl2.TabIndex = 38;
            // 
            // gc_sp_getVTConThieuCTPN
            // 
            this.gc_sp_getVTConThieuCTPN.DataSource = this.bds_sp_getVTConThieuCTPN;
            this.gc_sp_getVTConThieuCTPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_sp_getVTConThieuCTPN.Location = new System.Drawing.Point(2, 2);
            this.gc_sp_getVTConThieuCTPN.MainView = this.gridView_getVTConThieuCTPN;
            this.gc_sp_getVTConThieuCTPN.Name = "gc_sp_getVTConThieuCTPN";
            this.gc_sp_getVTConThieuCTPN.Size = new System.Drawing.Size(916, 194);
            this.gc_sp_getVTConThieuCTPN.TabIndex = 1;
            this.gc_sp_getVTConThieuCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_getVTConThieuCTPN});
            // 
            // bds_sp_getVTConThieuCTPN
            // 
            this.bds_sp_getVTConThieuCTPN.DataMember = "sp_getVTConThieuCTPN";
            this.bds_sp_getVTConThieuCTPN.DataSource = this.DS;
            // 
            // gridView_getVTConThieuCTPN
            // 
            this.gridView_getVTConThieuCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDONGIA,
            this.colSOLUONG});
            this.gridView_getVTConThieuCTPN.GridControl = this.gc_sp_getVTConThieuCTPN;
            this.gridView_getVTConThieuCTPN.Name = "gridView_getVTConThieuCTPN";
            this.gridView_getVTConThieuCTPN.OptionsBehavior.Editable = false;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            this.colDONGIA.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 3;
            this.colSOLUONG.Width = 94;
            // 
            // btn_ThemVaoCTPN
            // 
            this.btn_ThemVaoCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemVaoCTPN.Location = new System.Drawing.Point(307, 223);
            this.btn_ThemVaoCTPN.Name = "btn_ThemVaoCTPN";
            this.btn_ThemVaoCTPN.Size = new System.Drawing.Size(294, 42);
            this.btn_ThemVaoCTPN.TabIndex = 0;
            this.btn_ThemVaoCTPN.Text = "Thêm CTPN";
            this.btn_ThemVaoCTPN.UseVisualStyleBackColor = true;
            this.btn_ThemVaoCTPN.Click += new System.EventHandler(this.btn_ThemVaoCTPN_Click);
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
            this.fillToolStrip.Location = new System.Drawing.Point(0, 376);
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
            // fillToolStrip1
            // 
            this.fillToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maPNToolStripLabel1,
            this.maPNToolStripTextBox1,
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 407);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(920, 31);
            this.fillToolStrip1.TabIndex = 41;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // maPNToolStripLabel1
            // 
            this.maPNToolStripLabel1.Name = "maPNToolStripLabel1";
            this.maPNToolStripLabel1.Size = new System.Drawing.Size(52, 28);
            this.maPNToolStripLabel1.Text = "MaPN:";
            // 
            // maPNToolStripTextBox1
            // 
            this.maPNToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maPNToolStripTextBox1.Name = "maPNToolStripTextBox1";
            this.maPNToolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(32, 28);
            this.fillToolStripButton1.Text = "Fill";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // fillToolStrip2
            // 
            this.fillToolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maDDHToolStripLabel,
            this.maDDHToolStripTextBox,
            this.fillToolStripButton2});
            this.fillToolStrip2.Location = new System.Drawing.Point(0, 438);
            this.fillToolStrip2.Name = "fillToolStrip2";
            this.fillToolStrip2.Size = new System.Drawing.Size(920, 31);
            this.fillToolStrip2.TabIndex = 42;
            this.fillToolStrip2.Text = "fillToolStrip2";
            // 
            // maDDHToolStripLabel
            // 
            this.maDDHToolStripLabel.Name = "maDDHToolStripLabel";
            this.maDDHToolStripLabel.Size = new System.Drawing.Size(66, 28);
            this.maDDHToolStripLabel.Text = "MaDDH:";
            // 
            // maDDHToolStripTextBox
            // 
            this.maDDHToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maDDHToolStripTextBox.Name = "maDDHToolStripTextBox";
            this.maDDHToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // fillToolStripButton2
            // 
            this.fillToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton2.Name = "fillToolStripButton2";
            this.fillToolStripButton2.Size = new System.Drawing.Size(32, 28);
            this.fillToolStripButton2.Text = "Fill";
            this.fillToolStripButton2.Click += new System.EventHandler(this.fillToolStripButton2_Click);
            // 
            // fillToolStrip3
            // 
            this.fillToolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maDDHToolStripLabel1,
            this.maDDHToolStripTextBox1,
            this.fillToolStripButton3});
            this.fillToolStrip3.Location = new System.Drawing.Point(0, 469);
            this.fillToolStrip3.Name = "fillToolStrip3";
            this.fillToolStrip3.Size = new System.Drawing.Size(920, 31);
            this.fillToolStrip3.TabIndex = 43;
            this.fillToolStrip3.Text = "fillToolStrip3";
            // 
            // maDDHToolStripLabel1
            // 
            this.maDDHToolStripLabel1.Name = "maDDHToolStripLabel1";
            this.maDDHToolStripLabel1.Size = new System.Drawing.Size(66, 28);
            this.maDDHToolStripLabel1.Text = "MaDDH:";
            // 
            // maDDHToolStripTextBox1
            // 
            this.maDDHToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maDDHToolStripTextBox1.Name = "maDDHToolStripTextBox1";
            this.maDDHToolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // fillToolStripButton3
            // 
            this.fillToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton3.Name = "fillToolStripButton3";
            this.fillToolStripButton3.Size = new System.Drawing.Size(32, 28);
            this.fillToolStripButton3.Text = "Fill";
            this.fillToolStripButton3.Click += new System.EventHandler(this.fillToolStripButton3_Click);
            // 
            // sp_getVTConThieuCTPNTableAdapter
            // 
            this.sp_getVTConThieuCTPNTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip4
            // 
            this.fillToolStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maDDHToolStripLabel2,
            this.maDDHToolStripTextBox2,
            this.fillToolStripButton4});
            this.fillToolStrip4.Location = new System.Drawing.Point(0, 500);
            this.fillToolStrip4.Name = "fillToolStrip4";
            this.fillToolStrip4.Size = new System.Drawing.Size(920, 31);
            this.fillToolStrip4.TabIndex = 44;
            this.fillToolStrip4.Text = "fillToolStrip4";
            // 
            // maDDHToolStripLabel2
            // 
            this.maDDHToolStripLabel2.Name = "maDDHToolStripLabel2";
            this.maDDHToolStripLabel2.Size = new System.Drawing.Size(66, 28);
            this.maDDHToolStripLabel2.Text = "MaDDH:";
            // 
            // maDDHToolStripTextBox2
            // 
            this.maDDHToolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maDDHToolStripTextBox2.Name = "maDDHToolStripTextBox2";
            this.maDDHToolStripTextBox2.Size = new System.Drawing.Size(100, 31);
            // 
            // fillToolStripButton4
            // 
            this.fillToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton4.Name = "fillToolStripButton4";
            this.fillToolStripButton4.Size = new System.Drawing.Size(32, 28);
            this.fillToolStripButton4.Text = "Fill";
            this.fillToolStripButton4.Click += new System.EventHandler(this.fillToolStripButton4_Click);
            // 
            // frmThemCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 339);
            this.Controls.Add(this.fillToolStrip4);
            this.Controls.Add(this.fillToolStrip3);
            this.Controls.Add(this.fillToolStrip2);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.panelControl2);
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
            ((System.ComponentModel.ISupportInitialize)(this.gc_sp_getVTConThieuCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getVTConThieuCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_getVTConThieuCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sp_getCTPN)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            this.fillToolStrip2.ResumeLayout(false);
            this.fillToolStrip2.PerformLayout();
            this.fillToolStrip3.ResumeLayout(false);
            this.fillToolStrip3.PerformLayout();
            this.fillToolStrip4.ResumeLayout(false);
            this.fillToolStrip4.PerformLayout();
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
        private System.Windows.Forms.BindingSource bds_sp_getCTPN;
        private DSTableAdapters.sp_getCTPNTableAdapter sp_getCTPNTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel mAPNToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mAPNToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel maPNToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox maPNToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
        private System.Windows.Forms.ToolStrip fillToolStrip2;
        private System.Windows.Forms.ToolStripLabel maDDHToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maDDHToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton2;
        private System.Windows.Forms.ToolStrip fillToolStrip3;
        private System.Windows.Forms.ToolStripLabel maDDHToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox maDDHToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillToolStripButton3;
        private System.Windows.Forms.BindingSource bds_sp_getVTConThieuCTPN;
        private DSTableAdapters.sp_getVTConThieuCTPNTableAdapter sp_getVTConThieuCTPNTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip4;
        private System.Windows.Forms.ToolStripLabel maDDHToolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox maDDHToolStripTextBox2;
        private System.Windows.Forms.ToolStripButton fillToolStripButton4;
        private DevExpress.XtraGrid.GridControl gc_sp_getVTConThieuCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_getVTConThieuCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
    }
}