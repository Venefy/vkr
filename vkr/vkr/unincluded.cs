﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkr
{
    class unincluded
    {


            //CalcMNK2();
            //CalcMNK3();
            //CalcMNK4();
            //CalcMNK5();

       /*
        private void LoadColumnChartData(double[] lp, Chart chart)
        {
            double max = lp.Max();
            double min = lp.Min();
            double a = min + ((max - min) / (double)3);
            double b = max - ((max - min) / (double)3);

            int a1 = 0;
            int a2 = 0;
            int a3 = 0;

            for (int i = 0; i < lp.Length; i++)
            {
                if (lp[i] < a) a1++;
                else
                {
                    if (lp[i] < b) a2++;
                    else a3++;
                }
            }
    ////add data to charts
    ((ColumnSeries)chart.Series[0]).ItemsSource = new KeyValuePair<double, int>[] {

            new KeyValuePair < double, int > (Math.Round(min, 4), a1),
            new KeyValuePair<double, int>(Math.Round(lp.Average(), 4), a2),
            new KeyValuePair<double, int>(Math.Round(max,4), a3)};

        }

                /*
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
            LoadColumnChartData(Lp1, Chart1);
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

            LoadColumnChartData(Lp2, Chart2);

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

            LoadColumnChartDataM(L, Chart3);

            double ug = Math.Atan(-1 * abc[0] / abc[2]) * 180 * 3600 / Math.PI;
            double ug1 = Math.Atan(-1 * abc[1] / abc[2]) * 180 * 3600 / Math.PI;
            mnk1 = "\nУгол наклона плоскости M относительно системы координат в угловых секундах: \n UoxzM=" + ug.ToString() + "\t UoyzM=" + ug1.ToString();
            MNK.Text += mnk1;
            LoadLine(0, d.X, d.Z, line1, false);

            double[] Pro = new double[d.X.Length];
            double[] Pro_d = new double[d.X.Length];
            double[] Pro_dd = new double[d.X.Length];
            for (int i = 0; i < d.X.Length; i++)
            {
                Pro[i] = -1 * (abc[0] * d.X[i] + abc[1] * d.MY1 + abc[3]) / abc[2];
                Pro_d[i] = Pro[i] + d.Dop;
                Pro_dd[i] = Pro[i] - d.Dop;

            }
            LoadLine(1, d.X, Pro, line1, true);
            LoadLine(2, d.X, Pro_d, line1, true);
            LoadLine(3, d.X, Pro_dd, line1, true);


        }
        */

    
    }
}
