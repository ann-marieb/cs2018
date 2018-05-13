//ArrivalWindow.xaml.cs
//Ann-Marie Bergström ai2436
//2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for ArrivalWindow.xaml
    /// </summary>
    public partial class ArrivalWindow : Window
    {
        // Holds information for the ListView of flight actions
        private List<FlightEventsArgs> flightItems = new List<FlightEventsArgs>();

        /// <summary>
        /// constructor
        /// </summary>
        public ArrivalWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for flight landed events - flight info to listview
        /// </summary>
        /// <param name="sender">sender of the event</param>
        /// <param name="e">event arguments</param>
        public void OnArrivalHandler(object sender, FlightEventsArgs e)
            {
                flightItems.Add(e);
                Flights.ItemsSource = null;
                Flights.ItemsSource = flightItems;

                Flights.UpdateLayout();
            }
    }
}
