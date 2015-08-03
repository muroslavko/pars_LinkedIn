using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars_LinkedIn
{
    class Program
    {
        static void Main(string[] args)
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://ua.linkedin.com/in/antonvasilenko");
            var name = doc.DocumentNode.SelectNodes("//span[@class='full-name']");
            if (name != null)
            {
                foreach (var node in name)
                {
                    Console.WriteLine(node.InnerHtml);
                }
            }
            else
            {
                Console.WriteLine("Its null");
            }
            Console.ReadLine();
        }
    }
}
