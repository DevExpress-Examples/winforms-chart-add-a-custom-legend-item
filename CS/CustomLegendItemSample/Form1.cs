﻿using DevExpress.Drawing;
using DevExpress.XtraCharts;
using System;
using System.IO;
using System.Windows.Forms;

namespace CustomLegendItemSample
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            #region #CustomLegendItems
            // Create a new custom item.
            CustomLegendItem item = new CustomLegendItem();
            chart.Legend.CustomItems.Add(item);
            // Specify its text and marker.
            item.Text = "Custom Legend Item";
            FileStream outfile = new FileStream("Image\\DXLogo_16x16.png", FileMode.Open);
            DXImage image = DXImage.FromStream(outfile);
            item.MarkerImage.DXImage = image;

            // Set a value indicating that both autogenerated and custom items are displayed.
            chart.Legend.ItemVisibilityMode = LegendItemVisibilityMode.AutoGeneratedAndCustom;
            #endregion #CustomLegendItems
        }
    }
}
