
namespace QLVT
{
    partial class frmRptDSNV
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
            this.cmb_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_ChiNhanh
            // 
            this.cmb_ChiNhanh.FormattingEnabled = true;
            this.cmb_ChiNhanh.Location = new System.Drawing.Point(208, 72);
            this.cmb_ChiNhanh.Name = "cmb_ChiNhanh";
            this.cmb_ChiNhanh.Size = new System.Drawing.Size(247, 24);
            this.cmb_ChiNhanh.TabIndex = 7;
            this.cmb_ChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_ChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chi Nhánh";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(267, 125);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 36);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "IN DANH SÁCH NHÂN VIÊN";
            // 
            // frmRptDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmb_ChiNhanh);
            this.Controls.Add(this.label1);
            this.Name = "frmRptDSNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRptDSNV";
            this.Load += new System.EventHandler(this.frmRptDSNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
    }
}