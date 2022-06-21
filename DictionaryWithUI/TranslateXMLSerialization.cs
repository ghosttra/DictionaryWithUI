using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;

namespace DictionaryWithUI
{
    static class TranslateXMLSerialization
    {
        public static void Save(List<Translate> translates)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "unicode", "yes"));
            XmlNode Dictionary = xmlDocument.CreateElement("Dictionary");
            xmlDocument.AppendChild(Dictionary);

            foreach (var item in translates)
            {
                XmlNode Translate = xmlDocument.CreateElement("Translate");
                Dictionary.AppendChild(Translate);
                XmlNode Language = xmlDocument.CreateElement("Language");
                Language.InnerText = item.Language;
                XmlNode Word = xmlDocument.CreateElement("Word");
                Word.InnerText = item.Word;
                Translate.AppendChild(Language);
                Translate.AppendChild(Word);
                XmlNode Translates = xmlDocument.CreateElement("Translates");
                foreach (var languages in item.translates.Keys)
                {
                    foreach(var word in item.translates[languages])
                    {
                        XmlNode ForeignLanguage = xmlDocument.CreateElement(languages.ToString());
                        ForeignLanguage.InnerText = word.ToString();
                        Translates.AppendChild(ForeignLanguage);
                    }   
                }
                Translate.AppendChild(Translates);
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XML Files (*.xml)|*.xml";
            var res = saveFile.ShowDialog();
            if (res == DialogResult.OK)
                xmlDocument.Save(saveFile.FileName);
        }
        public static void Load(List<Translate> translates)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter = "XML Files (*.xml)|*.xml";
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileDialog.FileName);
                for (int i = 0; i < xmlDocument.DocumentElement.ChildNodes.Count; i++)
                {
                    Translate translate = new Translate();
                    for (int r = 0; r < xmlDocument.DocumentElement.ChildNodes[i].ChildNodes.Count; r++)
                    {
                        if (r == 2)
                        {

                            for (int j = 0; j < xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes.Count; j++)
                            {
                                if (translate.translates.Keys.ToList().Find(pred => pred == xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes[j].Name) == null)
                                    translate.translates.Add(xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes[j].Name, new List<string>());
                                translate.translates[xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes[j].Name].Add(xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes[j].InnerText);
                            }
                        }
                        else if (r == 0)
                            translate.Language = (xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].InnerText);
                        else if (r == 1)
                            translate.Word = (xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].InnerText);
                    }
                    translates.Add(translate);
                }
            }
        }
    }
}
