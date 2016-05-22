using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;
using System.Configuration;
using System.Collections;

namespace INI
{
    public class IniFile
    {
        private string path;
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filepath);
        
        public IniFile(string pathini)
        {
            path = pathini;
        }

        // Write ini file
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }

        // Read ini file
        public string IniReadValue(string Section, string Key)
        {
            int buffer;
            buffer = 255; // Define length
            StringBuilder temp = new StringBuilder(buffer);
            GetPrivateProfileString(Section, Key, "", temp, buffer, path);
            return temp.ToString();
        }
    }
}
