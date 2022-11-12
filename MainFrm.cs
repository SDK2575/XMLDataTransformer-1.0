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
using System.Xml.XPath;
using System.Xml.Xsl;

namespace XMLDataTransformer
{
    public partial class MainFrm : Form
    {
        public string directoryPath = string.Empty;
        public StringBuilder strBuilder = new StringBuilder();
        public XmlDocument xDoc = new XmlDocument();
        public StringBuilder sb = new StringBuilder();

        public MainFrm()
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            try {

                int fileCount = 0;
                int selfileCount = 0;
                bool process = true;

                string strLob = string.Empty;

                if (cbLob.SelectedIndex < 0)
                {
                    MessageBox.Show("You have not selected LOB value. Please select LOB then try again.", "LOB Not Selected!!", MessageBoxButtons.RetryCancel);
                    process = false;
                }
                else
                {
                    strLob = cbLob.SelectedItem.ToString();
                }
                
                fileCount = listBox1.Items.Count;
                selfileCount = listBox1.SelectedItems.Count;               

                sb.Append("<?xml version='1.0'?><Root>");

                if (process)
                {
                    if (selfileCount > 0)
                    {
                        //XmlDocument xmldoc = new XmlDocument();
                        //xmldoc.Load(directoryPath + "\\" + listBox1.SelectedItem.ToString());                              
                        for (int i = 0; i <= fileCount - 1; i++)
                        {
                            if (listBox1.GetSelected(i) == true)
                            {
                                XmlTextReader reader = new XmlTextReader(directoryPath + "\\" + listBox1.Items[i].ToString());
                                strBuilder.Append(XSLTTransform.TransformXml(reader, 1,strLob));

                                //remove xml declaration 
                                strBuilder.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
                                //load into xDoc (XmlDocument OBJECT)
                                xDoc.LoadXml(strBuilder.ToString());

                                XmlDocumentFragment xfrag = xDoc.CreateDocumentFragment();
                                xfrag.InnerXml = "<FILE_NAME>" + listBox1.Items[i].ToString() + "</FILE_NAME>";
                                xDoc.DocumentElement.AppendChild(xfrag);

                                //empty first String Builder;
                                strBuilder.Clear();
                                sb.Append(xDoc.InnerXml);
                                xDoc.RemoveAll();
                                reader.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have not selected any file from the List. Please select one or more files, then try again.", "File(s) Not Selected!!", MessageBoxButtons.RetryCancel);
                    }

                    sb.Append("</Root>");

                    MessageBox.Show("Transform completed successfully", "Success", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !!", MessageBoxButtons.RetryCancel);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (XmlReader xmlReader = XmlReader.Create(new StringReader(sb.ToString())))
                {
                    //call Read and other methods of xmlReader here
                    string strOut = XSLTTransform.TransformToExcel(xmlReader);
                    File.WriteAllText(txtExpFile.Text, strOut);
                    MessageBox.Show("Export File Created", "Success", MessageBoxButtons.OK);
                    sb.Clear();
                    strOut = string.Empty;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !!", MessageBoxButtons.RetryCancel);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            txtExpFile.Text = "";
            cbLob.Text = "";
        }

        private void cbLob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iCEWebScrapperToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WebScrapper webScarp = new WebScrapper();
            webScarp.Show();

        }

        private void inspireWSTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InspireWebServiceFrm wsTester = new InspireWebServiceFrm();
            wsTester.Show();

            
        }
    }
}
