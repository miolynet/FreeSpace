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
using System.Windows.Navigation;

namespace SilverlightBusinessApplication1.Views
{
    public partial class MyInfomationPage : Page
    {
        public MyInfomationPage()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //YourNameLabel.Content = NameTextBox.Text;

            //MyCombobox.Items.Add(NameTextBox.Text);


            //YourNameLabel.Content = MyCalendar.SelectedDate;

        }

    }
}