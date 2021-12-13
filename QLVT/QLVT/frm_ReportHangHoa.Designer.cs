
namespace QLVT
{
    partial class frm_ReportHangHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.date_From = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_To = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_From.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_From.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_To.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_To.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG HÓA";
            // 
            // cmb_Type
            // 
            this.cmb_Type.Location = new System.Drawing.Point(141, 72);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Type.Properties.Items.AddRange(new object[] {
            "Phiếu nhập",
            "Phiếu xuất"});
            this.cmb_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_Type.Size = new System.Drawing.Size(125, 26);
            this.cmb_Type.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại:";
            // 
            // date_From
            // 
            this.date_From.EditValue = null;
            this.date_From.Location = new System.Drawing.Point(141, 125);
            this.date_From.Name = "date_From";
            this.date_From.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_From.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_From.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.date_From.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_From.Properties.EditFormat.FormatString = "MM/yyyy";
            this.date_From.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_From.Properties.Mask.EditMask = "Y";
            this.date_From.Size = new System.Drawing.Size(125, 26);
            this.date_From.TabIndex = 3;
            this.date_From.Validating += new System.ComponentModel.CancelEventHandler(this.date_From_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến:";
            // 
            // date_To
            // 
            this.date_To.EditValue = null;
            this.date_To.Location = new System.Drawing.Point(395, 125);
            this.date_To.Name = "date_To";
            this.date_To.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_To.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_To.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.date_To.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_To.Properties.Mask.EditMask = "Y";
            this.date_To.Size = new System.Drawing.Size(125, 26);
            this.date_To.TabIndex = 6;
            this.date_To.Validating += new System.ComponentModel.CancelEventHandler(this.date_To_Validating);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(141, 179);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 29);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "In";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frm_ReportHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 239);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.date_To);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.label1);
            this.Name = "frm_ReportHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG HÓA";
            this.Load += new System.EventHandler(this.frm_ReportHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_From.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_From.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_To.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_To.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Type;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit date_From;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit date_To;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}