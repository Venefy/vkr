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


namespace vkr
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }


        private void OpenExcel(object sender, RoutedEventArgs e)
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
                        cn.Open();
                        
                        OleDbDataAdapter objDA1 = new System.Data.OleDb.OleDbDataAdapter("select * from [Лист1$]", cn);
                         DataSet excelDataSet1 = new DataSet();
                         objDA1.Fill(excelDataSet1);
                         //dtGrid.DataSet= excelDataSet.Tables[0];
                         dtGrid1.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = excelDataSet1.Tables[0] });
                         OleDbDataAdapter objDA2 = new System.Data.OleDb.OleDbDataAdapter("select * from [Лист2$]", cn);
                        DataSet excelDataSet2 = new DataSet();
                        objDA2.Fill(excelDataSet2);
                        //dtGrid.DataSet= excelDataSet.Tables[0];
                        dtGrid2.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = excelDataSet2.Tables[0] });
                         OleDbDataAdapter objDA3 = new System.Data.OleDb.OleDbDataAdapter("select * from [Лист3$]", cn);
                        DataSet excelDataSet3 = new DataSet();
                        objDA3.Fill(excelDataSet3);
                        //dtGrid.DataSet= excelDataSet.Tables[0];
                        dtGrid3.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = excelDataSet3.Tables[0] });
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
           
            this.NavigationService.Navigate(new Page2());
        }
    }
   
}
