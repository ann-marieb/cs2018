//MainWindow.xaml.cs
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      // Holds information for the ListView of flight actions
        private List<FlightEventsArgs> flightItems = new List<FlightEventsArgs>();

        ArrivalWindow arrivalWindowObj; //declare Arrival Window object

        /// <summary>
        /// constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// initiialize user interface
        /// </summary>
        private void InitializeGUI()
        {
            btnSend.IsEnabled = false; // greyout send button 

            arrivalWindowObj = new ArrivalWindow(); // create Arrival Window object
            arrivalWindowObj.Show();
        }

        /// <summary>
        /// when flight number is written
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFlightNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnSend.IsEnabled = txtFlightNumber.Text.Length > 0; // ungrey send button
        }

        /// <summary>
        /// on send button click Flight Window is created and subscribers defined
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            var flightNumber = txtFlightNumber.Text; // 
            FlightWindow flightWindowObj = new FlightWindow(flightNumber); // declare and create Flight Window object (publisher)
            flightWindowObj.Show();
            flightWindowObj.ChangesHandler += OnChangesHandler; // add subscriber
            flightWindowObj.LandedHandler += OnChangesHandler; // add subscriber
            flightWindowObj.LandedHandler += arrivalWindowObj.OnArrivalHandler; // add subscriber
        }

        /// <summary>
        /// Event handler for flight change events - flight info to listview
        /// </summary>
        /// <param name="sender">sender of the event</param>
        /// <param name="e">event arguments</param>
        private void OnChangesHandler(object sender, FlightEventsArgs e)
        {
            flightItems.Add(e); // flight info added to flightItems
            Flights.ItemsSource = null;
            Flights.ItemsSource = flightItems; //flightItems to be displayed in ListView Flights
            Flights.UpdateLayout();
        }
    }
}
