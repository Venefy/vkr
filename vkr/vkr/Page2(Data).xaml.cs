using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace vkr
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Data d2 = new Data();
        
        public Page2(Data data)
        {
            InitializeComponent();
            d2 = data;
            d2.Dop= Convert.ToDouble(Dop.Text, CultureInfo.InvariantCulture);
            d2.S1 = double.Parse(S1.Text, CultureInfo.InvariantCulture);
            d2.S2 = double.Parse(S2.Text, CultureInfo.InvariantCulture);
            d2.Ks1 = double.Parse(Ks1.Text, CultureInfo.InvariantCulture);
            d2.Ks2 = double.Parse(Ks2.Text, CultureInfo.InvariantCulture);
            d2.Lopt = double.Parse(Lopt.Text, CultureInfo.InvariantCulture);
            d2.MY3 = double.Parse(MY3.Text, CultureInfo.InvariantCulture);
            d2.MY4 = double.Parse(MY4.Text, CultureInfo.InvariantCulture);
            d2.Spl = double.Parse(Spl.Text, CultureInfo.InvariantCulture);
            d2.Lpl = double.Parse(Lpl.Text, CultureInfo.InvariantCulture);
           

        }
        

        private void Dop_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                {
                    d2.Dop = Convert.ToDouble(Dop.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                Dop.Foreground = Brushes.Black;
                Dop.FontWeight = FontWeights.Bold;
                
            }
        }

        private void S1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                {
                    d2.S1 = double.Parse(S1.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                S1.Foreground = Brushes.Black;
                S1.FontWeight = FontWeights.Bold;
           
            }
        }

        private void S2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                {
                    d2.S2 = double.Parse(S2.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                S2.Foreground = Brushes.Black;
                S2.FontWeight = FontWeights.Bold;
            }
        }

        private void Ks1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                {
                    d2.Ks1 = double.Parse(Ks1.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                Ks1.Foreground = Brushes.Black;
                Ks1.FontWeight = FontWeights.Bold;
            }
        }

        private void Ks2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                {
                    d2.Ks2 = double.Parse(Ks2.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                Ks2.Foreground = Brushes.Black;
                Ks2.FontWeight = FontWeights.Bold;
            }
        }

        private void Lopt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                {
                    d2.Lopt = double.Parse(Lopt.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                Lopt.Foreground = Brushes.Black;
                Lopt.FontWeight = FontWeights.Bold;
            }
        }

        private void MY3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                { 
                    d2.MY3 = double.Parse(MY3.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                MY3.Foreground = Brushes.Black;
                MY3.FontWeight = FontWeights.Bold;
            }
        }

        private void MY4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try { 
                    d2.MY4 = double.Parse(MY4.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }

                MY4.Foreground = Brushes.Black;
                MY4.FontWeight = FontWeights.Bold;
            }
        }

        private void Spl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try { 

                    d2.Spl = double.Parse(Spl.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                Spl.Foreground = Brushes.Black;
                Spl.FontWeight = FontWeights.Bold;
            }
        }

        private void Lpl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                { 
                    d2.Lpl = double.Parse(Lpl.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                Lpl.Foreground = Brushes.Black;
                Lpl.FontWeight = FontWeights.Bold;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3(d2);
           

            this.NavigationService.Navigate(p3);
        }
    }
}
