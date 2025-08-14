using System.Data;
using System.Net.Security;
using System.Text;
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
        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();
            txtCurrency.Focus();
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
            dtCurrency.Rows.Add("EUR", "1");
            dtCurrency.Rows.Add("USD", "1.16");
            dtCurrency.Rows.Add("GBP", "0.86");
            dtCurrency.Rows.Add("INR", "102.09");
            dtCurrency.Rows.Add("JPY", "172.08");
            dtCurrency.Rows.Add("AUD", "1.79");
            dtCurrency.Rows.Add("CAD", "1.61");
            dtCurrency.Rows.Add("CNY", "8.36");
            dtCurrency.Rows.Add("RUB", "92.84");
            dtCurrency.Rows.Add("ZAR", "20.56");
            dtCurrency.Rows.Add("BRL", "6.31");
            dtCurrency.Rows.Add("MXN", "21.92");
            dtCurrency.Rows.Add("KRW", "1619.17");
            dtCurrency.Rows.Add("SGD", "1.50");
            dtCurrency.Rows.Add("NZD", "1.97");
            dtCurrency.Rows.Add("HKD", "9.12");
            dtCurrency.Rows.Add("SEK", "11.18");
            dtCurrency.Rows.Add("NOK", "11.91");
            dtCurrency.Rows.Add("DKK", "7.46");
            dtCurrency.Rows.Add("PLN", "4.26");
            dtCurrency.Rows.Add("CHF", "0.94");
            dtCurrency.Rows.Add("TRY", "47.59");
            dtCurrency.Rows.Add("PHP", "66.42");

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