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
        public Data d = new Data();
        
        public Page2(Data data)
        {
            InitializeComponent();
            d = data;
            d.Dop= double.Parse(Dop.Text, CultureInfo.InvariantCulture);
            d.S1 = double.Parse(S1.Text, CultureInfo.InvariantCulture);
            d.S2 = double.Parse(S2.Text, CultureInfo.InvariantCulture);
            d.Ks1 = double.Parse(Ks1.Text, CultureInfo.InvariantCulture);
            d.Ks2 = double.Parse(Ks2.Text, CultureInfo.InvariantCulture);
            d.Lopt = double.Parse(Lopt.Text, CultureInfo.InvariantCulture);
            d.MY3 = double.Parse(MY3.Text, CultureInfo.InvariantCulture);
            d.MY4 = double.Parse(MY4.Text, CultureInfo.InvariantCulture);
            d.Sp1 = double.Parse(Sp1.Text, CultureInfo.InvariantCulture);
            d.Lp1 = double.Parse(Lp1.Text, CultureInfo.InvariantCulture);
            d.Xaa = double.Parse(Xaa.Text, CultureInfo.InvariantCulture);
            d.Yaa = double.Parse(Yaa.Text, CultureInfo.InvariantCulture);
            d.Xbb = double.Parse(Xbb.Text, CultureInfo.InvariantCulture);
            d.Ybb = double.Parse(Ybb.Text, CultureInfo.InvariantCulture);

        }
        

        private void Dop_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                {
                    d.Dop = double.Parse(Dop.Text, CultureInfo.InvariantCulture);
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
                    d.S1 = double.Parse(S1.Text, CultureInfo.InvariantCulture);
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
                    d.S2 = double.Parse(S2.Text, CultureInfo.InvariantCulture);
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
                    d.Ks1 = double.Parse(Ks1.Text, CultureInfo.InvariantCulture);
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
                    d.Ks2 = double.Parse(Ks2.Text, CultureInfo.InvariantCulture);
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
                    d.Lopt = double.Parse(Lopt.Text, CultureInfo.InvariantCulture);
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
                    d.MY3 = double.Parse(MY3.Text, CultureInfo.InvariantCulture);
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
                    d.MY4 = double.Parse(MY4.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }

                MY4.Foreground = Brushes.Black;
                MY4.FontWeight = FontWeights.Bold;
            }
        }

        private void Sp1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try { 

                    d.Sp1 = double.Parse(Sp1.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                Sp1.Foreground = Brushes.Black;
                Sp1.FontWeight = FontWeights.Bold;
            }
        }

        private void Lp1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded && Dop.Text.ToString() != "")
            {
                try
                { 
                    d.Lp1 = double.Parse(Lp1.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Неверный формат ввода");
                }
                Lp1.Foreground = Brushes.Black;
                Lp1.FontWeight = FontWeights.Bold;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page5 p3 = new Page5(d);
           

            this.NavigationService.Navigate(p3);
        }
    }
}
