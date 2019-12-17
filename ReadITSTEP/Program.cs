using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;


namespace ReadITSTEP
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();

            // Add a user agent header in case the 
            // requested URI contains a query.
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            
            string url = "https://itstep.md/news-ru/";
            Stream data = client.OpenRead(url);
            
            StreamReader reader = new StreamReader(data, Encoding.UTF8);
            string s = reader.ReadToEnd();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
