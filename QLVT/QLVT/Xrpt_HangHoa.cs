using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_HangHoa : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_HangHoa(string datefrom, string dateTo, string role, string type)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = datefrom;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateTo;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = role;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = type;
        }

    }
}
