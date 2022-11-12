using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLDataTransformer
{
    public partial class WebScrapper : Form
    {

        private string _url = string.Empty;

        string[] urlArray = new string[13];



        public string url
        {
            get
            {
               return _url;
            }

            set
            {

                _url = value;
            }

        }

        public string[] QueryTerms { get; } = { "NJM Build Number" };

        public WebScrapper()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
                        
            foreach (string s in urlArray)
            {

                ScrapeWebData(s);
            }
        }
                

        internal async void ScrapeWebData(string urlInput)
        {

            HttpClient httpClient = new HttpClient();

            HttpResponseMessage request = await httpClient.GetAsync(urlInput);

            Stream response = await request.Content.ReadAsStreamAsync();

            byte[] bytes = new byte[response.Length];
            response.Position = 0;
            response.Read(bytes, 0, (int)response.Length);
            object enc = null;
            string data = Encoding.ASCII.GetString(bytes);

            //richTextBox1.Text = data;


            string pattern = @"Version :\s+(.*)";                        

            // Create a Regex  
            Regex rg = new Regex(pattern);


            Match match = rg.Match(data);
             
             if (match.Success)
            {
                string strEnv = string.Empty;

                string strVal = match.Value;
                strVal = strVal.Replace("</li>", "");

                if (urlInput.Contains("dev") && urlInput.Contains("Staging"))
                {
                    strEnv = "DEV Staging";
                }
                if (urlInput.Contains("dev") && urlInput.Contains("Claims"))
                {
                    strEnv = "DEV Claims";
                }
                if (urlInput.Contains("dev") && urlInput.Contains("Underwrting"))
                {
                    strEnv = "DEV Underwrting";
                }
                if (urlInput.Contains("dev") && urlInput.Contains("Staging"))
                {
                    strEnv = "DEV Staging";
                }
                else if  (urlInput.Contains("dev"))
                {
                    strEnv = "DEV";
                }

                if (urlInput.Contains("qa") && urlInput.Contains("Staging"))
                {
                    strEnv = "QA Staging";
                }
                else if (urlInput.Contains("qa"))
                {
                    strEnv = "QA";
                }

                if (urlInput.Contains("uat") && urlInput.Contains("Staging"))
                {
                    strEnv = "UAT Staging";
                }
                else if (urlInput.Contains("uat"))
                {
                    strEnv = "UAT";
                }

                if (urlInput.Contains("sm"))
                {
                    strEnv = "PROD";
                }

                richTextBox1.Text += Environment.NewLine + "";

                richTextBox1.AppendText(strEnv);
                richTextBox1.AppendText("=");
                richTextBox1.AppendText(strVal);
            }

                richTextBox1.Text += Environment.NewLine + "-------------------------------------------------";

               
        }

        private void WebScrapper_Load(object sender, EventArgs e)
        {
            //Load Arrary 

            urlArray[0] = "http://devproxy.njmgroup.com/ICE/Public/About.html";
            urlArray[1] = "http://devproxy.njmgroup.com/ICEStaging/Public/About.html";

            urlArray[2] = "http://qaproxy.njmgroup.com/ICE/Public/About.html";
            urlArray[3] = "http://qaproxy.njmgroup.com/ICEStaging/Public/About.html";

            urlArray[4] = "http://ntguat.njmgroup.com/ICE/Public/About.html";
            urlArray[5] = "http://ntguat.njmgroup.com/ICEStaging/Public/About.html";


            urlArray[6] = "http://devproxy.njmgroup.com/ICEClaims/Public/About.html";
            urlArray[7] = "http://devproxy.njmgroup.com/ICEUnderwriting/Public/About.html";

            urlArray[8] = "http://qaproxy.njmgroup.com/ICEClaims/Public/About.html";
            urlArray[9] = "http://qaproxy.njmgroup.com/ICEUnderwriting/Public/About.html";

            urlArray[10] = "http://ntguat.njmgroup.com/ICEClaims/Public/About.html";
            urlArray[11] = "http://ntguat.njmgroup.com/ICEUnderwriting/Public/About.html";

            urlArray[12] = "http://smproxy.njmgroup.com/ICE/Public/About.html";
           
        }
    }
}
