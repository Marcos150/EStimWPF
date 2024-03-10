using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace EStimWPF
{
    [ValueConversion(typeof(double), typeof(string))]
    public class ConvertidorMoneda : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        { 
            //Codigo para el formateado adaptado de https://stackoverflow.com/questions/6924067/how-to-get-specific-culture-currency-pattern
            var numberFormat = culture.NumberFormat;
            string pattern = "";
            switch (numberFormat.CurrencyPositivePattern) 
            {
                case 0:
                    pattern = "{0}{1:N" + numberFormat.CurrencyDecimalDigits + "}";
                    break;
                case 1:
                    pattern = "{1:N" + numberFormat.CurrencyDecimalDigits + "}{0}";
                    break;
                case 2:
                    pattern = "{0} {1:N" + numberFormat.CurrencyDecimalDigits + "}";
                    break;
                case 3:
                    pattern = "{1:N" + numberFormat.CurrencyDecimalDigits + "} {0}";
                    break;
            }
            string formattedAmount = string.Format(culture, pattern, numberFormat.CurrencySymbol, value);

            return formattedAmount;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return double.Parse(value.ToString()!, NumberStyles.Currency, culture);
            }
            catch
            {
                MessageBox.Show("El valor introducido no es válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return value;
            }
        }
    }
}
