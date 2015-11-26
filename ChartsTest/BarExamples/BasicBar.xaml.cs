﻿using System.Windows;

namespace ChartsTest.BarExamples
{
    /// <summary>
    /// Interaction logic for BasicBar.xaml
    /// </summary>
    public partial class BasicBar
    {
        public BasicBar()
        {
            InitializeComponent();
            //PrimaryAxis.LabelFormatter = val => val + " items";
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            //this is just to see animation everytime you click next
            Chart.ClearAndPlot();
        }
    }
}
