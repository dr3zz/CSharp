namespace WordDocumentGenerator
{
    using Novacode;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Drawing;
    class WordDocumentGenerator
    {


        private string fileName;
        private DocX doc;
        private string text;

        public string FileName
        {
            get { return this.fileName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename Cannot be empty", "Filename");
                }
                if (!value.Contains(".docx"))
                {
                    throw new FormatException("Filename must end with .docx");
                }
                this.fileName = value;
            }
        }

        public WordDocumentGenerator(string fileName)
        {
            this.FileName = fileName;
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            this.doc = DocX.Create(path);
            this.doc.Save();
            Console.WriteLine(path);
        }

        public void AddHeadline(string headline, string fontFamiliy = "Arial Black", double fontSize = 18D,
           int position = 12, string aligment = "left")
        {
            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily(fontFamiliy);
            headLineFormat.Size = fontSize;
            headLineFormat.Position = position;
            Paragraph title = this.doc.InsertParagraph(headline, false, headLineFormat);
            if (aligment == "center")
            {
                title.Alignment = Alignment.center;
            }
            else if (aligment == "right")
            {
                title.Alignment = Alignment.right;
            }
            else
            {
                title.Alignment = Alignment.left;
            }
            title.Alignment = Alignment.center;
            this.doc.Save();
        }
        public void AddParagraph(string paragraph, string fontFamiliy = "Arial", double fontSize = 8,
           int position = 0, string aligment = "left")
        {
            var paragprahFormat = new Formatting();
            paragprahFormat.FontFamily = new System.Drawing.FontFamily(fontFamiliy);
            paragprahFormat.Size = fontSize;
            paragprahFormat.Position = position;
            Paragraph title = this.doc.InsertParagraph(paragraph, false, paragprahFormat);
            if (aligment == "center")
            {
                title.Alignment = Alignment.center;
            }
            else if (aligment == "right")
            {
                title.Alignment = Alignment.right;
            }
            title.Alignment = Alignment.left;
            
            this.doc.Save();
        }
        public void AddText(string text, string fontFamiliy = "Arial")
        {
            var textFormat = new Formatting();
            textFormat.FontFamily = new System.Drawing.FontFamily(fontFamiliy);
            
            this.text += text;
           
        }

    }
}
