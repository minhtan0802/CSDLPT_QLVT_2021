using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class Test : DevExpress.XtraEditors.XtraForm
    {
        public Test()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_getVatTuChuaCoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getVatTuChuaCoTableAdapter.Fill(this.dS.sp_getVatTuChuaCo, mDDHToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridView1.GetRowCellValue(0, "SOLUONGTON").ToString().Equals("10"))
            {
                MessageBox.Show("THANH CONG");
                gridView1.SetColumnError(gridView1.Columns["SOLUONGTON"], "Số lượng vượt quá số lượng tồn", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                
                
                return;
            }
            if(gridView1.HasColumnErrors)
            {
                MessageBox.Show("Có lỗi rồi nha");
            }    
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if ((e.Value as String).Equals("10"))
            {
                e.Valid = false;
                e.ErrorText = "Lỗi nè";
            }    
        }
    }
}