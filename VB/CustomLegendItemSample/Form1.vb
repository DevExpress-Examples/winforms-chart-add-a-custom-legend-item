﻿Imports DevExpress.XtraCharts
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace CustomLegendItemSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
'            #Region "#CustomLegendItems"
            ' Create a new custom item.
            Dim item As New CustomLegendItem()
            chart.Legend.CustomItems.Add(item)
            ' Specify its text and marker.
            item.Text = "Custom Legend Item"
            Dim bitmap As New Bitmap("Image\DXLogo_16x16.png")
            item.MarkerImage.Image = bitmap
            ' Set a value indicating that both autogenerated and custom items are displayed.
            chart.Legend.ItemVisibilityMode = LegendItemVisibilityMode.AutoGeneratedAndCustom
'            #End Region ' #CustomLegendItems
        End Sub
    End Class
End Namespace