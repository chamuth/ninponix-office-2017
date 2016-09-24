using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office_Registry_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Run no shit
            try
            {
                foreach (string file in System.IO.Directory.GetFiles(Application.ExecutablePath.ToString().Replace("RegistryManager.exe", "") + "Registration\\"))
                {
                    try
                    {
                        string content = System.IO.File.ReadAllText(file);
                        content = content.Replace("APPLICATION_PATH", Application.ExecutablePath.ToString().Replace("RegistryManager.exe", "") + "Ninponix Office.exe");
                        content = content.Replace("VDLAUNCHER_LOCATION", Application.ExecutablePath.ToString().Replace("RegistryManager.exe", "") + "VD_Launcher.exe");
                        System.Diagnostics.Process.Start(file);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
