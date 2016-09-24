using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Ninponix_Office
{
    class Log
    {
        static string LogContent;
        static string startingpathe = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\";
        public static void WriteEntry(string Message, string Application)
        {
            using (StreamReader sr = new StreamReader(startingpathe + "Runtime\\LOG.nofficelog"))
            {
                LogContent = sr.ReadToEnd();   
            }

            LogContent = LogContent + "\n" + DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " : " + Application.ToString() + ": " + Message.ToString();
            using (StreamWriter sw = new StreamWriter(startingpathe + "Runtime\\LOG.nofficelog"))
            {
                sw.Write(LogContent);    
            }
        }
        
        public static void Clear()
        {
            using(StreamWriter sw = new StreamWriter(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\LOG.nofficelog"))
            {
                sw.Write(LogContent);
            }
        }

        public static string ReadLog()
        {
            string return_str;
            using (StreamReader sr = new StreamReader(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\LOG.nofficelog"))
            {
                return_str = sr.ReadToEnd();
                sr.Close();
            }

            return return_str;
        }

        public static string ReadLastEntry() 
        {
            string return_str = "";
            foreach (var lines in ReadLog().Split('\n'))
            {
                return_str = lines;
            }

            return return_str;
        }
    }
}
