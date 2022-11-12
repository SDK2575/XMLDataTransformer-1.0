using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.Text;

namespace XMLDataTransformer
{
    public static class ScalerWS
    {

        static HttpWebRequest request = null;
        /// <summary>
        /// This method publish the document using scaler web service and workflow
        /// </summary>
        /// <param name="destinationUrl"></param>
        /// <param name="requestXml"></param>
        /// <returns></returns>
        public static string PublishDoc(string destinationUrl, string requestXml)
        {
            string responseStr = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
            byte[] bytes;

            try
            {
                bytes = System.Text.Encoding.ASCII.GetBytes(requestXml);
                request.ContentType = "text/xml; encoding='utf-8'";
                request.ContentLength = bytes.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                HttpWebResponse response;

                using (response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Stream responseStream = response.GetResponseStream();
                        responseStr = new StreamReader(responseStream).ReadToEnd();
                    }
                    else
                    {
                        responseStr = "Error reported";
                    }
                }
                return responseStr;
            }
            catch (Exception ex)
            {
                responseStr = "Error! " + ex.Message;
                return responseStr;
            }
        }

        /// <summary>
        /// This method is used to preview of document by using scaler web service and workflow
        /// </summary>
        /// <param name="destinationUrl"></param>
        /// <param name="requestXml"></param>
        /// <returns></returns>
        public static byte[] PreviewPDF(string destinationUrl, string requestXml)
        {
            const string FRAME = "menubar=yes,toolbar=no,scrollbars=yes,resizable=yes";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
            byte[] bytes;
            bytes = System.Text.Encoding.ASCII.GetBytes(requestXml);
            request.ContentType = "text/xml; encoding='utf-8'";
            request.ContentLength = bytes.Length;
            request.Method = "POST";

            var byteArray = Encoding.ASCII.GetBytes("admin:pass");


            WebHeaderCollection headerColl = new WebHeaderCollection();
            headerColl.Add(HttpRequestHeader.Authorization, "Basic " + Convert.ToBase64String(byteArray));
            request.Headers.Add(headerColl);
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();

                BinaryReader breader = new BinaryReader(responseStream);
                bytes = breader.ReadBytes((int)response.ContentLength);
                //return bytes;
                //Session["data"] = bytes;

                //ResponseHelper.Redirect("Preview.aspx", "Preview Document", FRAME);
                //string responseStr = new StreamReader(responseStream).ReadToEnd();


            }
            return bytes;
        }
    }
}