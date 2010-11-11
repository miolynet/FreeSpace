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
using Sample_ToolKitChart.Model;

namespace Sample_ToolKitChart
{
    public partial class Line02UI : UserControl
    {
        public Line02UI()
        {
            InitializeComponent();
            List<PrintsPerMonth> lstPrints = new List<PrintsPerMonth>();
            lstPrints.Add(new PrintsPerMonth() { Printer = "Printer1", Month = new DateTime(2009, 1, 1), Pages = 80 });
            lstPrints.Add(new PrintsPerMonth() { Printer = "Printer1", Month = new DateTime(2009, 2, 1), Pages = 93 });
            lstPrints.Add(new PrintsPerMonth() { Printer = "Printer1", Month = new DateTime(2009, 3, 1), Pages = 140 });
            lstPrints.Add(new PrintsPerMonth() { Printer = "Printer2", Month = new DateTime(2009, 1, 1), Pages = 132 });
            lstPrints.Add(new PrintsPerMonth() { Printer = "Printer2", Month = new DateTime(2009, 2, 1), Pages = 100 });
            lstPrints.Add(new PrintsPerMonth() { Printer = "Printer2", Month = new DateTime(2009, 3, 1), Pages = 373 });
            //myChart.Series[0].DataContext = lstPrints.Where(p => p.Printer == "Printer1");
            //myChart.Series[1].DataContext = lstPrints.Where(p => p.Printer == "Printer2");
        }
    }
}
