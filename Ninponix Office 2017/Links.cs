using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninponix_Office
{
    /// <summary>
    /// Getting and setting links for the application domain is done by this class
    /// </summary>
    public static class Links
    {
        public static string KeystorePath = "";

        public static void Update()
        {
            try
            {
                //STILL NOT IMPLEMENTED GUYS.
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Gets the Link for the appropriate key provided by the user
        /// </summary>
        /// <param name="KEY">The Key to which you want the link of</param>
        public static string GetLinkByKey (string KEY)
        {
            try
            {
                string ret_val = "http://www.ninponix.ml";

                foreach (var line in System.IO.File.ReadAllLines(KeystorePath))
                {
                    string key = line.Split(';')[0];
                    string value = line.Split(';')[1];

                    if (key.TrimStart().TrimEnd() == KEY.TrimStart().TrimEnd())
                    {
                        //MATCHES THE KEY
                        ret_val = value;
                    }
                }

                return ret_val;
            }
            catch (Exception)
            {
                return "http://www.ninponix.ml";
            }
        }
    }
}
