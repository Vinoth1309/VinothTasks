using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using TaskWebService.AppCode;
using log4net;
using System.Text;
using System.Web.Configuration;
namespace TaskWebService
{
    [WebService(Namespace = "TaskWebService.abc/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string Fibonacci(int n)
        {
            long a = 0, b = 1, c = 0;
            string result = string.Empty;
            Logger.LogInfoMessage("Finding Nth value in the Fibonacci sequence");
            Logger.LogInfoMessage("The given input:" + n);
            try
            {
                if (n == 0)
                {
                    result = string.Concat(string.Format("Fibonacci ({0}) is {1}", n, a));
                    Logger.LogInfoMessage(result);
                }
                else if (n == 1)
                {
                    result = string.Concat(string.Format("Fibonacci ({0}) is {1}", n, b));
                    Logger.LogInfoMessage(result);
                }
                else if (n > 1 && n <= 100)
                {
                    for (int i = 2; i <= n; i++)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    result = string.Concat(result, string.Format("Fibonacci ({0}) is {1}", n, c));
                    Logger.LogInfoMessage(result);

                }
                else
                {
                    result = string.Concat("Fibonacci (" + n + ") is -1");
                    Logger.LogInfoMessage(result);
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }
        [WebMethod]
        public string XmlToJson(string xml)
        {
            Logger.LogInfoMessage("XML To JSON");
            Logger.LogInfoMessage("The given xml input:" + xml);
            string jsonResult = xml;
            XmlDocument doc = new XmlDocument();
            try
            {
                try
                {
                    doc.LoadXml(xml);
                }
                catch (XmlException)
                {
                    Logger.LogInfoMessage("Bad XML Format");
                    return jsonResult = "Bad XML Format";
                }
                if (WebConfigurationManager.AppSettings["JsonFormat"].ToString() == "True")
                    jsonResult = XMLToJson.XmlToJSON(doc);
                Logger.LogInfoMessage("The Converted Json String: " + jsonResult);
                return jsonResult;
            }
            catch (Exception ex)
            {
                Logger.LogInfoMessage("EXCEPTION: " + ex.Message.ToString());
                return ex.Message.ToString();
            }
        }
    }
}