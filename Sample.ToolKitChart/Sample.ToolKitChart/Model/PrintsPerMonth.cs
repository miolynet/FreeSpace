using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Sample_ToolKitChart.Model
{
    public class PrintsPerMonth
    {
        public string Printer { get; set; }
        public DateTime Month { get; set; }
        public int Pages { get; set; }
    }
}
