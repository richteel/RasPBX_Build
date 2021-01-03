using System;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace FreePBX_Utility.Web
{
    public static class WebContent
    {
        public static string GetResponseText(string url)
        {
            string strContent = "";

            try
            {
                var webRequest = WebRequest.Create(url);

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    strContent = reader.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                Debug.Print(string.Format("Error connecting to the wesite {0}\n{1}", url, ex.Message));
            }

            return strContent;
        }
    }
}
