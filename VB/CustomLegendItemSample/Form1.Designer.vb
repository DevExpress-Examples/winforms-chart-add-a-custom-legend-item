Namespace CustomLegendItemSample
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (DirectCast(17.0752R, Object))}, 0)
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() { (DirectCast(9.98467R, Object))}, 1)
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("USA", New Object() { (DirectCast(9.63142R, Object))}, 2)
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("China", New Object() { (DirectCast(9.59696R, Object))}, 3)
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (DirectCast(8.511965R, Object))}, 4)
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() { (DirectCast(7.68685R, Object))}, 5)
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("India", New Object() { (DirectCast(3.28759R, Object))}, 6)
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Others", New Object() { (DirectCast(81.2R, Object))}, 7)
            Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.LegendTextPattern = "{A}: {VP:P}"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            series1.View = pieSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chart.Size = New System.Drawing.Size(1264, 681)
            Me.chart.TabIndex = 0
            chartTitle1.Text = "Area of Countries"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 681)
            Me.Controls.Add(Me.chart)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chart As DevExpress.XtraCharts.ChartControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

