using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frm_ReportHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frm_ReportHangHoa()
        {
            InitializeComponent();
        }

        private void frm_ReportHangHoa_Load(object sender, EventArgs e)
        {
            cmb_Type.SelectedIndex = 0;
            date_From.SelectedText = DateTime.Today.ToString("MM/yyyy");
            date_To.SelectedText = DateTime.Today.ToString("MM/yyyy");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
       
            if(!ValidateDateFrom(date_From))
            {
                date_From.Focus();
                return;
            }
            if (!ValidateDateTo(date_To))
            {
                date_To.Focus();
                return;
            }
            string role = Program.mGroup;
            DateTime dateFromTemp = date_From.DateTime.Date;
            
            string dateFrom = date_From.DateTime.ToString("yyyy-MM-dd");
        //    string dateFrom = date_From.DateTime.Year + "-" + date_From.DateTime.Month + "-" + 1;
              string dateTo = date_To.DateTime.ToString("yyyy-MM-dd");
       //     string dateTo = date_From.DateTime.Year + "-" + date_From.DateTime.Month + "-" + 1;
            string type = "";
          
            if (cmb_Type.Text.Contains("n"))
            {
                type = "n";
               
            }    
               
            else
            {
               type = "x";   
            }
            Xrpt_HangHoa rpt = new Xrpt_HangHoa(dateFrom, dateTo, role, type);
            if(type=="n")
            {
                rpt.label_TieuDe.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG NHẬP";
            }    
            else
            {
                rpt.label_TieuDe.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG XUẤT";
            }    
            if (date_From.DateTime.Year==date_To.DateTime.Year && date_From.DateTime.Month == date_To.DateTime.Month)
            {
                rpt.xrLabel_Center.Text = "Trong tháng " + date_From.DateTime.ToString("MM/yyyy");
                rpt.xrLabel_DateFrom.Visible = rpt.xrLabel_DateTo.Visible = false;
            }    
            else
            {
                rpt.xrLabel_Center.Visible = false;
                rpt.xrLabel_DateFrom.Text = "Từ tháng " + date_From.DateTime.ToString("MM/yyyy");
                rpt.xrLabel_DateTo.Text = "Đến tháng " + date_To.DateTime.ToString("MM/yyyy");
            }    
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();



        }

        private void date_From_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateFrom(date_From);
        }
        private bool ValidateDateFrom(DevExpress.XtraEditors.DateEdit txt)
        {
            bool bStatus = true;
           
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập ngày bắt đầu");
                    bStatus = false;
                }
                else
                    dxErrorProvider1.SetError(txt, null);
    
            
            return bStatus;
        }
        private bool ValidateDateTo(DevExpress.XtraEditors.DateEdit txt)
        {
            bool bStatus = true;

            if (txt.Text.Trim() == "")
            {
                dxErrorProvider1.SetError(txt, "Vui lòng nhập ngày kết thúc");
                bStatus = false;
            }
            else if (date_From.Text!="" && txt.DateTime.Month < date_From.DateTime.Month && txt.DateTime.Year == date_From.DateTime.Year)
            {
                dxErrorProvider1.SetError(txt, "Ngày kết thúc không được nhỏ hơn ngày bắt đầu");
                bStatus = false;
            }
            else
                dxErrorProvider1.SetError(txt, null);
            return bStatus;
        }

        private void date_To_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateFrom(date_To);
        }
    }
}