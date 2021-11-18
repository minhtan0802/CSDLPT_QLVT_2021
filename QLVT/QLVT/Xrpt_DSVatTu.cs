using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;


namespace QLVT
{
    public partial class Xrpt_DSVatTu : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSVatTu()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
