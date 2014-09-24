using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTML_Dispatcher
{
    public static class HTMLDispacher
    {
        private const string TAG_IMAGE = "img";
        private const string TAG_URL = "a";
        private const string TAG_INPUT = "input";

        private const string ATTR_SOURCE = "src";
        private const string ATTR_TITLE = "title";
        private const string ATTR_ALT = "alt";
        private const string ATTR_TEXT = "text";
        private const string ATTR_URL = "href";
        private const string ATTR_TYPE = "type";
        private const string ATTR_NAME = "name";
        private const string ATTR_VALUE = "value";

        public static string CreateImage(string source, string title, string alt)
        {
            ElementBuilder elementBuilder = new ElementBuilder(TAG_IMAGE);
            elementBuilder.AddAttribute(ATTR_SOURCE, source);
            elementBuilder.AddAttribute(ATTR_ALT, alt);
            elementBuilder.AddAttribute(ATTR_TITLE, title);

            return elementBuilder.ToString();
        }
        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder elementBuilder = new ElementBuilder(TAG_URL);
            elementBuilder.AddAttribute(ATTR_URL, url);
            elementBuilder.AddAttribute(ATTR_TITLE, title);
            elementBuilder.AddAttribute(ATTR_TEXT, text);

            return elementBuilder.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder elementBuilder = new ElementBuilder(TAG_INPUT);
            elementBuilder.AddAttribute(ATTR_TYPE, type);
            elementBuilder.AddAttribute(ATTR_NAME, name);
            elementBuilder.AddAttribute(ATTR_VALUE, value);

            return elementBuilder.ToString();
        }
    }
}
