using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUAN_LY_THU_VIEN
{
   public class Func : Conn
    {
        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }

        public bool CheckLoginNhanVien(string name, string pass)
        {
            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                string encryptPass = md5(pass);
                var dangnhapQuery = from dangnhap in db.DANGNHAPs
                                    where dangnhap.TENDANGNHAP == name && dangnhap.MATKHAU == encryptPass
                                    select dangnhap;
                if (dangnhapQuery.Any())
                {
                    var capnhatDN = from dangnhap in db.DANGNHAPs where dangnhap.TENDANGNHAP == name select dangnhap;
                    DANGNHAP objDangnhap = capnhatDN.Single();
                    objDangnhap.SOLANDN += 1;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }     
        }

        public bool CheckDNLanDau(string name)
        {
            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var sldnQuery = from dangnhap in db.DANGNHAPs
                                    where dangnhap.TENDANGNHAP == name
                                    select dangnhap.SOLANDN;
                if (sldnQuery.Any())
                {
                    int sldn = Convert.ToInt32(sldnQuery.Single());
                    if (sldn == 1) return true;
                }
                return false;

            }      
        }
        public bool CheckDoiMK(string name)
        {
            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var sldnQuery = from dangnhap in db.DANGNHAPs
                    where dangnhap.TENDANGNHAP == name
                    select new {dangnhap.SOLANDN, dangnhap.DOIMATKHAU};
                if (sldnQuery.Any())
                {
                    var obj = sldnQuery.Single();
                    if (obj.SOLANDN > 1 && obj.DOIMATKHAU == 0) return true;
                }
                return false;
            }
        }

        public string BoKhoangTrang(string s)
        { 
            
            if (s.Length >= 2)
            {
              string x  = s.Substring(s.Length - 2, 2);

                if (x.Length == 2 && x == "  ")
                {
                    MessageBox.Show("Không được nhập 2 khoảng trắng giữa các kí tự !!!");
                    s = s.Substring(0, s.Length - 1);
                }
            }
            return s;
        }


    
    }
}
