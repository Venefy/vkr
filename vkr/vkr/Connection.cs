using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace vkr
{
        public class SmartConnection
        {
            public string ConnectionString(string pFileName, int pImex = 1)
            {
                var builder = new OleDbConnectionStringBuilder();
                if (System.IO.Path.GetExtension(pFileName)?.ToUpper() == ".XLS")
                {
                    builder.Provider = "Microsoft.Jet.OLEDB.4.0";
                    builder.Add("Extended Properties", $"Excel 8.0;IMEX={pImex};HDR=NO;");
                }
                else
                {
                    builder.Provider = "Microsoft.ACE.OLEDB.12.0";
                    builder.Add("Extended Properties", $"Excel 12.0;IMEX={pImex};HDR=NO;");
                }

                builder.DataSource = pFileName;

                return builder.ConnectionString;
            }
        }
    
}
