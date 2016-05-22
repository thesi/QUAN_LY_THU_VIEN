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
       /* public SqlConnection GetCon()
        {
            return new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Du Lieu\\ViRus\\QUANLYDULICH.mdf;Integrated Security=True;User Instance=True");

        }*/
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

            SqlConnection con = Conn.GetCon();
            string sql;
            sql = ("select * from DANGNHAP where TENDANGNHAP='" + name + "' and MATKHAU='" + md5(pass) + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update dangnhap set solandn = solandn + 1 where tendangnhap = '"+name+"'" , con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                con.Close();
                return true;
            } 
            else
            {
                con.Close();
                return false;

            }
        
        
        }
        public bool CheckDNLanDau(string name)
        {
            SqlConnection con = Conn.GetCon();
            string sql;
            sql = ("select solandn from DANGNHAP where TENDANGNHAP='" + name + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "1")
                {
                    con.Close();
                    return true;

                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
        public bool CheckDoiMK(string name)
        {
            SqlConnection con = Conn.GetCon();
            string sql;
            sql = ("select solandn,doimatkhau from DANGNHAP where TENDANGNHAP='" + name + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (int.Parse(dr[0].ToString()) > 1 && dr[1].ToString() == "0")
                {
                    con.Close();
                    return true;

                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            else
            {
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
