using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DictionaryWithUI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "unicode", "yes"));
            //XmlNode Dictionary = xmlDocument.CreateElement("Dictionary");
            //XmlNode Translate = xmlDocument.CreateElement("Translate");
            //xmlDocument.AppendChild(Dictionary);
            //Dictionary.AppendChild(Translate);
            //XmlNode Language = xmlDocument.CreateElement("Language");
            //Language.InnerText = "English";
            //XmlNode Word = xmlDocument.CreateElement("Word");
            //Word.InnerText = "Word";
            //Translate.AppendChild(Language);
            //Translate.AppendChild(Word);
            //XmlNode Translates = xmlDocument.CreateElement("Translates");
            //XmlNode Ukrainian = xmlDocument.CreateElement("Ukrainian");
            //Ukrainian.InnerText = "Слово";
            //XmlNode Ukrainian1 = xmlDocument.CreateElement("Ukrainian");
            //Ukrainian1.InnerText = "Словечко";
            //Translates.AppendChild(Ukrainian);
            //Translates.AppendChild(Ukrainian1);
            //Translate.AppendChild(Translates);

            //xmlDocument.Save("Dictionary.xml");
            //xmlDocument = null;
            //xmlDocument = new XmlDocument();

            //xmlDocument.Load("Dictionary.xml");
            //List<string> strings = new List<string>();
            //for (int i = 0; i < xmlDocument.DocumentElement.ChildNodes.Count; i++)
            //{
            //    for (int r = 0; r < xmlDocument.DocumentElement.ChildNodes[i].ChildNodes.Count; r++)
            //    {
            //        if (r == 2)
            //        {
            //            for (int j = 0; j < xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes.Count; j++)
            //            {
            //                strings.Add(xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes[j].InnerText);
            //            }
            //        }
            //        else
            //            strings.Add(xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].InnerText);
            //    }

            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dictionary());
        }
    }
}
