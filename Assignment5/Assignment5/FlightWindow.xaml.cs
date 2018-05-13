//FlightWindow.xaml.cs
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
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow : Window
    {
        private string flightNumber;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="flightNumber"></param>
        public FlightWindow(string flightNumberReceived)
        {
            flightNumber = flightNumberReceived;
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// initialize user interface
        /// </summary>
        private void InitializeGUI()
        {
            btnStart.IsEnabled = true;
            lblChange.IsEnabled = false;
            cbxChangeRoute.IsEnabled = false;
            btnLand.IsEnabled = false;
            Title = "Flight " + flightNumber;
            GetAirlineImage(); // get airline image
        }

        /// <summary>
        /// ger airline image
        /// </summary>
        private void GetAirlineImage()
        {
            string airlineLogo;
            string airlineCode;

            airlineCode = flightNumber.ToUpper(); 
            if (airlineCode.Length > 2)
                airlineCode = airlineCode.Substring(0, 2); // truncate to two letters if longer than two

            switch (airlineCode)
            {
                case "DL":
                    airlineLogo = "icons/delta.png";
                    break;
                case "KL":
                    airlineLogo = "icons/klm.png";
                    break;
                case "DY":
                    airlineLogo = "icons/norwegian.png";
                    break;
                case "QR":
                    airlineLogo = "icons/qatar.jpeg";
                    break;
                case "SQ":
                    airlineLogo = "icons/singapore.png";
                    break;
                default:
                    airlineLogo = "icons/q128-128.png";
                    break;
            }
            BitmapImage airlineImage = new BitmapImage(new Uri(airlineLogo, UriKind.Relative));
            logo.Source = airlineImage;
        }

        public event EventHandler<FlightEventsArgs> ChangesHandler; // event defined based on delegate EventHandler
        public event EventHandler<FlightEventsArgs> LandedHandler; // event defined based on delegate EventHandler

        #region on start
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            OnStarted();
            btnStart.IsEnabled = false; 
            lblChange.IsEnabled = true;
            cbxChangeRoute.IsEnabled = true;
            btnLand.IsEnabled = true;
        }

        protected virtual void OnStarted()
        {
            // if there are subscribers
            if (ChangesHandler != null)
            ChangesHandler?.Invoke(this, new FlightEventsArgs()
            {
                FlightNumber = flightNumber,
                FlightAction = "started",
                DateTime = DateTime.Now
            });
        }
        #endregion

        #region on landing
        private void btnLand_Click(object sender, RoutedEventArgs e)
        {
            OnLanded();
            Close(); // close Flight Window
        }

        protected virtual void OnLanded()
        {
            // if there are subscribers
            if (LandedHandler != null)
                LandedHandler?.Invoke(this, new FlightEventsArgs()
                {
                    FlightNumber = flightNumber,
                    FlightAction = "landed",
                    DateTime = DateTime.Now
                });
        }
        #endregion

        #region on changed route
        private void cbxChangeRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OnChanged();
        }

        protected virtual void OnChanged()
        {
            // if there are subscribers
            if (ChangesHandler != null)
                ChangesHandler?.Invoke(this, new FlightEventsArgs()
                {
                    FlightNumber = flightNumber,
                    FlightAction = "changed to " + cbxChangeRoute.SelectedValue,
                    DateTime = DateTime.Now
                });
        }
        #endregion
    }
}
