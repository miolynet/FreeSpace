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
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Sample_ToolKitChart.Model;

namespace Sample_ToolKitChart.ViewModels
{
    public class ColumnViewModel : INotifyPropertyChanged
    {
        private string _name01;
        private PointCollection _points01;
        private string _name02;
        private PointCollection _points02;
        private PointCollection _twoWins;

        public PointCollection TwoWins
        {
            get { return _twoWins; }
            set
            {
                _twoWins = value;
                raisePropertyChanged("TwoWins");
            }
        }

        public string Name01
        {
            get { return _name01; }
            set
            {
                _name01 = value;
                raisePropertyChanged("Name01");
            }
        }

        public PointCollection Points01
        {
            get { return _points01; }
            set
            {
                _points01 = value;
                raisePropertyChanged("Points01");
            }
        }

        public string Name02
        {
            get { return _name02; }
            set
            {
                _name02 = value;
                raisePropertyChanged("Name02");
            }
        }

        public PointCollection Points02
        {
            get { return _points02; }
            set
            {
                _points02 = value;
                raisePropertyChanged("Points02");
            }
        }


        public ColumnViewModel()
        {
            _points01 = new PointCollection();
            _points02 = new PointCollection();
            _twoWins = new PointCollection();

            if (DesignerProperties.IsInDesignTool || true)
            {
                Random random = new Random();
                //Name01 = "Information 01";
                //for (int count = 0; count < 3; count++)
                //{
                //    Points01.Add(new Point
                //                {
                //                    X = (int)random.Next(0, 10),
                //                    Y = count
                //                });
                //}

                //Name02 = "Information 02";
                //for (int count = 0; count < 5; count++)
                //{
                //    Points02.Add(new Point
                //    {
                //        X = (int)random.Next(0, 20),
                //        Y = count
                //    });
                //}

                double pot = 0;
                for (int count = 0; count < 100; count++)
                {
                    pot += random.Next(1, 500);
                    TwoWins.Add(new Point
                    {
                        Y = count*5,
                        X = pot
                    });
                }
            }
        }

        #region Methods

        public void raisePropertyChanged(string propertyName)
        {
            var temp = PropertyChanged;
            if (temp != null)
            {
                temp(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion Methods

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
