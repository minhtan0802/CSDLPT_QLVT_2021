
namespace QLVT
{
    partial class Test
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
            this.dS = new QLVT.DS();
            this.sp_getVatTuChuaCoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getVatTuChuaCoTableAdapter = new QLVT.DSTableAdapters.sp_getVatTuChuaCoTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.mDDHToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mDDHToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sp_getVatTuChuaCoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuChuaCoBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuChuaCoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_getVatTuChuaCoBindingSource
            // 
            this.sp_getVatTuChuaCoBindingSource.DataMember = "sp_getVatTuChuaCo";
            this.sp_getVatTuChuaCoBindingSource.DataSource = this.dS;
            // 
            // sp_getVatTuChuaCoTableAdapter
            // 
            this.sp_getVatTuChuaCoTableAdapter.ClearBeforeFill = true;
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
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDDHToolStripLabel,
            this.mDDHToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(795, 27);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // mDDHToolStripLabel
            // 
            this.mDDHToolStripLabel.Name = "mDDHToolStripLabel";
            this.mDDHToolStripLabel.Size = new System.Drawing.Size(58, 24);
            this.mDDHToolStripLabel.Text = "MDDH:";
            // 
            // mDDHToolStripTextBox
            // 
            this.mDDHToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mDDHToolStripTextBox.Name = "mDDHToolStripTextBox";
            this.mDDHToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // sp_getVatTuChuaCoGridControl
            // 
            this.sp_getVatTuChuaCoGridControl.DataSource = this.sp_getVatTuChuaCoBindingSource;
            this.sp_getVatTuChuaCoGridControl.Location = new System.Drawing.Point(0, 84);
            this.sp_getVatTuChuaCoGridControl.MainView = this.gridView1;
            this.sp_getVatTuChuaCoGridControl.Name = "sp_getVatTuChuaCoGridControl";
            this.sp_getVatTuChuaCoGridControl.Size = new System.Drawing.Size(795, 303);
            this.sp_getVatTuChuaCoGridControl.TabIndex = 2;
            this.sp_getVatTuChuaCoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.sp_getVatTuChuaCoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
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
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 25;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 94;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 399);
            this.Controls.Add(this.sp_getVatTuChuaCoGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "Test";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuChuaCoBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getVatTuChuaCoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource sp_getVatTuChuaCoBindingSource;
        private DSTableAdapters.sp_getVatTuChuaCoTableAdapter sp_getVatTuChuaCoTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel mDDHToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mDDHToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl sp_getVatTuChuaCoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
    }
}