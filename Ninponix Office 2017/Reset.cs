using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office
{
    public static class Reset
    {
        public static bool ResetSettings()
        {
            try
            {
                //RESET THE SETTINGS IN THE USER SETTINGS
                Properties.Settings.Default.Reset();
                //RESET NINPONIX OFFICE VALUES
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + @"OfficeData\Values\2102.nofficesetting"))
                {
                    sw.Write("0");
                    sw.Flush();
                    sw.Close();
                }

                return true;
            }
            catch (Exception) { return false; }
        }
    }
}
