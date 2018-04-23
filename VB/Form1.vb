Imports Microsoft.VisualBasic
Imports DevExpress.DashboardWin.Native
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

Namespace NewProject
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub dashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DevExpress.DataAccess.DataLoadingEventArgs) Handles dashboardViewer1.DataLoading
			Dim list As List(Of [MyClass]) = CreateDataSource()
			e.Data = list
		End Sub
		Private Shared Function CreateDataSource() As List(Of [MyClass])
			Dim list As New List(Of [MyClass])(10)
			Dim _r As New Random()
			For i As Integer = 0 To list.Capacity - 1
				list.Add(New [MyClass]() With {.ID = i, .Name = "Name" & i, .Sales = CSng(_r.NextDouble()), .Date = DateTime.Now.AddDays(i)})
			Next i
			Return list
		End Function

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim controls As IEnumerable(Of Control) = (CType(dashboardViewer1, IUnderlyingControlProvider)).GetUnderlyingControls()
			PrintControlInfo(controls)
		End Sub
		Private Shared Sub PrintControlInfo(ByVal controls As IEnumerable(Of Control))
			Dim stringBuilder As New StringBuilder()
			For Each control As Control In controls
				stringBuilder.AppendLine(control.GetType().ToString())
			Next control
			XtraMessageBox.Show(stringBuilder.ToString())
		End Sub
	End Class
End Namespace