using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Controls.DataVisualization.Charting;

namespace Sample_ToolKitChart
{
    public partial class LineUI : UserControl
    {
        public LineUI()
        {
            
            InitializeComponent();
            //((LineSeries)this.chartLine.Series[0]).ItemsSource = new KeyValuePair<int, int>[]
            //{
            //    new KeyValuePair<int,int>(1, 1),
            //    new KeyValuePair<int,int>(2, 5),
            //    new KeyValuePair<int,int>(3, 9),
            //    new KeyValuePair<int,int>(5, 7),
            //    new KeyValuePair<int,int>(6, 4),
            //    new KeyValuePair<int,int>(9, 3),
            //    new KeyValuePair<int,int>(20, 3),
            //};
        }
    }
}