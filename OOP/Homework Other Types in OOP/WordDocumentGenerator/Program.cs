using Novacode;
using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
 
namespace WordDocumentGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Document.docx";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            using (var doc = DocX.Create(path))
            {
                string title = "SoftUni OOP Game Contest";
                var titleFormat = new Formatting();
                titleFormat.FontFamily = new FontFamily("Arial");
                titleFormat.Bold = true;
                titleFormat.Size = 28D;
                Paragraph header = doc.InsertParagraph(title,false,titleFormat);
                header.Alignment = Alignment.center;
                string picName = "rpg-game.png";
                Picture pic = doc.AddImage(Path.Combine(Environment.CurrentDirectory,picName)).CreatePicture();
                Paragraph image = doc.InsertParagraph("", false);
                pic.Height = 250;
                pic.Width = 600;
                image.InsertPicture(pic);
                doc.InsertParagraph("", false);
                Paragraph text = doc.InsertParagraph("", false);
                text.Append("SoftUni is organizing a contest for the best");
                text.Append("role playing game").Bold();
                text.Append("from the OOP teamwork projects. The winning teams will receive a");
                text.Append("grand prize! ").Bold();
                text.AppendLine("The game should be:");
                var test = new Formatting();
                var testFor = new Formatting();
                
                
                var myList = doc.AddList("",0,ListItemType.Bulleted);
              
                doc.AddListItem(myList, "Properly structured and follow all good OOP practices",3);
                doc.AddListItem(myList, "Awesome",3);
                doc.AddListItem(myList, "..Very Awesome",3); 
                doc.InsertList(myList);
                
                doc.Save();
            }
        }
    }
}
