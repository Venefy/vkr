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

namespace vkr
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
    

        private void Dop_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                Dop.Foreground = Brushes.Black;
                Dop.FontWeight = FontWeights.Bold;
            }
        }

        private void S1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                S1.Foreground = Brushes.Black;
                S1.FontWeight = FontWeights.Bold;
            }
        }

        private void S2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                S2.Foreground = Brushes.Black;
                S2.FontWeight = FontWeights.Bold;
            }
        }

        private void Ks1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                Ks1.Foreground = Brushes.Black;
                Ks1.FontWeight = FontWeights.Bold;
            }
        }

        private void Ks2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                Ks2.Foreground = Brushes.Black;
                Ks2.FontWeight = FontWeights.Bold;
            }
        }

        private void Lopt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                Lopt.Foreground = Brushes.Black;
                Lopt.FontWeight = FontWeights.Bold;
            }
        }

        private void MY3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                MY3.Foreground = Brushes.Black;
                MY3.FontWeight = FontWeights.Bold;
            }
        }

        private void MY4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                MY4.Foreground = Brushes.Black;
                MY4.FontWeight = FontWeights.Bold;
            }
        }

        private void Spl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                Spl.Foreground = Brushes.Black;
                Spl.FontWeight = FontWeights.Bold;
            }
        }

        private void Lpl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                Lpl.Foreground = Brushes.Black;
                Lpl.FontWeight = FontWeights.Bold;
            }
        }
    }
}
