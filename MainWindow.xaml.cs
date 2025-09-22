using Newtonsoft.Json;
using System.Data;
using System.Net.Http;
using System.Net.Security;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyConverter_Static
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Root val = new Root();

        public class Root
        { 
            public Rates rates { get; set; }
            public long timestamp;
            public string license;
        }

        public class Rates
        {
            public double AED { get; set; }
            public double AFN { get; set; }
            public double ALL { get; set; }
            public double AMD { get; set; }
            public double ANG { get; set; }
            public double AOA { get; set; }
            public double ARS { get; set; }
            public double AUD { get; set; }
            public double AWG { get; set; }
            public double AZN { get; set; }
            public double BAM { get; set; }
            public double BBD { get; set; }
            public double BDT { get; set; }
            public double BGN { get; set; }
            public double BHD { get; set; }
            public double BIF { get; set; }
            public double BMD { get; set; }
            public double BND { get; set; }
            public double BOB { get; set; }
            public double BRL { get; set; }
            public double BSD { get; set; }
            public double BTC { get; set; }
            public double BTN { get; set; }
            public double BWP { get; set; }
            public double BYN { get; set; }
            public double BZD { get; set; }
            public double CAD { get; set; }
            public double CDF { get; set; }
            public double CHF { get; set; }
            public double CLF { get; set; }
            public double CLP { get; set; }
            public double CNH { get; set; }
            public double CNY { get; set; }
            public double COP { get; set; }
            public double CRC { get; set; }
            public double CUC { get; set; }
            public double CUP { get; set; }
            public double CVE { get; set; }
            public double CZK { get; set; }
            public double DJF { get; set; }
            public double DKK { get; set; }
            public double DOP { get; set; }
            public double DZD { get; set; }
            public double EGP { get; set; }
            public double ERN { get; set; }
            public double ETB { get; set; }
            public double EUR { get; set; }
            public double FJD { get; set; }
            public double FKP { get; set; }
            public double GBP { get; set; }
            public double GEL { get; set; }
            public double GGP { get; set; }
            public double GHS { get; set; }
            public double GIP { get; set; }
            public double GMD { get; set; }
            public double GNF { get; set; }
            public double GTQ { get; set; }
            public double GYD { get; set; }
            public double HKD { get; set; }
            public double HNL { get; set; }
            public double HRK { get; set; }
            public double HTG { get; set; }
            public double HUF { get; set; }
            public double IDR { get; set; }
            public double ILS { get; set; }
            public double IMP { get; set; }
            public double INR { get; set; }
            public double IQD { get; set; }
            public double IRR { get; set; }
            public double ISK { get; set; }
            public double JEP { get; set; }
            public double JMD { get; set; }
            public double JOD { get; set; }
            public double JPY { get; set; }
            public double KES { get; set; }
            public double KGS { get; set; }
            public double KHR { get; set; }
            public double KMF { get; set; }
            public double KPW { get; set; }
            public double KRW { get; set; }
            public double KWD { get; set; }
            public double KYD { get; set; }
            public double KZT { get; set; }
            public double LAK { get; set; }
            public double LBP { get; set; }
            public double LKR { get; set; }
            public double LRD { get; set; }
            public double LSL { get; set; }
            public double LYD { get; set; }
            public double MAD { get; set; }
            public double MDL { get; set; }
            public double MGA { get; set; }
            public double MKD { get; set; }
            public double MMK { get; set; }
            public double MNT { get; set; }
            public double MOP { get; set; }
            public double MRU { get; set; }
            public double MUR { get; set; }
            public double MVR { get; set; }
            public double MWK { get; set; }
            public double MXN { get; set; }
            public double MYR { get; set; }
            public double MZN { get; set; }
            public double NAD { get; set; }
            public double NGN { get; set; }
            public double NIO { get; set; }
            public double NOK { get; set; }
            public double NPR { get; set; }
            public double NZD { get; set; }
            public double OMR { get; set; }
            public double PAB { get; set; }
            public double PEN { get; set; }
            public double PGK { get; set; }
            public double PHP { get; set; }
            public double PKR { get; set; }
            public double PLN { get; set; }
            public double PYG { get; set; }
            public double QAR { get; set; }
            public double RON { get; set; }
            public double RSD { get; set; }
            public double RUB { get; set; }
            public double RWF { get; set; }
            public double SAR { get; set; }
            public double SBD { get; set; }
            public double SCR { get; set; }
            public double SDG { get; set; }
            public double SEK { get; set; }
            public double SGD { get; set; }
            public double SHP { get; set; }
            public double SLE { get; set; }
            public double SLL { get; set; }
            public double SOS { get; set; }
            public double SRD { get; set; }
            public double SSP { get; set; }
            public double STD { get; set; }
            public double STN { get; set; }
            public double SVC { get; set; }
            public double SYP { get; set; }
            public double SZL { get; set; }
            public double THB { get; set; }
            public double TJS { get; set; }
            public double TMT { get; set; }
            public double TND { get; set; }
            public double TOP { get; set; }
            public double TRY { get; set; }
            public double TTD { get; set; }
            public double TWD { get; set; }
            public double TZS { get; set; }
            public double UAH { get; set; }
            public double UGX { get; set; }
            public double USD { get; set; }
            public double UYU { get; set; }
            public double UZS { get; set; }
            public double VEF { get; set; }
            public double VES { get; set; }
            public double VND { get; set; }
            public double VUV { get; set; }
            public double WST { get; set; }
            public double XAF { get; set; }
            public double XAG { get; set; }
            public double XAU { get; set; }
            public double XCD { get; set; }
            public double XCG { get; set; }
            public double XDR { get; set; }
            public double XOF { get; set; }
            public double XPD { get; set; }
            public double XPF { get; set; }
            public double XPT { get; set; }
            public double YER { get; set; }
            public double ZAR { get; set; }
            public double ZMK { get; set; }
            public double ZMW { get; set; }
            public double ZWG { get; set; }
            public double ZWL { get; set; }

        }


        public MainWindow()
        {
            InitializeComponent();
            getValues();
            txtCurrency.Focus();
        }

        public async void getValues()
        {
            val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=02c58b7c0a004f67b249cad7a63a2127");
            BindCurrency();
        }


        public async Task<Root> GetData<T>(string url)
        { 
            var myRoot = new Root();
            try
            {
                using (var client = new HttpClient())
                {
                    // the timespan to wait before the request times out
                    client.Timeout = TimeSpan.FromMinutes(1);

                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var ResponseString = await response.Content.ReadAsStringAsync();
                        var ResponceObject = JsonConvert.DeserializeObject<Root>(ResponseString);

                        DateTime date = DateTimeOffset.FromUnixTimeSeconds(ResponceObject.timestamp).DateTime;
                        string formattedDate = date.ToString("dd-MMM-yyyy");
                        string formattedTime = date.ToLongTimeString();
                        DateAndTimeLabel.Content = "Latest Currency Update:";
                        dateStamp.Content = formattedDate;
                        timeStamp.Content = formattedTime;
                        lblResult.Content = "License : " + ResponceObject.license.ToString();

                        return ResponceObject;
                    }
                    return myRoot;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return myRoot;
            }
        }



        /// <summary>
        /// Populates the currency ComboBoxes with available currencies and their conversion rates.
        /// </summary>
        private void BindCurrency() 
        { 
            DataTable dtCurrency = new DataTable();
            dtCurrency.Columns.Add("Text");
            dtCurrency.Columns.Add("Value");

            // Add rows in the DataTable with text and value
            // ToDo : Get the currency list from a reliable source or API in future
            dtCurrency.Rows.Add("--SELECT--", "0");
            dtCurrency.Rows.Add("AED", val.rates.AED);
            dtCurrency.Rows.Add("AFN", val.rates.AFN);
            dtCurrency.Rows.Add("ALL", val.rates.ALL);
            dtCurrency.Rows.Add("AMD", val.rates.AMD);
            dtCurrency.Rows.Add("ANG", val.rates.ANG);
            dtCurrency.Rows.Add("AOA", val.rates.AOA);
            dtCurrency.Rows.Add("ARS", val.rates.ARS);
            dtCurrency.Rows.Add("AUD", val.rates.AUD);
            dtCurrency.Rows.Add("AWG", val.rates.AWG);
            dtCurrency.Rows.Add("AZN", val.rates.AZN);
            dtCurrency.Rows.Add("BAM", val.rates.BAM);
            dtCurrency.Rows.Add("BBD", val.rates.BBD);
            dtCurrency.Rows.Add("BDT", val.rates.BDT);
            dtCurrency.Rows.Add("BGN", val.rates.BGN);
            dtCurrency.Rows.Add("BHD", val.rates.BHD);
            dtCurrency.Rows.Add("BIF", val.rates.BIF);
            dtCurrency.Rows.Add("BMD", val.rates.BMD);
            dtCurrency.Rows.Add("BND", val.rates.BND);
            dtCurrency.Rows.Add("BOB", val.rates.BOB);
            dtCurrency.Rows.Add("BRL", val.rates.BRL);
            dtCurrency.Rows.Add("BSD", val.rates.BSD);
            dtCurrency.Rows.Add("BTC", val.rates.BTC);
            dtCurrency.Rows.Add("BTN", val.rates.BTN);
            dtCurrency.Rows.Add("BWP", val.rates.BWP);
            dtCurrency.Rows.Add("BYN", val.rates.BYN);
            dtCurrency.Rows.Add("BZD", val.rates.BZD);
            dtCurrency.Rows.Add("CAD", val.rates.CAD);
            dtCurrency.Rows.Add("CDF", val.rates.CDF);
            dtCurrency.Rows.Add("CHF", val.rates.CHF);
            dtCurrency.Rows.Add("CLF", val.rates.CLF);
            dtCurrency.Rows.Add("CLP", val.rates.CLP);
            dtCurrency.Rows.Add("CNH", val.rates.CNH);
            dtCurrency.Rows.Add("CNY", val.rates.CNY);
            dtCurrency.Rows.Add("COP", val.rates.COP);
            dtCurrency.Rows.Add("CRC", val.rates.CRC);
            dtCurrency.Rows.Add("CUC", val.rates.CUC);
            dtCurrency.Rows.Add("CUP", val.rates.CUP);
            dtCurrency.Rows.Add("CVE", val.rates.CVE);
            dtCurrency.Rows.Add("CZK", val.rates.CZK);
            dtCurrency.Rows.Add("DJF", val.rates.DJF);
            dtCurrency.Rows.Add("DKK", val.rates.DKK);
            dtCurrency.Rows.Add("DOP", val.rates.DOP);
            dtCurrency.Rows.Add("DZD", val.rates.DZD);
            dtCurrency.Rows.Add("EGP", val.rates.EGP);
            dtCurrency.Rows.Add("ERN", val.rates.ERN);
            dtCurrency.Rows.Add("ETB", val.rates.ETB);
            dtCurrency.Rows.Add("EUR", val.rates.EUR);
            dtCurrency.Rows.Add("FJD", val.rates.FJD);
            dtCurrency.Rows.Add("FKP", val.rates.FKP);
            dtCurrency.Rows.Add("GBP", val.rates.GBP);
            dtCurrency.Rows.Add("GEL", val.rates.GEL);
            dtCurrency.Rows.Add("GGP", val.rates.GGP);
            dtCurrency.Rows.Add("GHS", val.rates.GHS);
            dtCurrency.Rows.Add("GIP", val.rates.GIP);
            dtCurrency.Rows.Add("GMD", val.rates.GMD);
            dtCurrency.Rows.Add("GNF", val.rates.GNF);
            dtCurrency.Rows.Add("GTQ", val.rates.GTQ);
            dtCurrency.Rows.Add("GYD", val.rates.GYD);
            dtCurrency.Rows.Add("HKD", val.rates.HKD);
            dtCurrency.Rows.Add("HNL", val.rates.HNL);
            dtCurrency.Rows.Add("HRK", val.rates.HRK);
            dtCurrency.Rows.Add("HTG", val.rates.HTG);
            dtCurrency.Rows.Add("HUF", val.rates.HUF);
            dtCurrency.Rows.Add("IDR", val.rates.IDR);
            dtCurrency.Rows.Add("ILS", val.rates.ILS);
            dtCurrency.Rows.Add("IMP", val.rates.IMP);
            dtCurrency.Rows.Add("INR", val.rates.INR);
            dtCurrency.Rows.Add("IQD", val.rates.IQD);
            dtCurrency.Rows.Add("IRR", val.rates.IRR);
            dtCurrency.Rows.Add("ISK", val.rates.ISK);
            dtCurrency.Rows.Add("JEP", val.rates.JEP);
            dtCurrency.Rows.Add("JMD", val.rates.JMD);
            dtCurrency.Rows.Add("JOD", val.rates.JOD);
            dtCurrency.Rows.Add("JPY", val.rates.JPY);
            dtCurrency.Rows.Add("KES", val.rates.KES);
            dtCurrency.Rows.Add("KGS", val.rates.KGS);
            dtCurrency.Rows.Add("KHR", val.rates.KHR);
            dtCurrency.Rows.Add("KMF", val.rates.KMF);
            dtCurrency.Rows.Add("KPW", val.rates.KPW);
            dtCurrency.Rows.Add("KRW", val.rates.KRW);
            dtCurrency.Rows.Add("KWD", val.rates.KWD);
            dtCurrency.Rows.Add("KYD", val.rates.KYD);
            dtCurrency.Rows.Add("KZT", val.rates.KZT);
            dtCurrency.Rows.Add("LAK", val.rates.LAK);
            dtCurrency.Rows.Add("LBP", val.rates.LBP);
            dtCurrency.Rows.Add("LKR", val.rates.LKR);
            dtCurrency.Rows.Add("LRD", val.rates.LRD);
            dtCurrency.Rows.Add("LSL", val.rates.LSL);
            dtCurrency.Rows.Add("LYD", val.rates.LYD);
            dtCurrency.Rows.Add("MAD", val.rates.MAD);
            dtCurrency.Rows.Add("MDL", val.rates.MDL);
            dtCurrency.Rows.Add("MGA", val.rates.MGA);
            dtCurrency.Rows.Add("MKD", val.rates.MKD);
            dtCurrency.Rows.Add("MMK", val.rates.MMK);
            dtCurrency.Rows.Add("MNT", val.rates.MNT);
            dtCurrency.Rows.Add("MOP", val.rates.MOP);
            dtCurrency.Rows.Add("MRU", val.rates.MRU);
            dtCurrency.Rows.Add("MUR", val.rates.MUR);
            dtCurrency.Rows.Add("MVR", val.rates.MVR);
            dtCurrency.Rows.Add("MWK", val.rates.MWK);
            dtCurrency.Rows.Add("MXN", val.rates.MXN);
            dtCurrency.Rows.Add("MYR", val.rates.MYR);
            dtCurrency.Rows.Add("MZN", val.rates.MZN);
            dtCurrency.Rows.Add("NAD", val.rates.NAD);
            dtCurrency.Rows.Add("NGN", val.rates.NGN);
            dtCurrency.Rows.Add("NIO", val.rates.NIO);
            dtCurrency.Rows.Add("NOK", val.rates.NOK);
            dtCurrency.Rows.Add("NPR", val.rates.NPR);
            dtCurrency.Rows.Add("NZD", val.rates.NZD);
            dtCurrency.Rows.Add("OMR", val.rates.OMR);
            dtCurrency.Rows.Add("PAB", val.rates.PAB);
            dtCurrency.Rows.Add("PEN", val.rates.PEN);
            dtCurrency.Rows.Add("PGK", val.rates.PGK);
            dtCurrency.Rows.Add("PHP", val.rates.PHP);
            dtCurrency.Rows.Add("PKR", val.rates.PKR);
            dtCurrency.Rows.Add("PLN", val.rates.PLN);
            dtCurrency.Rows.Add("PYG", val.rates.PYG);
            dtCurrency.Rows.Add("QAR", val.rates.QAR);
            dtCurrency.Rows.Add("RON", val.rates.RON);
            dtCurrency.Rows.Add("RSD", val.rates.RSD);
            dtCurrency.Rows.Add("RUB", val.rates.RUB);
            dtCurrency.Rows.Add("RWF", val.rates.RWF);
            dtCurrency.Rows.Add("SAR", val.rates.SAR);
            dtCurrency.Rows.Add("SBD", val.rates.SBD);
            dtCurrency.Rows.Add("SCR", val.rates.SCR);
            dtCurrency.Rows.Add("SDG", val.rates.SDG);
            dtCurrency.Rows.Add("SEK", val.rates.SEK);
            dtCurrency.Rows.Add("SGD", val.rates.SGD);
            dtCurrency.Rows.Add("SHP", val.rates.SHP);
            dtCurrency.Rows.Add("SLE", val.rates.SLE);
            dtCurrency.Rows.Add("SLL", val.rates.SLL);
            dtCurrency.Rows.Add("SOS", val.rates.SOS);
            dtCurrency.Rows.Add("SRD", val.rates.SRD);
            dtCurrency.Rows.Add("SSP", val.rates.SSP);
            dtCurrency.Rows.Add("STD", val.rates.STD);
            dtCurrency.Rows.Add("STN", val.rates.STN);
            dtCurrency.Rows.Add("SVC", val.rates.SVC);
            dtCurrency.Rows.Add("SYP", val.rates.SYP);
            dtCurrency.Rows.Add("SZL", val.rates.SZL);
            dtCurrency.Rows.Add("THB", val.rates.THB);
            dtCurrency.Rows.Add("TJS", val.rates.TJS);
            dtCurrency.Rows.Add("TMT", val.rates.TMT);
            dtCurrency.Rows.Add("TND", val.rates.TND);
            dtCurrency.Rows.Add("TOP", val.rates.TOP);
            dtCurrency.Rows.Add("TRY", val.rates.TRY);
            dtCurrency.Rows.Add("TTD", val.rates.TTD);
            dtCurrency.Rows.Add("TWD", val.rates.TWD);
            dtCurrency.Rows.Add("TZS", val.rates.TZS);
            dtCurrency.Rows.Add("UAH", val.rates.UAH);
            dtCurrency.Rows.Add("UGX", val.rates.UGX);
            dtCurrency.Rows.Add("USD", val.rates.USD);
            dtCurrency.Rows.Add("UYU", val.rates.UYU);
            dtCurrency.Rows.Add("UZS", val.rates.UZS);
            dtCurrency.Rows.Add("VEF", val.rates.VEF);
            dtCurrency.Rows.Add("VES", val.rates.VES);
            dtCurrency.Rows.Add("VND", val.rates.VND);
            dtCurrency.Rows.Add("VUV", val.rates.VUV);
            dtCurrency.Rows.Add("WST", val.rates.WST);
            dtCurrency.Rows.Add("XAF", val.rates.XAF);
            dtCurrency.Rows.Add("XAG", val.rates.XAG);
            dtCurrency.Rows.Add("XAU", val.rates.XAU);
            dtCurrency.Rows.Add("XCD", val.rates.XCD);
            dtCurrency.Rows.Add("XCG", val.rates.XCG);
            dtCurrency.Rows.Add("XDR", val.rates.XDR);
            dtCurrency.Rows.Add("XOF", val.rates.XOF);
            dtCurrency.Rows.Add("XPD", val.rates.XPD);
            dtCurrency.Rows.Add("XPF", val.rates.XPF);
            dtCurrency.Rows.Add("XPT", val.rates.XPT);
            dtCurrency.Rows.Add("YER", val.rates.YER);
            dtCurrency.Rows.Add("ZAR", val.rates.ZAR);
            dtCurrency.Rows.Add("ZMK", val.rates.ZMK);
            dtCurrency.Rows.Add("ZMW", val.rates.ZMW);
            dtCurrency.Rows.Add("ZWG", val.rates.ZWG);
            dtCurrency.Rows.Add("ZWL", val.rates.ZWL);


            cmbFromCurrency.ItemsSource = dtCurrency.DefaultView;
            cmbFromCurrency.DisplayMemberPath = "Text";
            cmbFromCurrency.SelectedValuePath = "Value";
            cmbFromCurrency.SelectedIndex = 0;
            
            cmbToCurrency.ItemsSource = dtCurrency.DefaultView;
            cmbToCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.SelectedValuePath = "Value";
            cmbToCurrency.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the Convert button click event, validates input, and performs currency conversion.
        /// </summary>
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double ConvertedValue;
            // Check if the ammount textbox is Null or Blank
            if (txtCurrency.Text == null || txtCurrency.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the amount to convert.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtCurrency.Focus();
                return;
            }
            else if (cmbFromCurrency.SelectedValue == null || cmbFromCurrency.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a currency to convert from.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                cmbFromCurrency.Focus();
                return;
            }
            else if (cmbToCurrency.SelectedValue == null || cmbToCurrency.SelectedIndex == 0) 
            { 
                MessageBox.Show("Please select a currency to convert to.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                cmbToCurrency.Focus();
                return;
            }

            // If converting to the same currency, just display the entered amount
            if (cmbFromCurrency.Text == cmbToCurrency.Text)
            {
                ConvertedValue = double.Parse(txtCurrency.Text);
                lblCurrency.Content = cmbToCurrency.Text + " " + ConvertedValue.ToString("N3");
            }
            else 
            {
                // Calculate converted value using selected rates
                ConvertedValue = (double.Parse(cmbToCurrency.SelectedValue.ToString()) * double.Parse(txtCurrency.Text)) / double.Parse(cmbFromCurrency.SelectedValue.ToString());
                lblCurrency.Content = cmbToCurrency.Text + " " + ConvertedValue.ToString("N3");
            }
        }

        /// <summary>
        /// Handles the Clear button click event, resets all input fields and labels.
        /// </summary>
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            lblCurrency.Content = "";
            txtCurrency.Text = "";
            cmbFromCurrency.Text = "--SELECT--";
            cmbToCurrency.Text = "--SELECT--";
        }

        /// <summary>
        /// Validates that only numeric input is allowed in the amount textbox.
        /// </summary>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9.]+$");
            TextBox textBox = sender as TextBox;

            // If input is not a digit or dot, block it
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
                return;
            }

            // Predict the new text after input
            string newText = textBox.Text.Insert(textBox.SelectionStart, e.Text);

            // Remove minus and dot for digit count
            string digitsOnly = newText.Replace("-", "").Replace(".", "");

            // Accept only up to 10 digits
            if (digitsOnly.Length > 10)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles changes to the amount textbox. (Currently empty)
        /// </summary>
        private void TxtCurrency_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        /// <summary>
        /// Adjusts UI layout and control properties when the window size changes.
        /// </summary>
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // If window width is less than 820, switch to vertical layout
            if (ActualWidth < 820)
            {
                inputBoxes.Orientation = Orientation.Vertical;
                txtCurrency.Margin = new Thickness(40, 0, 0, 20);
                cmbFromCurrency.Margin = new Thickness(60, 38, 0, 20);
                cmbFromCurrency.Width = 190;
                iconExchange.Margin = new Thickness(0, 0, 0, 20);
                iconExchange.HorizontalAlignment = HorizontalAlignment.Center;
                cmbToCurrency.Margin = new Thickness(60, 0, 0, 20);
                cmbToCurrency.Width = 190;
                mainBorder.Width = 300;
                inputBoxes.Height = 250;
                inputBoxes.Width = 300; 
                gridBorder.Height = new GridLength(300);
                borderLabels.Orientation = Orientation.Vertical;
                borderLabels.Width = 300;
                borderLabels.Height = 250;
                // Set alignment and margin for each child in borderLabels
                foreach (var child in borderLabels.Children)
                {
                    if (child is FrameworkElement fe)
                    {
                        fe.HorizontalAlignment = HorizontalAlignment.Left;
                        fe.Margin = new Thickness(0, 0, 0, 0);
                    }
                }
                fromCurrencySelection.Margin = new Thickness(20, 60, 0, 0);
                toCurrencySelection.Margin = new Thickness(20, 65, 0, 0);
                txtCurrency.Width = 250;
                txtCurrency.HorizontalAlignment = HorizontalAlignment.Center;
                txtCurrency.Margin = new Thickness(0, 0, 0, 0);
                ammountInput.Margin = new Thickness(20, 10, 0, 0);
            }
            // Otherwise, use horizontal layout and restore default properties
            else
            {
                // ToDo : Get the initial properties from XAML when the window is first loaded and apply them here
                inputBoxes.Orientation = Orientation.Horizontal;
                inputBoxes.HorizontalAlignment = HorizontalAlignment.Center;
                inputBoxes.VerticalAlignment = VerticalAlignment.Bottom;
                inputBoxes.Height = 90;
                inputBoxes.Width = 800;

                txtCurrency.Width = 200;
                txtCurrency.Height = 30;
                txtCurrency.Margin = new Thickness(40, 0, 0, 0);
                txtCurrency.FontSize = 18;
                txtCurrency.VerticalContentAlignment = VerticalAlignment.Center;
                txtCurrency.VerticalAlignment = VerticalAlignment.Top;

                cmbFromCurrency.Width = 170;
                cmbFromCurrency.Height = 30;
                cmbFromCurrency.Margin = new Thickness(60, 0, 40, 0);
                cmbFromCurrency.FontSize = 18;
                cmbFromCurrency.VerticalContentAlignment = VerticalAlignment.Center;
                cmbFromCurrency.VerticalAlignment = VerticalAlignment.Top;
                cmbFromCurrency.MaxDropDownHeight = 150;

                iconExchange.Height = 30;
                iconExchange.Width = 30;
                iconExchange.VerticalAlignment = VerticalAlignment.Top;
                iconExchange.Foreground = Brushes.White;

                cmbToCurrency.Width = 170;
                cmbToCurrency.Height = 30;
                cmbToCurrency.Margin = new Thickness(40, 0, 0, 0);
                cmbToCurrency.FontSize = 18;
                cmbToCurrency.VerticalContentAlignment = VerticalAlignment.Center;
                cmbToCurrency.VerticalAlignment = VerticalAlignment.Top;
                cmbToCurrency.MaxDropDownHeight = 150;

                mainBorder.Width = 800;
                gridBorder.Height = new GridLength(150);

                borderLabels.Orientation = Orientation.Horizontal;
                borderLabels.HorizontalAlignment = HorizontalAlignment.Center;
                borderLabels.VerticalAlignment = VerticalAlignment.Top;
                borderLabels.Height = 60;
                borderLabels.Width = 800;

                ammountInput.Height = 40;
                ammountInput.Width = 150;
                ammountInput.Margin = new Thickness(35, 0, 0, 0);
                ammountInput.VerticalAlignment = VerticalAlignment.Bottom;
                ammountInput.Foreground = Brushes.White;
                ammountInput.FontSize = 20;
                ammountInput.Content = "Enter Amount : ";

                fromCurrencySelection.Height = 40;
                fromCurrencySelection.Width = 150;
                fromCurrencySelection.Margin = new Thickness(110, 0, 0, 0);
                fromCurrencySelection.VerticalAlignment = VerticalAlignment.Bottom;
                fromCurrencySelection.Foreground = Brushes.White;
                fromCurrencySelection.FontSize = 20;
                fromCurrencySelection.Content = "From : ";

                toCurrencySelection.Height = 40;
                toCurrencySelection.Width = 150;
                toCurrencySelection.Margin = new Thickness(130, 0, 0, 0);
                toCurrencySelection.VerticalAlignment = VerticalAlignment.Bottom;
                toCurrencySelection.Foreground = Brushes.White;
                toCurrencySelection.FontSize = 20;
                toCurrencySelection.Content = "To : ";
            }
        }

        /// <summary>
        /// Handles key events for the amount textbox, triggers conversion on Enter and clears on Escape.
        /// </summary>
        private void TxtCurrencyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Convert.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            if (e.Key == Key.Escape)
                txtCurrency.Text = ""; // Clear the text box on Escape key press
        }
    }
}