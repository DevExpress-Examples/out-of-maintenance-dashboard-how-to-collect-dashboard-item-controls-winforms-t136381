using DevExpress.DashboardWin.Native;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dashboardViewer1_DataLoading(object sender, DevExpress.DataAccess.DataLoadingEventArgs e)
        {
            List<MyClass> list = CreateDataSource();
            e.Data = list;
        }
        private static List<MyClass> CreateDataSource()
        {
            List<MyClass> list = new List<MyClass>(10);
            Random _r = new Random();
            for (int i = 0; i < list.Capacity; i++)
                list.Add(new MyClass() { ID = i, Name = "Name" + i, Sales = (float)_r.NextDouble(), Date = DateTime.Now.AddDays(i)});
            return list;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            IEnumerable<Control> controls = ((IUnderlyingControlProvider)dashboardViewer1).GetUnderlyingControls();
            PrintControlInfo(controls);
        }
        private static void PrintControlInfo(IEnumerable<Control> controls)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Control control in controls)
                stringBuilder.AppendLine(control.GetType().ToString());
            XtraMessageBox.Show(stringBuilder.ToString());
        }
    }
}