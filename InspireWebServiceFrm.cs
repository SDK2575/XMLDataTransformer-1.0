using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLDataTransformer
{
    public partial class InspireWebServiceFrm : Form
    {

        public string directoryPath = string.Empty;
        public StringBuilder strBuilder = new StringBuilder();
        public XmlDocument xDoc = new XmlDocument();
        public StringBuilder sb = new StringBuilder();

        public InspireWebServiceFrm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            directoryPath = textBox1.Text;
            LoadFiles();
        }


        private void LoadFiles()
        {
            DirectoryInfo di = new DirectoryInfo(directoryPath);
            foreach (FileInfo fi in di.GetFiles())
            {
                if (fi.Extension == ".xml")
                {
                    listBox1.Items.Add(fi.Name);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int listCount = listBox1.Items.Count;

            for (int i = 0; i < listCount; i++)
            {
                listBox1.SetSelected(i, true);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int listCount = listBox1.Items.Count;

            for (int i = 0; i < listCount; i++)
            {
                listBox1.SetSelected(i, false);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            int fileCount = 0;
            int selfileCount = 0;
            bool process = true;

            fileCount = listBox1.Items.Count;
            selfileCount = listBox1.SelectedItems.Count;

            if (process)
            {
                if (selfileCount > 0)
                {
                    //XmlDocument xmldoc = new XmlDocument();
                    //xmldoc.Load(directoryPath + "\\" + listBox1.SelectedItem.ToString());  
                    label10.Text = DateTime.Now.TimeOfDay.ToString();
                                                    
                    for (int i = 0; i <= fileCount - 1; i++)
                    {
                        if (listBox1.GetSelected(i) == true)
                        {
                            string strXmlData = File.ReadAllText(directoryPath + "\\" + listBox1.SelectedItem.ToString() + "");

                            ScalerWS.PublishDoc("http://inspiredwt1:30600/rest/api/submit-job/PublishWCUPCODDoc", strXmlData);
                       }
                    }

                    label11.Text = DateTime.Now.TimeOfDay.ToString();
                }

            }
        }



    }
}
