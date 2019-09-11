Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

Namespace NewProject
	Partial Public Class Form1
		Inherits XtraForm

		Private ds As List(Of Data) = Data.CreateData()
		Public Sub New()
			InitializeComponent()
			AddHandler dashboardViewer1.DataLoading, AddressOf dashboardViewer1_DataLoading
			dashboardViewer1.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs
			dashboardViewer1.DashboardSource = GetType(Dashboard1)
		End Sub

		Private Sub dashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DevExpress.DashboardCommon.DataLoadingEventArgs)
			e.Data = ds
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
'INSTANT VB NOTE: The variable controls was renamed since Visual Basic does not handle local variables named the same as class members well:
		   Dim controls_Renamed As DashboardItemCollection = dashboardViewer1.Dashboard.Items
			PrintControlInfo(controls_Renamed)
		End Sub
		Private Shared Sub PrintControlInfo(ByVal controls As IEnumerable(Of DashboardItem))
			Dim stringBuilder As New StringBuilder()
			For Each control As DashboardItem In controls
				stringBuilder.AppendLine(control.GetType().ToString())
			Next control
			XtraMessageBox.Show(stringBuilder.ToString())
		End Sub
	End Class
End Namespace