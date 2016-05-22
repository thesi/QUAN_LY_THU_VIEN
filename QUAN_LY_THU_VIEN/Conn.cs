using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using INI;
using System.Windows.Forms;
using System.IO;

namespace QUAN_LY_THU_VIEN
{
   public class Conn
    {
        public static SqlConnection GetCon()
        {
            string path = Directory.GetCurrentDirectory();
            string configPath = Path.Combine(path, "SQL.ini");

            IniFile x = new IniFile(configPath);
            string strConnect = @"Data Source=" + x.IniReadValue("CONNECT", "Name");
            strConnect += ";Initial Catalog=" + x.IniReadValue("CONNECT", "Database");
            if (x.IniReadValue("CONNECT", "Windows Authentication") == "true")
                strConnect += ";Integrated Security = True;";
            else
            {
                strConnect += ";UID = " + x.IniReadValue("CONNECT", "user") + ";";
                strConnect += "pwd = " + x.IniReadValue("CONNECT", "pass") + ";";
            }
            
            return new SqlConnection(strConnect);
            //return new SqlConnection( "Data Source=URUKU-LAPTOP;Initial Catalog=QUANLYDULICH;Integrated Security=True");
        }
        
    }
}
