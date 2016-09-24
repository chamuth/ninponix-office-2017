using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninponix_Office.PresentationToolBox
{
    public static class ExportPres
    {
        /// <summary>
        /// Exports the presentation.
        /// </summary>
        /// <param name="Text">The code of the presentation</param>
        /// <param name="Includes">Including files of the presentation</param>
        /// <param name="where">Whetrre to save the files</param>
        public static void Export(string where,string Text,string Includes)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(where))
            {
                sw.Write(Text);
                sw.Flush();
                sw.Close();
            }

            System.IO.FileInfo f = new System.IO.FileInfo(where);
            string directoryinformation = f.DirectoryName;

            foreach (var file in Includes.Split(';'))
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(file);
                fi.CopyTo(directoryinformation + "/" + fi.Name);
            }
        }
    }
}
