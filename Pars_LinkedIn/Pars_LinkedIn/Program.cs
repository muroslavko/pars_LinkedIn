using HtmlAgilityPack;
using System;
using System.Collections;
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
            Print(name);

            var summary = doc.DocumentNode.SelectNodes("//p[@class='description']");
            Print(summary);

            //var pastPosition = doc.DocumentNode.SelectNodes("//div[@class='editable-item section-item past-position']");
            //Print(pastPosition);



            Console.ReadLine();
        }


        static void Print(HtmlNodeCollection o)
        {
            if (o != null)
            {
                foreach (var node in o)
                {
                    Console.WriteLine(node.InnerHtml);
                }
            }
            else
            {
                Console.WriteLine("is null");
            }
        }
    }



}
