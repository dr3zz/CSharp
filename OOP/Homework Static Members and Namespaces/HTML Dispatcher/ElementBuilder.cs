using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML_Dispatcher
{
    class ElementBuilder
    {
        private string name;
        private string content;
        private List<string> atributes;

        public string ElementName
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid html element");
                }
                this.name = value;
            }
        }
        public ElementBuilder(string element)
        {
            atributes = new List<string>();
            this.ElementName = element.ToLower();
        }

        public void AddAttribute(string atrtibute, string value)
        {
            if (String.IsNullOrWhiteSpace(atrtibute) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input", "ADD Attributes");
            }
            this.atributes.Add(atrtibute + "=\"" + value + "\"");
            
        }
        public void AddContent(string content)
        {
            if (String.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Invalid input", "ADD Content");
            }
            this.content = content;
        }
        public static string operator *(ElementBuilder element, int value)
        {

            string ret = "";
            for (int i = 0; i < value; i++)
            {
                ret += element.ToString();
            }
            return ret;
        }

        
        public override string ToString()
        {
            string element = "";
            string atribute = "";
            foreach (string x in atributes)
            {
                atribute += x;
            }
            element = "<" + ElementName + " " + atribute + ">" + content + "</" + name + ">";
            return element;

        }
    }
}