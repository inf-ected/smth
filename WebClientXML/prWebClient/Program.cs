using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace prWebClient
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();

            // Add a user agent header in case the 
            // requested URI contains a query.
            Console.WriteLine("/ValCurs/Valute0");
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            //string url = "http://www.bnm.org/ro/official_exchange_rates?get_xml=1&date=12.07.2017";
            //см. страничку http://www.bnm.md/ro/content/ratele-de-schimb там есть ссылка на XML файл
            string url = "http://www.bnm.md/ro/official_exchange_rates?get_xml=1&date=07.05.2018";
            Stream data = client.OpenRead(url);
            Console.WriteLine("/ValCurs/Valute1");
            StreamReader reader = new StreamReader(data,Encoding.UTF8);
            string s = reader.ReadToEnd();
            Console.WriteLine(s);
            Console.WriteLine("---------------------------------------------------");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(s);
            XmlElement root = doc.DocumentElement;
            XmlNodeList list= doc.SelectNodes("/ValCurs/Valute");
            Console.WriteLine("/ValCurs/Valute2");
            foreach (XmlNode el in list)
            {
                XmlNode e1 =el.SelectSingleNode("NumCode");
                Console.WriteLine(e1.InnerText);

            }
            Console.WriteLine("/ValCurs/Valute3"); 
           Console.WriteLine(root.InnerText);
            Console.ReadKey();
        }
    }
}
