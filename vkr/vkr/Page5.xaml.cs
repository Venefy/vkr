using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
    /// Interaction logic for Page5.xaml
    /// </summary>
    /// 
    
    public partial class Page5 : Page
    {
        public Data d = new Data();
        public Page5( Data data)
        {
            InitializeComponent();
            d = data;
            CalcMNK2();
            CalcMNK3();
            CalcMNK4();

        }

        public void CalcMNK2()
        {
            decimal a1 = 0;
            decimal b1 = 0;
            decimal c1 = 0;
            decimal d1 = 0;
            decimal a2 = 0;
            decimal b2 = 0;
            decimal c2 = 0;
            decimal d2 = 0;
            decimal a3 = 0;
            decimal b3 = 0;
            decimal c3 = 0;
            decimal d3 = 0;

            decimal[] abc = new decimal[4];
            for (int i = 0; i < d.Xp.Length; i++)
            {


                a1 += (d.Xp[i] * d.Xp[i]);
                b1 += (d.Xp[i] * d.Yp[i]);
                c1 += (d.Xp[i]);
                d1 += (d.Xp[i] * d.Zp[i]);
                a2 = b1;
                b2 += (d.Yp[i] * d.Yp[i]);
                c2 += (d.Yp[i]);
                d2 += (d.Yp[i] * d.Zp[i]);
                a3 = c1;
                b3 = c2;
                c3 += 1;
                d3 += (d.Zp[i]);


            }

            decimal k12 = (-1 * a2 / a1);
            decimal k13 = (-1 * a3 / a1);
            decimal k23 = (-1 * (b3 + k13 * b1) / (b2 + k12 * b1));
            abc[3] =  ((d3 + k13 * d1) + k23 * (d2 + k12 * d1)) / ((c3 + k13 * c1) + k23 * (c2 + k12 * c1));
            abc[2] = -1;
            abc[1] =  (d2 + k12 * d1 - (c2 + k12 * c1) * abc[3]) / (b2 + k12 * b1);
            abc[0] =  (d1 - b1 * abc[1] - c1 * abc[3]) / a1;
            string mnk1 = "";
            
             mnk1 += "\n2)\t Коэффициенты, описывающие плоскость (Π12), которая удовлетворяет распределению точек поверхностей 1 и 2 наилучшим образом. \na:" + abc[0].ToString() + "\n b: " + abc[1].ToString() + "\n c: " + abc[2].ToString() +"\t d: " + abc[3].ToString();

            MNK.Text += mnk1;
            decimal[] Lp = new decimal[d.Xp.Length];
            for (int i = 0; i < d.Xp.Length; i++)
            {
                Lp[i] = Math.Abs((abc[0] * d.Xp[i] + abc[1] * d.Yp[i] + abc[2] * d.Zp[i] + abc[3]) / (decimal)(Math.Sqrt((double)(abc[0] * abc[0] + abc[1] * abc[1] + abc[2] * abc[2]))));
            }
            string mnk2 = "\n Cреднее расстояние от точек поверхности 1 и поверхности 2 до плоскости: " + Lp.Average().ToString() + "\n Максимальное: " + Lp.Max().ToString() + "\n Минимальное: " + Lp.Min().ToString();
            MNK.Text += mnk2;
            
        }

        public void CalcMNK3()
        {
            decimal a1 = 0;
            decimal b1 = 0;
            decimal c1 = 0;
            decimal d1 = 0;
            decimal a2 = 0;
            decimal b2 = 0;
            decimal c2 = 0;
            decimal d2 = 0;
            decimal a3 = 0;
            decimal b3 = 0;
            decimal c3 = 0;
            decimal d3 = 0;

            decimal[] abc = new decimal[4];
            for (int i = 0; i < d.Xp1.Length; i++)
            {


                a1 += (d.Xp1[i] * d.Xp1[i]);
                b1 += (d.Xp1[i] * d.Yp1[i]);
                c1 += (d.Xp1[i]);
                d1 += (d.Xp1[i] * d.Zp1[i]);
                a2 = b1;
                b2 += (d.Yp1[i] * d.Yp1[i]);
                c2 += (d.Yp1[i]);
                d2 += (d.Yp1[i] * d.Zp1[i]);
                a3 = c1;
                b3 = c2;
                c3 += 1;
                d3 += (d.Zp1[i]);


            }

            decimal k12 = (-1 * a2 / a1);
            decimal k13 = (-1 * a3 / a1);
            decimal k23 = (-1 * (b3 + k13 * b1) / (b2 + k12 * b1));
            abc[3] = ((d3 + k13 * d1) + k23 * (d2 + k12 * d1)) / ((c3 + k13 * c1) + k23 * (c2 + k12 * c1));
            abc[2] = -1;
            abc[1] = (d2 + k12 * d1 - (c2 + k12 * c1) * abc[3]) / (b2 + k12 * b1);
            abc[0] = (d1 - b1 * abc[1] - c1 * abc[3]) / a1;
            string mnk1 = "";

            mnk1 += "\n\n3)\t Коэффициенты, описывающие плоскость (Π1), которая удовлетворяет распределению точек поверхности 1 наилучшим образом. \na:" + abc[0].ToString() + "\n b: " + abc[1].ToString() + "\n c: " + abc[2].ToString() + "\n d: " + abc[3].ToString();

            MNK.Text += mnk1;
            decimal[] Lp1 = new decimal[d.Xp1.Length];
            for (int i = 0; i < d.Xp1.Length; i++)
            {
                Lp1[i] = Math.Abs((abc[0] * d.Xp1[i] + abc[1] * d.Yp1[i] + abc[2] * d.Zp1[i] + abc[3]) / (decimal)(Math.Sqrt((double)(abc[0] * abc[0] + abc[1] * abc[1] + abc[2] * abc[2]))));
            }
            string mnk2 = "\n Cреднее расстояние от точек поверхности 1 до плоскости: " + Lp1.Average().ToString() + "\n Максимальное: " + Lp1.Max().ToString() + "\n Минимальное: " + Lp1.Min().ToString();
            MNK.Text += mnk2;
            LoadColumnChartData(Lp1, Chart1);
        }

        public void CalcMNK4()
        {
            decimal a1 = 0;
            decimal b1 = 0;
            decimal c1 = 0;
            decimal d1 = 0;
            decimal a2 = 0;
            decimal b2 = 0;
            decimal c2 = 0;
            decimal d2 = 0;
            decimal a3 = 0;
            decimal b3 = 0;
            decimal c3 = 0;
            decimal d3 = 0;

            decimal[] abc = new decimal[4];
            for (int i = 0; i < d.Xp2.Length; i++)
            {


                a1 += (d.Xp2[i] * d.Xp2[i]);
                b1 += (d.Xp2[i] * d.Yp2[i]);
                c1 += (d.Xp2[i]);
                d1 += (d.Xp2[i] * d.Zp2[i]);
                a2 = b1;
                b2 += (d.Yp2[i] * d.Yp2[i]);
                c2 += (d.Yp2[i]);
                d2 += (d.Yp2[i] * d.Zp2[i]);
                a3 = c1;
                b3 = c2;
                c3 += 1;
                d3 += (d.Zp2[i]);


            }

            decimal k12 = (-1 * a2 / a1);
            decimal k13 = (-1 * a3 / a1);
            decimal k23 = (-1 * (b3 + k13 * b1) / (b2 + k12 * b1));
            abc[3] = ((d3 + k13 * d1) + k23 * (d2 + k12 * d1)) / ((c3 + k13 * c1) + k23 * (c2 + k12 * c1));
            abc[2] = -1;
            abc[1] = (d2 + k12 * d1 - (c2 + k12 * c1) * abc[3]) / (b2 + k12 * b1);
            abc[0] = (d1 - b1 * abc[1] - c1 * abc[3]) / a1;
            string mnk1 = "";

            mnk1 += "\n\n4)\t Коэффициенты, описывающие плоскость (Π2), которая удовлетворяет распределению точек поверхности 2 наилучшим образом. \na:" + abc[0].ToString() + "\n b: " + abc[1].ToString() + "\n c: " + abc[2].ToString() + "\n d: " + abc[3].ToString();

            MNK.Text += mnk1;
            decimal[] Lp2 = new decimal[d.Xp2.Length];
            for (int i = 0; i < d.Xp2.Length; i++)
            {
                Lp2[i] = Math.Abs((abc[0] * d.Xp2[i] + abc[1] * d.Yp2[i] + abc[2] * d.Zp2[i] + abc[3]) / (decimal)(Math.Sqrt((double)(abc[0] * abc[0] + abc[1] * abc[1] + abc[2] * abc[2]))));
            }
            string mnk2 = "\n Cреднее расстояние от точек поверхности 2 до плоскости: " + Lp2.Average().ToString() + "\n Максимальное: " + Lp2.Max().ToString() + "\n Минимальное: " + Lp2.Min().ToString();
            MNK.Text += mnk2;

            LoadColumnChartData(Lp2, Chart2);
            

        }


        private void LoadColumnChartData(decimal[] lp, Chart chart)
        {
            decimal max = lp.Max();
            decimal min = lp.Min();
            decimal a = min + ((max-min)/(decimal)3);
            decimal b = max - ((max-min)/(decimal)3);
            
            int a1=0;
            int a2=0;
            int a3=0;
             
            for (int i = 0; i<lp.Length;i++)
            {
                if (lp[i] < a) a1++;
                else
                {
                    if (lp[i] < b) a2++;
                    else a3++;
                }
            }
            ////add data to charts
            ((ColumnSeries)chart.Series[0]).ItemsSource = new KeyValuePair<decimal, int>[] {

            new KeyValuePair < decimal, int > (Math.Round(min, 4), a1),
            new KeyValuePair<decimal, int>(Math.Round(lp.Average(), 4), a2),
            new KeyValuePair<decimal, int>(Math.Round(max,4), a3)};
            
        }
        
    }
}
