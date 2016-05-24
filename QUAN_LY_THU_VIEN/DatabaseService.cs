using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUAN_LY_THU_VIEN
{
    class DatabaseService
    {
        static QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities();
        
        public static void testEF()
        {
            foreach(var quydinh in db.QUYDINHs)
            {
               
            }
        }
    }
}
