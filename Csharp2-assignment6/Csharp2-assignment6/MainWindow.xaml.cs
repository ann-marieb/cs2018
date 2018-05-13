/// MainWindow.xaml.cs.cs
/// Ann-Marie Bergström ai2436
/// 2018
 
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace Csharp2_assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        private string[] invoiceInfo; //array to store info from text file
        private int index;
        //decimal totalTotalTax = 0;
        private decimal totalTotal = 0;
        private int discount = 0;
        private bool initialized = false;
        #endregion

        /// <summary>
        /// default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            initialized = true;
            ReadFile(); // read file
            InvoiceInfo(); // write invoice specific info
            InvoiceReceiverInfo(); // write receiver info
            InvoiceItems(); // list items of the invoice
            InvoiceTotals(); // calculate total
            InvoiceSenderInfo(); // write sender info
        }

        /// <summary>
        /// Read each line of the file into a string array.
        ///  Each element of the array is one line of the file.
        /// </summary>
        private void ReadFile()
        {            
            string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName; // find folder 
            string file = System.IO.Path.Combine(folder, @"InvoiceDemo1.txt"); // combine folder and file name
            invoiceInfo = File.ReadAllLines(file); // read all lines of file into array
        }

        /// <summary>
        /// Read invoice info from array and write to GUI.
        /// </summary>
        private void InvoiceInfo()
        {
            lblInvoiceNumber.Content = invoiceInfo[0];
            dpInvoiceDate.Text = invoiceInfo[1];
            dpDueDate.Text = invoiceInfo[2];
        }

        /// <summary>
        /// write reciever name and address to GUI
        /// </summary>
        private void InvoiceReceiverInfo()
        {
            string receiver = "";
            // create address text string
            for (int i = 3; i <= 8; i++)
            {
                receiver += invoiceInfo[i] + "\n";
            }
            txtReceiver.Text = receiver;
        }

        /// <summary>
        /// list items of invoice
        /// </summary>
        private void InvoiceItems()
        {
            List<InvoiceItem> items = new List<InvoiceItem>();
            int i;
            string desc;
            int quantity;
            decimal unitPrice;
            decimal tax;
            decimal totalTax;
            decimal total;


            int noItems = Convert.ToInt32(invoiceInfo[9]);

            // for each row in list
            for (i = 1; i <= noItems; i++)
            {
                    int indexstart = 10 + (i - 1) * 4; //index for first info of item
                    desc = invoiceInfo[indexstart];
                    quantity = Convert.ToInt32(invoiceInfo[indexstart + 1]);
                    unitPrice = Convert.ToDecimal(invoiceInfo[indexstart + 2], CultureInfo.InvariantCulture); // decimalpoint in file
                    tax = Convert.ToDecimal(invoiceInfo[indexstart + 3]);
                    totalTax = quantity * unitPrice * tax / 100;
                    total = quantity * unitPrice + totalTax;
                    totalTotal += total;

                items.Add(new InvoiceItem()
                {
                    Item = i,
                    Desc = desc,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    Tax = tax,
                    TotalTax = totalTax,
                    Total = total
                });

                index = indexstart + 4; // index of info after items
            }

            lvInvoiceItems.ItemsSource = items;
        }

        /// <summary>
        /// calculate total and amount to pay
        /// </summary>
        private void InvoiceTotals()
        {
            lblTotal.Content = decimal.Round(totalTotal, 2, MidpointRounding.AwayFromZero);

            txtDiscount.Text = Convert.ToString(discount);

            lblAmount.Content = decimal.Round((totalTotal - discount), 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// write sender info to GUI
        /// </summary>
        private void InvoiceSenderInfo()
        {
            lblCompany.Content = invoiceInfo[index];
            string sender = "";
            for (int i = index+1; i <= index+4; i++)
            {
                sender += invoiceInfo[i] + "\n";
            }
            txtSenderAddress.Text = sender;

            txtPhone.Text = invoiceInfo[index + 5];
            txtHomePage.Text = invoiceInfo[index + 6];
        }

        /// <summary>
        /// when discount is changed by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (initialized)
            {
                try
                {
                    discount = Int32.Parse(txtDiscount.Text);
                    InvoiceTotals();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Only whole number accepted", "Error: Invalid value");
                }
            }
        }

        /// <summary>
        /// when user want to change image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeImage_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".png",
                Filter = "PNG files (*.png)|*.png"
            };

            // Display dialog
            var result = dlg.ShowDialog();

            if (result != true) return;
            // Open document
            var filename = dlg.FileName;

            try
            {
                var uri = new Uri(filename); //, UriKind.Relative);
                imgLogo.Source = new BitmapImage(uri);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bad image file. Try a different file", "Error: Invalid file");
            }
        }
    }
}
