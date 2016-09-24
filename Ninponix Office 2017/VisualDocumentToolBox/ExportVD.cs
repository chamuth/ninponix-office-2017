using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninponix_Office.VisualDocumentToolBox
{
    public static class ExportVD
    {
        public static bool Export(string PROJECT_PATH, string EXPORT_PATH, string CODE_LINES)
        {
            try
            {
                foreach (var lines in CODE_LINES.Split('\n'))
                {
                    if (lines.StartsWith("{IMAGE>"))
                    {
                        string url = lines.Split('}')[1].ToString();
                        if (url.StartsWith(".."))
                        {
                            System.IO.File.Copy(PROJECT_PATH + url.ToString(), EXPORT_PATH + url.ToString());
                        }
                    }
                }

                System.IO.File.WriteAllText(EXPORT_PATH + "\\Document.nvlexp", CODE_LINES);

                System.Diagnostics.Process.Start("explorer.exe", EXPORT_PATH);

                return true;

            }catch (Exception)
            {
                return false;
            }
        }
    }
}
