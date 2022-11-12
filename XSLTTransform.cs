using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Xsl;
using System.IO;
using System.Xml.XPath;
using System.Xml;

namespace XMLDataTransformer
{
    public static class XSLTTransform
    {
        static string xmlFilePath = string.Empty;
        static string dataXSLPath = string.Empty;
        static string ExcelXSLPath = string.Empty;
        
        public static string TransformXml(XmlReader rdr,int mode, string strLob)
        {
            //XSLT object
            var myXL = new XslCompiledTransform();
            

            if (mode == 1)
            {
                   dataXSLPath = ConfigurationManager.AppSettings["DataXslt"].ToString();
                   string xsltPath = dataXSLPath + strLob + "_ParseData.xslt";
                   myXL.Load(xsltPath);             
             
            }
            else
            {
                ExcelXSLPath = ConfigurationManager.AppSettings["ExcelXslt"].ToString();
                myXL.Load(ExcelXSLPath);
            }

            string outxml = string.Empty;
            var myDoc = new XPathDocument(rdr);

            var writer = new StringWriter();

            myXL.Transform(myDoc, null, writer);
            outxml = writer.ToString();

            writer.Flush();
            writer.Close();

            return outxml;
        }


        public static string TransformToExcel(XmlReader rdr)
        {
            //XSLT object
            var myXL = new XslCompiledTransform();
                                   
            ExcelXSLPath = ConfigurationManager.AppSettings["ExcelXslt"].ToString();
            myXL.Load(ExcelXSLPath);           

            string outxml = string.Empty;
            var myDoc = new XPathDocument(rdr);

            //XmlTextWriter writer = new XmlTextWriter(@"c:\temp\ExportData.xls",null);

            var writer = new StringWriter();

            myXL.Transform(myDoc, null, writer);
            outxml = writer.ToString();

            //writer.Flush();
            writer.Close();

            return outxml;
        }
    }
}
