Namespace NewProject
	Partial Public Class Dashboard1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dashboardObjectDataSource2 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardObjectDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' gridDashboardItem1
			' 
			dimension1.DataMember = "SalesPerson"
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension1)
			measure1.DataMember = "Quantity"
			gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridMeasureColumn1.AddDataItem("Measure", measure1)
			Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridMeasureColumn1})
			Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
			Me.gridDashboardItem1.DataItemRepository.Clear()
			Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.gridDashboardItem1.DataSource = Me.dashboardObjectDataSource2
			Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridDashboardItem1.Name = "Grid 1"
			Me.gridDashboardItem1.ShowCaption = True
			' 
			' chartDashboardItem1
			' 
			dimension2.DataMember = "SalesPerson"
			Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.chartDashboardItem1.AxisX.TitleVisible = False
			Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
			measure2.DataMember = "Quantity"
			Me.chartDashboardItem1.DataItemRepository.Clear()
			Me.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1")
			Me.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
			Me.chartDashboardItem1.DataSource = Me.dashboardObjectDataSource2
			Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartDashboardItem1.Name = "Chart 1"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.AddDataItem("Value", measure2)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartDashboardItem1.ShowCaption = True
			' 
			' dashboardObjectDataSource2
			' 
			Me.dashboardObjectDataSource2.ComponentName = "dashboardObjectDataSource2"
			Me.dashboardObjectDataSource2.DataSource = GetType(NewProject.Data)
			Me.dashboardObjectDataSource2.Name = "Object Data Source 1"
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardObjectDataSource2})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridDashboardItem1, Me.chartDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
			dashboardLayoutItem1.Weight = 39.098532494758906R
			dashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
			dashboardLayoutItem2.Weight = 60.901467505241094R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Dashboard"
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardObjectDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region
		Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
		Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
		Private dashboardObjectDataSource2 As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace
