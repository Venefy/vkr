using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Globalization;

namespace vkr
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        public Data d = new Data();
        public Page1()
        {
            InitializeComponent();
            

        }


        public void OpenExcel(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog openfile = new OpenFileDialog();

            //openfile.DefaultExt = ".xlsx";
            //openfile.Filter = "(.xlsx)|*.xlsx";
            //openfile.ShowDialog();
            

            var browsefile = openfile.ShowDialog();
            if (browsefile == true)
            {
                var con = new SmartConnection();
                using (var cn = new OleDbConnection(con.ConnectionString(openfile.FileName, 1)))
                {
                    try
                    {
                        cn.Open();
                  

                    OleDbDataAdapter objDA1 = new System.Data.OleDb.OleDbDataAdapter("select * from [Лист1$]", cn);
                    DataSet excelDataSet1 = new DataSet();
                    objDA1.Fill(excelDataSet1);
                    //dtGrid.DataSet= excelDataSet.Tables[0];
                    dtGrid1.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = excelDataSet1.Tables[0] });
                    d.X = new double[excelDataSet1.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet1.Tables[0].Rows.Count; col++)
                    {
                        d.X[col] = double.Parse(excelDataSet1.Tables[0].Rows[col][1].ToString(), CultureInfo.InvariantCulture);
                    }
                    d.Y = new double[excelDataSet1.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet1.Tables[0].Rows.Count; col++)
                    {
                        d.Y[col] = double.Parse(excelDataSet1.Tables[0].Rows[col][2].ToString(), CultureInfo.InvariantCulture);
                    }
                    d.Z = new double[excelDataSet1.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet1.Tables[0].Rows.Count; col++)
                    {
                        d.Z[col] = double.Parse(excelDataSet1.Tables[0].Rows[col][3].ToString(), CultureInfo.InvariantCulture);
                    }
                    d.AA = double.Parse(excelDataSet1.Tables[0].Rows[0][4].ToString(), CultureInfo.InvariantCulture);
                    d.BB = double.Parse(excelDataSet1.Tables[0].Rows[0][5].ToString(), CultureInfo.InvariantCulture);

                    OleDbDataAdapter objDA2 = new System.Data.OleDb.OleDbDataAdapter("select * from [Лист2$]", cn);
                    DataSet excelDataSet2 = new DataSet();
                    objDA2.Fill(excelDataSet2);
                    //dtGrid.DataSet= excelDataSet.Tables[0];
                    dtGrid2.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = excelDataSet2.Tables[0] });
                    d.Xp1 = new double[excelDataSet2.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet2.Tables[0].Rows.Count; col++)
                    {
                        d.Xp1[col] = double.Parse(excelDataSet2.Tables[0].Rows[col][0].ToString(), CultureInfo.InvariantCulture);                      
                    }
                    d.Yp1 = new double[excelDataSet2.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet2.Tables[0].Rows.Count; col++)
                    {
                        d.Yp1[col] = double.Parse(excelDataSet2.Tables[0].Rows[col][1].ToString(), CultureInfo.InvariantCulture);
                    }
                    d.Zp1 = new double[excelDataSet2.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet2.Tables[0].Rows.Count; col++)
                    {
                        d.Zp1[col] = double.Parse(excelDataSet2.Tables[0].Rows[col][2].ToString(), CultureInfo.InvariantCulture);
                    }


                        



                        OleDbDataAdapter objDA3 = new System.Data.OleDb.OleDbDataAdapter("select * from [Лист3$]", cn);
                    DataSet excelDataSet3 = new DataSet();
                    objDA3.Fill(excelDataSet3);
                    //dtGrid.DataSet= excelDataSet.Tables[0];
                    dtGrid3.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = excelDataSet3.Tables[0] });
                    d.Xp2 = new double[excelDataSet3.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet3.Tables[0].Rows.Count; col++)
                    {
                        d.Xp2[col] = double.Parse(excelDataSet3.Tables[0].Rows[col][0].ToString(), CultureInfo.InvariantCulture);
                    }
                    d.Yp2 = new double[excelDataSet3.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet3.Tables[0].Rows.Count; col++)
                    {
                        d.Yp2[col] = double.Parse(excelDataSet3.Tables[0].Rows[col][1].ToString(), CultureInfo.InvariantCulture);
                    }
                    d.Zp2 = new double[excelDataSet3.Tables[0].Rows.Count];
                    for (int col = 0; col < excelDataSet3.Tables[0].Rows.Count; col++)
                    {
                        d.Zp2[col] = double.Parse(excelDataSet3.Tables[0].Rows[col][2].ToString(), CultureInfo.InvariantCulture);
                    }


                    ////////////////////////////
                    /////////////////////////////
                    ///////////////////////////
                    /////////////////////////////
                    ///////////////////////////////
                    ///can be transported
                    
                    d.Xp = d.Xp1.Concat(d.Xp2).ToArray();
                    d.Yp = d.Yp1.Concat(d.Yp2).ToArray();
                    d.Zp = d.Zp1.Concat(d.Zp2).ToArray();

                     
                        


                        d.MY1 = double.Parse(excelDataSet1.Tables[0].Rows[0][6].ToString(), CultureInfo.InvariantCulture);
                    d.MY1 = -d.MY1;
                    d.MY2 = double.Parse(excelDataSet1.Tables[0].Rows[0][7].ToString(), CultureInfo.InvariantCulture);
                    d.MY2 = -d.MY2;
                    }
                    catch
                    {
                        MessageBox.Show("Введен путь не к таблице");
                    }
                }

            }

        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            dtGrid1.ClearValue(ItemsControl.ItemsSourceProperty);
            dtGrid2.ClearValue(ItemsControl.ItemsSourceProperty);
            dtGrid3.ClearValue(ItemsControl.ItemsSourceProperty);
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2(d);
            p2.Xaa.Text = this.d.AA.ToString();
            p2.Xbb.Text = this.d.BB.ToString();
            p2.MY1.Text = this.d.MY1.ToString();
            p2.MY2.Text = this.d.MY2.ToString();
            

            this.NavigationService.Navigate(p2);
        }
    }
   
}
