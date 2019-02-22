using DevExpress.DashboardCommon;
using DevExpress.DataAccess;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : XtraForm
    {
        List<Data> ds = Data.CreateData();
        public Form1()
        {
            InitializeComponent();
            dashboardViewer1.DataLoading += dashboardViewer1_DataLoading;
            dashboardViewer1.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs;
            dashboardViewer1.DashboardSource = typeof(Dashboard1);
        }

        private void dashboardViewer1_DataLoading(object sender, DevExpress.DashboardCommon.DataLoadingEventArgs e) {
            e.Data = ds;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           DashboardItemCollection controls = dashboardViewer1.Dashboard.Items;
            PrintControlInfo(controls);
        }
        private static void PrintControlInfo(IEnumerable<DashboardItem> controls)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (DashboardItem control in controls)
                stringBuilder.AppendLine(control.GetType().ToString());
            XtraMessageBox.Show(stringBuilder.ToString());
        }
    }
}