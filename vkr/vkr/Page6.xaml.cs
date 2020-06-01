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
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Data d = new Data();
        public Page6(Data data)
        {
            InitializeComponent();
            image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "111.png", UriKind.Absolute));
            image1.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "222.png", UriKind.Absolute));

            d = data;
            Final();
        }
        public void Final()
        {
            d.ha = new double[4];
            d.hb = new double[4];
            d.ha[0] = (d.Lopt + d.S1 * d.Ks1 + d.S2 * d.Ks2) + 
                ((d.Ap1[0] * (d.Xaa - d.Sp1 / 2) + d.Ap1[1] * (-1 * d.Lp1 / 2 + d.MY1) + d.Ap1[3]) / (d.Ap1[2])) - 
                ((d.AMM[0] * (d.Xaa - d.Sp1 / 2) + d.AMM[1] * (-1 * d.Lp1 / 2 + d.MY1) + d.AMM[3] + d.Ksmini[0]) / (d.AMM[2]));

            d.ha[1] = (d.Lopt + d.S1 * d.Ks1 + d.S2 * d.Ks2) +
                ((d.Ap1[0] * (d.Xaa - d.Sp1 / 2) + d.Ap1[1] * ( d.Lp1 / 2 + d.MY1) + d.Ap1[3]) / (d.Ap1[2])) -
                ((d.AMM[0] * (d.Xaa - d.Sp1 / 2) + d.AMM[1] * ( d.Lp1 / 2 + d.MY1) + d.AMM[3] + d.Ksmini[0]) / (d.AMM[2]));

            d.ha[2] = (d.Lopt + d.S1 * d.Ks1 + d.S2 * d.Ks2) +
                ((d.Ap1[0] * (d.Xaa + d.Sp1 / 2) + d.Ap1[1] * (-1 * d.Lp1 / 2 + d.MY1) + d.Ap1[3]) / (d.Ap1[2])) -
                ((d.AMM[0] * (d.Xaa + d.Sp1 / 2) + d.AMM[1] * (-1 * d.Lp1 / 2 + d.MY1) + d.AMM[3] + d.Ksmini[0]) / (d.AMM[2]));

            d.ha[3] = (d.Lopt + d.S1 * d.Ks1 + d.S2 * d.Ks2) +
                ((d.Ap1[0] * (d.Xaa + d.Sp1 / 2) + d.Ap1[1] * (d.Lp1 / 2 + d.MY1) + d.Ap1[3]) / (d.Ap1[2])) -
                ((d.AMM[0] * (d.Xaa + d.Sp1 / 2) + d.AMM[1] * (d.Lp1 / 2 + d.MY1) + d.AMM[3] + d.Ksmini[0]) / (d.AMM[2]));



            d.hb[0] = (d.Lopt + d.S1 * d.Ks1 + d.S2 * d.Ks2) +
                 ((d.Ap2[0] * (d.Xbb - d.Sp1 / 2) + d.Ap2[1] * (-1 * d.Lp1 / 2 + d.MY1) + d.Ap2[3]) / (d.Ap2[2])) -
                 ((d.AMM[0] * (d.Xbb - d.Sp1 / 2) + d.AMM[1] * (-1 * d.Lp1 / 2 + d.MY1) + d.AMM[3] + d.Ksmini[0]) / (d.AMM[2]));

            d.hb[1] = (d.Lopt + d.S1 * d.Ks1 + d.S2 * d.Ks2) +
                ((d.Ap2[0] * (d.Xbb - d.Sp1 / 2) + d.Ap2[1] * (d.Lp1 / 2 + d.MY1) + d.Ap2[3]) / (d.Ap2[2])) -
                ((d.AMM[0] * (d.Xbb - d.Sp1 / 2) + d.AMM[1] * (d.Lp1 / 2 + d.MY1) + d.AMM[3] + d.Ksmini[0]) / (d.AMM[2]));

            d.hb[2] = (d.Lopt + d.S1 * d.Ks1 + d.S2 * d.Ks2) +
                ((d.Ap2[0] * (d.Xbb + d.Sp1 / 2) + d.Ap2[1] * (-1 * d.Lp1 / 2 + d.MY1) + d.Ap2[3]) / (d.Ap2[2])) -
                ((d.AMM[0] * (d.Xbb + d.Sp1 / 2) + d.AMM[1] * (-1 * d.Lp1 / 2 + d.MY1) + d.AMM[3] + d.Ksmini[0]) / (d.AMM[2]));

            d.hb[3] = (d.Lopt + d.S1 * d.Ks1 + d.S2 * d.Ks2) +
                ((d.Ap2[0] * (d.Xbb + d.Sp1 / 2) + d.Ap2[1] * (d.Lp1 / 2 + d.MY1) + d.Ap2[3]) / (d.Ap2[2])) -
                ((d.AMM[0] * (d.Xbb + d.Sp1 / 2) + d.AMM[1] * (d.Lp1 / 2 + d.MY1) + d.AMM[3] + d.Ksmini[0]) / (d.AMM[2]));

            string mnk1 = "";
            mnk1 = "\n Высоты юстировочных планок c круглым отверстием";
            Text.Text += mnk1;
            for (int i = 0; i < 4; i++)
            {
                mnk1 = "\nha" + (i+1).ToString()+":\t" + d.ha[i].ToString();
                Text.Text += mnk1;
            }
            mnk1 = "\n Высоты юстировочных планок c овальным отверстием";
            Text1.Text += mnk1;
            for (int i = 0; i < 4; i++)
            {
                mnk1 = "\nhb" + (i + 1).ToString() + ":\t" + d.hb[i].ToString();
                Text1.Text += mnk1;
            }

        }
    }
}
