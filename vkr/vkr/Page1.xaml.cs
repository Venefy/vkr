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
using Excel = Microsoft.Office.Interop.Excel;


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
                    txtFilePath.Text = openfile.FileName;


                var xlApp = new Excel.Application();
                var wb = xlApp.Workbooks.Open(txtFilePath.Text.ToString(), ReadOnly: true);
                xlApp.Visible = true;
                var ws = wb.Worksheets[1];
                var r = ws.Range["A2"].Resize[100, 1];
                var array = r.Value;
                // array is object[1..100,1..1]
                for (int i = 1; i <= 100; i++)
                {
                    var text = array[i, 1] as string;
              
                }
                // to create an [1..100,1..1] array use
                var array2 = Array.CreateInstance(
                    typeof(object),
                    new int[] { 100, 1 },
                    new int[] { 1, 1 }) as object[,];

                // fill array2
                for (int i = 1; i <= 100; i++)
                {
                    array2[i, 1] = string.Format("Text{0}", i);
                }
                r.Value2 = array2;

                wb.Close();
                xlApp.Quit();

                }
            
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("bye(");
        }
    }
}
