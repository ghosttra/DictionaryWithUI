using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DictionaryWithUI
{
    public partial class Dictionary : Form
    {
        List<Translate> translates = new List<Translate>();
        public Dictionary()
        {
            InitializeComponent();
            DictionarymenuStrip.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls["DictionariesPanel"].Controls.Count; i++)
            {
                (Controls["DictionariesPanel"].Controls[i] as CustomButton).Normalizate();
            }
            int x = 0;
            string[] strings = { "dkjfghjdgjdgd", "4568435enkjgdjhgsjerghewsf", "4598648ujgdfkgdghedrgfdgd", "54786y8ghdgkdhgjsdf" };
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                CustomButton btn = new CustomButton();
                //btn.TextOnTheButton = ;
                btn.Normalizate();
                btn.Clicked += new EventHandler(CheckIfCheckedExists);
                x += Controls["DictionariesPanel"].Controls[i].Width + 10;

                btn.Location = new Point(x, 3);
                Controls["DictionariesPanel"].Controls.Add(btn);
            }

        }
        CustomButton SelectedButton = null;
        private void CheckIfCheckedExists(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < Controls["DictionariesPanel"].Controls.Count; i++)
            {

                if ((Controls["DictionariesPanel"].Controls[i] as CustomButton).Checked)
                {
                    counter++;
                    if (SelectedButton == null)
                    {
                        SelectedButton = (Controls["DictionariesPanel"].Controls[i] as CustomButton);
                        break;
                    }
                    else if ((Controls["DictionariesPanel"].Controls[i] as CustomButton) != SelectedButton)
                    {
                        SelectedButton.Checked = false;
                        SelectedButton.Normalizate();
                        SelectedButton = (Controls["DictionariesPanel"].Controls[i] as CustomButton);
                        break;
                    }
                }

            }
            if (counter == 0)
                SelectedButton = null;
        }
        private void FirstLanguageTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Lines.Length > 7)
                (sender as TextBox).ScrollBars = ScrollBars.Vertical;
            else
                (sender as TextBox).ScrollBars = ScrollBars.None;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileDialog.FileName);
                Translate translate = new Translate();
                for (int i = 0; i < xmlDocument.DocumentElement.ChildNodes.Count; i++)
                {
                    for (int r = 0; r < xmlDocument.DocumentElement.ChildNodes[i].ChildNodes.Count; r++)
                    {
                        if (r == 2)
                        {
                            List<string> tempList = new List<string>();
                            for (int j = 0; j < xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes.Count; j++)
                            {
                               tempList.Add(xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes[j].InnerText);
                            }
                            translate.translates.Add(xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].ChildNodes[0].Name, tempList);
                            tempList = null;
                        }
                        else if (r == 0)
                            translate.Language = (xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].InnerText);
                        else if (r == 1)
                            translate.Word = (xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[r].InnerText);
                    }

                }
                translates.Add(translate);
            }

        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWordPanel.Visible = !AddWordPanel.Visible;
        }

        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            foreach (var tools in DictionarymenuStrip.Items)
            {
                (tools as ToolStripItem).ForeColor = Color.White;
            }
            (sender as ToolStripItem).ForeColor = Color.Black;
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            foreach (var tools in DictionarymenuStrip.Items)
            {
                (tools as ToolStripItem).ForeColor = Color.Gray;
            }
        }

        private void AddWordcustomButton_Clicked(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < Controls["DictionariesPanel"].Controls.Count; i++)
            {

                if ((Controls["DictionariesPanel"].Controls[i] as CustomButton).Checked)
                {
                    counter++;
                }
            }
            string text;
            counter == 0 ? MessageBox.Show() :
        }
    }
    class Translate
    {
        public string Language { get; set; }
        public string Word { get; set; }
        public Dictionary<string, List<string>> translates { get; set; } = new Dictionary<string, List<string>>();

        public Translate()
        {

        }
        public Translate(string language, string word, Dictionary<string, List<string>> translates)
        {
            Language = language;
            Word = word;
            this.translates = translates;
        }
    }
}
