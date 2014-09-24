using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML_Dispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementBuilder div =
      new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div*5);
            string img = HTMLDispacher.CreateImage("imange","cars","img");
            Console.WriteLine(img);
            

            
        }
    }
}
