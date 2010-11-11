using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Controls.DataVisualization.Charting;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Sample_ToolKitChart.Model;

namespace Sample_ToolKitChart.ViewModels
{
    public class LineViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<KeyValuePair<string, int>> _informations01;
        private ObservableCollection<KeyValuePair<DateTime, int>> _informations02;
        private ObservableCollection<KeyValuePair<DateTime, int>> _twoWins;

        public ObservableCollection<KeyValuePair<DateTime, int>> TwoWins
        {
            get { return _twoWins; }
            set
            {
                _twoWins = value;
                raisePropertyChanged("TwoWins");
            }
        }

        public ObservableCollection<KeyValuePair<DateTime, int>> Informations02
        {
            get { return _informations02; }
            set
            {
                _informations02 = value;
                raisePropertyChanged("Informations02");
            }
        }

        public ObservableCollection<KeyValuePair<string, int>> Informations01
        {
            get { return _informations01; }
            set
            {
                _informations01 = value;
                raisePropertyChanged("Informations01");
            }
        }

        public LineViewModel()
        {
            _informations01 = new ObservableCollection<KeyValuePair<string, int>>();
            _informations02 = new ObservableCollection<KeyValuePair<DateTime, int>>();
            _twoWins = new ObservableCollection<KeyValuePair<DateTime, int>>();

            if (DesignerProperties.IsInDesignTool || true)
            {
                Random random = new Random();
                //Informations01.Add(new KeyValuePair<string, int>("1", random.Next(0, 25)));
                //Informations01.Add(new KeyValuePair<string, int>("2", random.Next(0, 25)));
                //Informations01.Add(new KeyValuePair<string, int>("3", random.Next(0, 25)));
                //Informations01.Add(new KeyValuePair<string, int>("4", random.Next(0, 25)));
                //Informations01.Add(new KeyValuePair<string, int>("5", random.Next(0, 25)));

                //Informations02.Add(new KeyValuePair<string, int>("1", random.Next(0, 25)));
                //Informations02.Add(new KeyValuePair<string, int>("2", random.Next(0, 25)));
                //Informations02.Add(new KeyValuePair<string, int>("3", random.Next(0, 25)));
                //Informations02.Add(new KeyValuePair<string, int>("4", random.Next(0, 25)));
                //Informations02.Add(new KeyValuePair<string, int>("5", random.Next(0, 25)));

                int pot1 = 0;
                int pot2 = 0;
                DateTime time = DateTime.Now;
                for (int count = 0; count < 40; count++)
                {
                    TwoWins.Add(new KeyValuePair<DateTime, int>(time, pot1));

                    Informations02.Add(new KeyValuePair<DateTime, int>(time, pot2));

                    pot1 += random.Next(random.Next(1, 50), random.Next(50, 500));
                    pot2 += random.Next(random.Next(1, 100), random.Next(300, 700));
                    time = time.Add(TimeSpan.FromMinutes(15));
                }
            }
        }

        public void raisePropertyChanged(string propertyName)
        {
            var temp = PropertyChanged;
            if (temp != null)
            {
                temp(this,new PropertyChangedEventArgs(propertyName));
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
