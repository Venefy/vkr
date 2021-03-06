﻿using System;

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
        public Page5(Data data)
        {
            InitializeComponent();
            d = data;

            CalcMNK2();
            CalcMNK3();
            CalcMNK4();
            CalcMNK5();
            CalcMNK6butnot6();
            CalcMNK9();
        }
        private void Slide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LoadLine(0, d.XX, d.ZZ, line3, false);
            double[] Pro = new double[d.X.Length / 2];
            double[] Pro_d = new double[d.X.Length / 2];
            double[] Pro_dd = new double[d.X.Length / 2];
            for (int i = 0; i < d.X.Length / 2; i++)
            {
                Pro[i] = -1 * (d.AMM[0] * d.XX[i] + d.AMM[1] * d.MY1 + d.AMM[3] + slValue.Value) / d.AMM[2];
                Pro_d[i] = Pro[i] + d.Dop;
                Pro_dd[i] = Pro[i] - d.Dop;

            }
            d.Ksmini[0] = slValue.Value;
            LoadLine(1, d.XX, Pro, line3, true);
            LoadLine(2, d.XX, Pro_d, line3, true);
            LoadLine(3, d.XX, Pro_dd, line3, true);
        }

        public void CalcMNK2()
        {
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            double d1 = 0;
            double a2 = 0;
            double b2 = 0;
            double c2 = 0;
            double d2 = 0;
            double a3 = 0;
            double b3 = 0;
            double c3 = 0;
            double d3 = 0;

            double[] abc = new double[4];
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

            double k12 = (-1 * a2 / a1);
            double k13 = (-1 * a3 / a1);
            double k23 = (-1 * (b3 + k13 * b1) / (b2 + k12 * b1));
            abc[3] = ((d3 + k13 * d1) + k23 * (d2 + k12 * d1)) / ((c3 + k13 * c1) + k23 * (c2 + k12 * c1));
            abc[2] = -1;
            abc[1] = (d2 + k12 * d1 - (c2 + k12 * c1) * abc[3]) / (b2 + k12 * b1);
            abc[0] = (d1 - b1 * abc[1] - c1 * abc[3]) / a1;
            d.Ap = new double[4];
            d.Ap[0] = abc[0];
            d.Ap[1] = abc[1];
            d.Ap[2] = abc[2];
            d.Ap[3] = abc[3];
            string mnk1 = "";

            mnk1 += "\n2)\t Коэффициенты, описывающие плоскость (Π12), которая удовлетворяет распределению точек поверхностей 1 и 2 наилучшим образом. \na:" + abc[0].ToString() + "\n b: " + abc[1].ToString() + "\n c: " + abc[2].ToString() + "\t d: " + abc[3].ToString();

            MNK.Text += mnk1;
            double[] Lp = new double[d.Xp.Length];
            for (int i = 0; i < d.Xp.Length; i++)
            {
                Lp[i] = Math.Abs((abc[0] * d.Xp[i] + abc[1] * d.Yp[i] + abc[2] * d.Zp[i] + abc[3]) / (double)(Math.Sqrt((double)(abc[0] * abc[0] + abc[1] * abc[1] + abc[2] * abc[2]))));
            }
            string mnk2 = "\n Cреднее расстояние от точек поверхности 1 и поверхности 2 до плоскости: " + Lp.Average().ToString() + "\n Максимальное: " + Lp.Max().ToString() + "\n Минимальное: " + Lp.Min().ToString();
            MNK.Text += mnk2;

        }

        public void CalcMNK3()
        {
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            double d1 = 0;
            double a2 = 0;
            double b2 = 0;
            double c2 = 0;
            double d2 = 0;
            double a3 = 0;
            double b3 = 0;
            double c3 = 0;
            double d3 = 0;

            double[] abc = new double[4];
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

            double k12 = (-1 * a2 / a1);
            double k13 = (-1 * a3 / a1);
            double k23 = (-1 * (b3 + k13 * b1) / (b2 + k12 * b1));
            abc[3] = ((d3 + k13 * d1) + k23 * (d2 + k12 * d1)) / ((c3 + k13 * c1) + k23 * (c2 + k12 * c1));
            abc[2] = -1;
            abc[1] = (d2 + k12 * d1 - (c2 + k12 * c1) * abc[3]) / (b2 + k12 * b1);
            abc[0] = (d1 - b1 * abc[1] - c1 * abc[3]) / a1;
            d.Ap1 = new double[4];
            d.Ap1[0] = abc[0];
            d.Ap1[1] = abc[1];
            d.Ap1[2] = abc[2];
            d.Ap1[3] = abc[3];
            string mnk1 = "";

            mnk1 += "\n\n3)\t Коэффициенты, описывающие плоскость (Π1), которая удовлетворяет распределению точек поверхности 1 наилучшим образом. \na:" + abc[0].ToString() + "\n b: " + abc[1].ToString() + "\n c: " + abc[2].ToString() + "\n d: " + abc[3].ToString();

            MNK.Text += mnk1;
            double[] Lp1 = new double[d.Xp1.Length];
            for (int i = 0; i < d.Xp1.Length; i++)
            {
                Lp1[i] = Math.Abs((abc[0] * d.Xp1[i] + abc[1] * d.Yp1[i] + abc[2] * d.Zp1[i] + abc[3]) / (double)(Math.Sqrt((double)(abc[0] * abc[0] + abc[1] * abc[1] + abc[2] * abc[2]))));
            }
            mnk1 = "\n Cреднее расстояние от точек поверхности 1 до плоскости: " + Lp1.Average().ToString() + "\n Максимальное: " + Lp1.Max().ToString() + "\n Минимальное: " + Lp1.Min().ToString();
            MNK.Text += mnk1;
            double ug = Math.Atan(-1 * abc[0] / abc[2]) * 180 * 3600 / Math.PI;
            double ug1 = Math.Atan(-1 * abc[1] / abc[2]) * 180 * 3600 / Math.PI;
            mnk1 = "\nУгол наклона плоскости 1 относительно системы координат в угловых секундах: \n Uoxz1=" + ug.ToString() + "\t Uoyz1=" + ug1.ToString();
            MNK.Text += mnk1;
        }

        public void CalcMNK4()
        {
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            double d1 = 0;
            double a2 = 0;
            double b2 = 0;
            double c2 = 0;
            double d2 = 0;
            double a3 = 0;
            double b3 = 0;
            double c3 = 0;
            double d3 = 0;

            double[] abc = new double[4];
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

            double k12 = (-1 * a2 / a1);
            double k13 = (-1 * a3 / a1);
            double k23 = (-1 * (b3 + k13 * b1) / (b2 + k12 * b1));
            abc[3] = ((d3 + k13 * d1) + k23 * (d2 + k12 * d1)) / ((c3 + k13 * c1) + k23 * (c2 + k12 * c1));
            abc[2] = -1;
            abc[1] = (d2 + k12 * d1 - (c2 + k12 * c1) * abc[3]) / (b2 + k12 * b1);
            abc[0] = (d1 - b1 * abc[1] - c1 * abc[3]) / a1;
            d.Ap2 = new double[4];
            d.Ap2[0] = abc[0];
            d.Ap2[1] = abc[1];
            d.Ap2[2] = abc[2];
            d.Ap2[3] = abc[3];
            string mnk1 = "";

            mnk1 = "\n\n4)\t Коэффициенты, описывающие плоскость (Π2), которая удовлетворяет распределению точек поверхности 2 наилучшим образом. \na:" + abc[0].ToString() + "\n b: " + abc[1].ToString() + "\n c: " + abc[2].ToString() + "\n d: " + abc[3].ToString();

            MNK.Text += mnk1;
            double[] Lp2 = new double[d.Xp2.Length];
            for (int i = 0; i < d.Xp2.Length; i++)
            {
                Lp2[i] = Math.Abs((abc[0] * d.Xp2[i] + abc[1] * d.Yp2[i] + abc[2] * d.Zp2[i] + abc[3]) / (double)(Math.Sqrt((double)(abc[0] * abc[0] + abc[1] * abc[1] + abc[2] * abc[2]))));
            }
            mnk1 = "\n Cреднее расстояние от точек поверхности 2 до плоскости: " + Lp2.Average().ToString() + "\n Максимальное: " + Lp2.Max().ToString() + "\n Минимальное: " + Lp2.Min().ToString();
            MNK.Text += mnk1;

            

            double ug = Math.Atan(-1 * abc[0] / abc[2]) * 180 * 3600 / Math.PI;
            double ug1 = Math.Atan(-1 * abc[1] / abc[2]) * 180 * 3600 / Math.PI;
            mnk1 = "\nУгол наклона плоскости 2 относительно системы координат в угловых секундах: \n Uoxz2=" + ug.ToString() + "\t Uoyz2=" + ug1.ToString();
            MNK.Text += mnk1;


        }

        public void CalcMNK5()
        {
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            double d1 = 0;
            double a2 = 0;
            double b2 = 0;
            double c2 = 0;
            double d2 = 0;
            double a3 = 0;
            double b3 = 0;
            double c3 = 0;
            double d3 = 0;

            double[] abc = new double[4];
            for (int i = 0; i < d.X.Length; i++)
            {


                a1 += (d.X[i] * d.X[i]);
                b1 += (d.X[i] * d.Y[i]);
                c1 += (d.X[i]);
                d1 += (d.X[i] * d.Z[i]);
                a2 = b1;
                b2 += (d.Y[i] * d.Y[i]);
                c2 += (d.Y[i]);
                d2 += (d.Y[i] * d.Z[i]);
                a3 = c1;
                b3 = c2;
                c3 += 1;
                d3 += (d.Z[i]);


            }

            double k12 = (-1 * a2 / a1);
            double k13 = (-1 * a3 / a1);
            double k23 = (-1 * (b3 + k13 * b1) / (b2 + k12 * b1));
            abc[3] = ((d3 + k13 * d1) + k23 * (d2 + k12 * d1)) / ((c3 + k13 * c1) + k23 * (c2 + k12 * c1));
            abc[2] = -1;
            abc[1] = (d2 + k12 * d1 - (c2 + k12 * c1) * abc[3]) / (b2 + k12 * b1);
            abc[0] = (d1 - b1 * abc[1] - c1 * abc[3]) / a1;
            d.AM = new double[4];
            d.AM[0] = abc[0];
            d.AM[1] = abc[1];
            d.AM[2] = abc[2];
            d.AM[3] = abc[3];
            string mnk1 = "";

            mnk1 = "\n\n5)\t Коэффициенты, описывающие плоскость (M), которая удовлетворяет распределению точек поверхности M наилучшим образом. \na:" + abc[0].ToString() + "\n b: " + abc[1].ToString() + "\n c: " + abc[2].ToString() + "\n d: " + abc[3].ToString();

            MNK.Text += mnk1;
            double[] L = new double[d.X.Length];
            for (int i = 0; i < d.X.Length; i++)
            {
                L[i] = Math.Abs((abc[0] * d.X[i] + abc[1] * d.Y[i] + abc[2] * d.Z[i] + abc[3]) / (double)(Math.Sqrt((double)(abc[0] * abc[0] + abc[1] * abc[1] + abc[2] * abc[2]))));
            }
            mnk1 = "\n Cреднее расстояние от точек поверхности M до плоскости: " + L.Average().ToString() + "\n Максимальное: " + L.Max().ToString() + "\n Минимальное: " + L.Min().ToString();
            MNK.Text += mnk1;


            double ug = Math.Atan(-1 * abc[0] / abc[2]) * 180 * 3600 / Math.PI;
            double ug1 = Math.Atan(-1 * abc[1] / abc[2]) * 180 * 3600 / Math.PI;
            mnk1 = "\nУгол наклона плоскости M относительно системы координат в угловых секундах: \n UoxzM=" + ug.ToString() + "\t UoyzM=" + ug1.ToString();
            MNK.Text += mnk1;


            double[] Pro = new double[d.X.Length];
            double[] Pro_d = new double[d.X.Length];
            double[] Pro_dd = new double[d.X.Length];
            for (int i = 0; i < d.X.Length; i++)
            {
                Pro[i] = -1 * (abc[0] * d.X[i] + abc[1] * d.MY1 + abc[3]) / abc[2];
                Pro_d[i] = Pro[i] + d.Dop;
                Pro_dd[i] = Pro[i] - d.Dop;

            }



        }


        public void CalcMNK6butnot6()
        {
            d.XX = new double[d.X.Length / 2];
            d.YY = new double[d.X.Length / 2];
            d.ZZ = new double[d.X.Length / 2];
            int k = 0;
            for (int i = 0; i < d.X.Length / 2; i++)
            {

                d.XX[i] = (d.X[k] + d.X[k + 1]) / 2;
                d.YY[i] = (d.Y[k] + d.Y[k + 1]) / 2;
                d.ZZ[i] = (d.Z[k] + d.Z[k + 1]) / 2;
                k += 2;
            }

            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            double d1 = 0;
            double a2 = 0;
            double b2 = 0;
            double c2 = 0;
            double d2 = 0;
            double a3 = 0;
            double b3 = 0;
            double c3 = 0;
            double d3 = 0;

            double[] abc = new double[4];
            for (int i = 0; i < d.XX.Length; i++)
            {


                a1 += (d.XX[i] * d.XX[i]);
                b1 += (d.XX[i] * d.YY[i]);
                c1 += (d.XX[i]);
                d1 += (d.XX[i] * d.ZZ[i]);
                a2 = b1;
                b2 += (d.YY[i] * d.YY[i]);
                c2 += (d.YY[i]);
                d2 += (d.YY[i] * d.ZZ[i]);
                a3 = c1;
                b3 = c2;
                c3 += 1;
                d3 += (d.ZZ[i]);


            }

            double k12 = (-1 * a2 / a1);
            double k13 = (-1 * a3 / a1);
            double k23 = (-1 * (b3 + k13 * b1) / (b2 + k12 * b1));
            abc[3] = ((d3 + k13 * d1) + k23 * (d2 + k12 * d1)) / ((c3 + k13 * c1) + k23 * (c2 + k12 * c1));
            abc[2] = -1;
            abc[1] = (d2 + k12 * d1 - (c2 + k12 * c1) * abc[3]) / (b2 + k12 * b1);
            abc[0] = (d1 - b1 * abc[1] - c1 * abc[3]) / a1;
            d.AMM = new double[4];
            d.AMM[0] = abc[0];
            d.AMM[1] = abc[1];
            d.AMM[2] = abc[2];
            d.AMM[3] = abc[3];
            string mnk1 = "";

            mnk1 = "\n\n6)\t Коэффициенты, описывающие плоскость (M), которая удовлетворяет распределению точек поверхности M наилучшим образом. \na:" + abc[0].ToString() + "\n b: " + abc[1].ToString() + "\n c: " + abc[2].ToString() + "\n d: " + abc[3].ToString();

            MNK.Text += mnk1;
            double[] L = new double[d.X.Length / 2];
            for (int i = 0; i < d.X.Length / 2; i++)
            {
                L[i] = Math.Abs((abc[0] * d.XX[i] + abc[1] * d.YY[i] + abc[2] * d.ZZ[i] + abc[3]) / (double)(Math.Sqrt((double)(abc[0] * abc[0] + abc[1] * abc[1] + abc[2] * abc[2]))));
            }
            mnk1 = "\n Cреднее расстояние от точек поверхности M до плоскости: " + L.Average().ToString() + "\n Максимальное: " + L.Max().ToString() + "\n Минимальное: " + L.Min().ToString();
            MNK.Text += mnk1;

            LoadColumnChartDataM(L, Chart4);

            double ug = Math.Atan(-1 * abc[0] / abc[2]) * 180 * 3600 / Math.PI;
            double ug1 = Math.Atan(-1 * abc[1] / abc[2]) * 180 * 3600 / Math.PI;
            mnk1 = "\nУгол наклона плоскости M относительно системы координат в угловых секундах: \n UoxzM=" + ug.ToString() + "\t UoyzM=" + ug1.ToString();
            MNK.Text += mnk1;
            LoadLine(0, d.XX, d.ZZ, line2, false);
            double[] Pro = new double[d.X.Length / 2];
            double[] Pro_d = new double[d.X.Length / 2];
            double[] Pro_dd = new double[d.X.Length / 2];
            for (int i = 0; i < d.X.Length / 2; i++)
            {
                Pro[i] = -1 * (abc[0] * d.XX[i] + abc[1] * d.MY1 + abc[3]) / abc[2];
                Pro_d[i] = Pro[i] + d.Dop;
                Pro_dd[i] = Pro[i] - d.Dop;

            }
            LoadLine(1, d.XX, Pro, line2, true);
            LoadLine(2, d.XX, Pro_d, line2, true);
            LoadLine(3, d.XX, Pro_dd, line2, true);


        }
        private void LoadColumnChartDataM(double[] lp, Chart chart)
        {
            double max = lp.Max();
            double min = lp.Min();
            double a = min + ((max - min) / (double)6);
            double b = min + ((max - min) / (double)3);
            double c = min + ((max - min) / (double)2);
            double d = max - ((max - min) / (double)3);
            double e = max - ((max - min) / (double)6);

            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;
            int a6 = 0;

            for (int i = 0; i < lp.Length; i++)
            {
                if (lp[i] < a) a1++;
                else
                {
                    if (lp[i] < b) a2++;
                    else
                    {
                        if (lp[i] < c) a3++;
                        else
                        {
                            if (lp[i] < d) a4++;
                            else
                            {
                                if (lp[i] < e) a5++;
                                else a6++;
                            }
                        }
                    }
                }
            }
            ////add data to charts
            ((ColumnSeries)chart.Series[0]).ItemsSource = new KeyValuePair<double, int>[] {

            new KeyValuePair < double, int > (Math.Round(a, 4), a1),
            new KeyValuePair<double, int>(Math.Round(b, 4), a2),
            new KeyValuePair<double, int>(Math.Round(c, 4), a3),
            new KeyValuePair<double, int>(Math.Round(d, 4), a4),
            new KeyValuePair<double, int>(Math.Round(e, 4), a5),
            new KeyValuePair<double, int>(Math.Round(max, 4), a6)};

        }

        private void LoadLine(int ii, double[] x, double[] y, Chart chart, bool yes)
        {
            if (yes == true)
            {
                Style dataPointStyle = GetNewDataPointStyle();
                ((LineSeries)chart.Series[ii]).DataPointStyle = dataPointStyle;
            }
            ////add data to charts
            var ok = new KeyValuePair<double, double>[x.Length];
            for (int i = 0; i < x.Length; i++)
                ok[i] = new KeyValuePair<double, double>(x[i], y[i]);
            ((LineSeries)chart.Series[ii]).ItemsSource = ok;


        }


        private static Style GetNewDataPointStyle()
        {

            Style style = new Style(typeof(DataPoint));


            Setter st2 = new Setter(DataPoint.BorderBrushProperty,
                                        new SolidColorBrush(Colors.White));
            Setter st3 = new Setter(DataPoint.BorderThicknessProperty, new Thickness(0.1));

            Setter st4 = new Setter(DataPoint.TemplateProperty, null);

            style.Setters.Add(st2);
            style.Setters.Add(st3);
            style.Setters.Add(st4);
            return style;
        }
       

        public void CalcMNK9()
        {

            string mnk1 = "";
            
            double[][] LSd = new double[21][];

            for (int i = 0; i < LSd.Length; i++)
            {
                LSd[i] = new double[d.XX.Length];
            }
            //double[,] LSd = new double[20,d.XX.Length];
            double[] max = new double[21];
            mnk1 = "\n\n9)\t \n MSt:";
            MNK1.Text += mnk1;
            d.Ksmini = new double[21];
            for (int i = 0; i < 21; i++)
            {
                d.Ksmini[i] = Math.Round(((-0.01 + 0.001 * i)), 3);
            }
                for (int i = 0; i<21; i++)
            {
                max[i] = 0;
                for (int j = 0; j < d.XX.Length; j++) {
                    LSd[i][j] = Math.Abs(d.AMM[0] * d.XX[j] + d.AMM[1]*d.YY[j] + d.AMM[2]*d.ZZ[j]+d.AMM[3]+ d.Ksmini[i]) / Math.Sqrt(d.AMM[0] * d.AMM[0] + d.AMM[1] * d.AMM[1] + d.AMM[2] * d.AMM[2]);
                    if (LSd[i][j] > max[i]) max[i] = LSd[i][j];

                }
      
            }
            LoadLine(0, d.Ksmini, max, line4, false);

            double min = 10;
            int mini = 1;
            for (int i = 0; i < 21; i++)
            {
                if (max[i] < min)
                {
                    mini = i;
                    min = max[i];
                }
            }
            
            mnk1 = "\n min: " + min.ToString() + "\n mini: " + mini.ToString() + "\n Ks: " + d.Ksmini[mini].ToString();
            MNK1.Text += mnk1;
            ///////////////////////////////////////////////////////////////////////
            mnk1 = "\n Cреднее расстояние от точек поверхности M до плоскости: " + LSd[mini].Average().ToString() + "\n Максимальное: " + LSd[mini].Max().ToString() + "\n Минимальное: " + LSd[mini].Min().ToString();
            MNK1.Text += mnk1;

            LoadColumnChartDataM(LSd[mini], Chart5);

            double ug = Math.Atan(-1 * d.AMM[0] / d.AMM[2]) * 180 * 3600 / Math.PI;
            double ug1 = Math.Atan(-1 * d.AMM[1] / d.AMM[2]) * 180 * 3600 / Math.PI;
            mnk1 = "\nУгол наклона плоскости M относительно системы координат в угловых секундах: \n UoxzM=" + ug.ToString() + "\t UoyzM=" + ug1.ToString();
            MNK1.Text += mnk1;
            LoadLine(0, d.XX, d.ZZ, line3, false);
            double[] Pro = new double[d.X.Length / 2];
            double[] Pro_d = new double[d.X.Length / 2];
            double[] Pro_dd = new double[d.X.Length / 2];
            for (int i = 0; i < d.X.Length / 2; i++)
            {
                Pro[i] = -1 * (d.AMM[0] * d.XX[i] + d.AMM[1] * d.MY1 + d.AMM[3] + d.Ksmini[mini]) / d.AMM[2];
                Pro_d[i] = Pro[i] + d.Dop;
                Pro_dd[i] = Pro[i] - d.Dop;

            }
            LoadLine(1, d.XX, Pro, line3, true);
            LoadLine(2, d.XX, Pro_d, line3, true);
            LoadLine(3, d.XX, Pro_dd, line3, true);


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page6 p6 = new Page6(d);


            this.NavigationService.Navigate(p6);
        }

    }
       
}
