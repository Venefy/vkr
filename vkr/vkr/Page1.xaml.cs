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
                        
                        OleDbDataAdapter objDA = new System.Data.OleDb.OleDbDataAdapter("select * from [Лист1$]", cn);
                         DataSet excelDataSet = new DataSet();
                         objDA.Fill(excelDataSet);
                         //dtGrid.DataSet= excelDataSet.Tables[0];
                         dtGrid.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = excelDataSet.Tables[0] });
                }

                }
            
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            dtGrid.ClearValue(ItemsControl.ItemsSourceProperty);
        }

        private void Check(object sender, RoutedEventArgs e)
        {
           
            this.NavigationService.Navigate(new Page2());
        }
    }
   
}
