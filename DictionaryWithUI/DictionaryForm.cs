using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace DictionaryWithUI
{
    public partial class Dictionary : Form
    {
        private readonly List<string> formlanguages = new List<string>();
        private readonly List<Translate> translates = new List<Translate>();
        private readonly List<string> languages = new List<string> { "English", "French", "Italian", "Spanish", "Ukrainian", "Portugalian" };
        public Dictionary()
        {
            InitializeComponent();
            formlanguages.Add("Ukrainian");
            DictionarymenuStrip.ForeColor = Color.White;
            for (int i = 0; i < formlanguages.Count; i++)
            {
                languageToolStripMenuItem.DropDownItems.Add(formlanguages[i]);
                languageToolStripMenuItem.DropDownItems[i].Click += SetUALanguage;
            }
        }

        private void SetUALanguage(object sender, EventArgs e)
        {
            foreach (string language in formlanguages)
            {
                if ((sender as ToolStripItem).Text == language)
                {
                    fileToolStripMenuItem.Text = Properties.ua_pack.File;
                    dictionaryToolStripMenuItem.Text = Properties.ua_pack.Dictionary;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control v in Controls["DictionariesPanel"].Controls)
            {
                (v as CustomButton).Normalizate();
            }
            int x = 0;
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    CustomButton btn = new CustomButton();
            //    btn.TextOnTheButton = strings[i];
            //    btn.Normalizate();
            //    btn.Clicked += new EventHandler(CheckIfCheckedExists);
            //    x += Controls["DictionariesPanel"].Controls[i].Width + 10;

            //    btn.Location = new Point(x, 3);
            //    Controls["DictionariesPanel"].Controls.Add(btn);
            //}

        }
        public void SelectedButtonChanged()
        {
            if (SelectedButton != null)
            {
                string firstLanguage = SelectedButton.TextOnTheButton.Split('|')[0];
                if (AddWordPanel.Visible)
                {
                    FirstLanguageLabel.LabelText = firstLanguage;
                    ForeignLabel.LabelText = SelectedButton.TextOnTheButton.Split('|')[1];
                }
                if (WordsShowPanel.Visible)
                {
                    WordsFirstLanguage.Items.Clear();
                    TranslatedWords.Items.Clear();
                    List<Translate> wordlist = translates.Where(pred => pred.Language == firstLanguage).ToList();
                    for (int i = 0; i < wordlist.Count; i++)
                    {
                        WordsFirstLanguage.Items.Add(wordlist[i].Word);
                    }
                }
            }
        }

        private CustomButton SelectedButton = null;
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
                        SelectedButtonChanged();
                        break;
                    }
                    else if ((Controls["DictionariesPanel"].Controls[i] as CustomButton) != SelectedButton)
                    {
                        SelectedButton.Checked = false;
                        SelectedButton.Normalizate();
                        SelectedButton = (Controls["DictionariesPanel"].Controls[i] as CustomButton);
                        SelectedButtonChanged();
                        break;
                    }
                }

            }
            if (counter == 0)
            {
                SelectedButton = null;
                SelectedButtonChanged();
            }

        }
        private void FirstLanguageTextBox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).ScrollBars = (sender as TextBox).Lines.Length > 7 ? ScrollBars.Vertical : ScrollBars.None;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranslateXMLSerialization.Load(translates);
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DictionariesPanel.Controls.Count; i++)
            {
                (DictionariesPanel.Controls[i] as CustomButton).Checked = false;
                (DictionariesPanel.Controls[i] as CustomButton).Normalizate();
            }
            foreach (Control control in Controls)
                if (control is Panel && control != DictionariesPanel)
                    control.Visible = false;
            AddWordPanel.Visible = true;
        }

        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            foreach (ToolStripItem tools in DictionarymenuStrip.Items)
                tools.ForeColor = Color.White;
            (sender as ToolStripItem).ForeColor = Color.Black;
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            foreach (ToolStripItem tools in DictionarymenuStrip.Items)
                tools.ForeColor = Color.Gray;
        }
        public string MessageBoxText { get; set; } = "Please choose at LEAST one dictionary!";
        private void AddWordcustomButton_Clicked(object sender, EventArgs e)
        {
            AddWordcustomButton.Checked = false;
            int index = -1;
            for (int i = 0; i < Controls["DictionariesPanel"].Controls.Count; i++)
            {
                if ((Controls["DictionariesPanel"].Controls[i] as CustomButton).Checked)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                string thisLanguage = (Controls["DictionariesPanel"].Controls[index] as CustomButton).TextOnTheButton.Split('|')[0];
                Translate translate = new Translate();
                translate.Language = thisLanguage;
                translate.Word = FirstLanguageTextBox.Text;
                List<string> templist = new List<string> { TranslatedTextBox.Text };
                translate.translates.Add((Controls["DictionariesPanel"].Controls[index] as CustomButton).TextOnTheButton.Split('|')[1], templist);
                translates.Add(translate);
            }
            else
                MessageBox.Show(MessageBoxText, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DictionariesPanel.Controls.Count; i++)
            {
                (DictionariesPanel.Controls[i] as CustomButton).Checked = false;
                (DictionariesPanel.Controls[i] as CustomButton).Normalizate();
            }
            foreach (Control control in Controls)
            {
                if (control is Panel && control != DictionariesPanel)
                    control.Visible = false;
            }
            WordsShowPanel.Visible = true;
        }

        private void WordsFirstLanguage_Click(object sender, EventArgs e)
        {
            TranslatedWords.Items.Clear();
            var temporary = translates.FindAll(pred => pred.Language == SelectedButton.TextOnTheButton.Split('|')[0] && pred.translates.Keys.ToList().Find(pred1 => pred1 == SelectedButton.TextOnTheButton.Split('|')[1]) != null);
            if (temporary != null)
            {
                string key = SelectedButton.TextOnTheButton.Split('|')[1];
                for (int i = 0; i < temporary.Count; i++)
                {
                    if (temporary[i].translates.ContainsKey(key))
                    {
                        if (temporary[i].Word == WordsFirstLanguage.Text)
                        {
                            TranslatedWords.Items.AddRange(temporary[i].translates[key].ToArray());
                            break;
                        }
                    }
                }
            }

        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranslateXMLSerialization.Save(translates);
        }

        private void DictionarymenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        static int x = 0;
        public string messageAlertaddDictionary { get; set; }
        private void addDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDictionaryForm add = new AddDictionaryForm(languages);
            add.ShowDialog();
            foreach (var item in DictionariesPanel.Controls)
            {
                if ((item as CustomButton).TextOnTheButton == add.Dictionary)
                    MessageBox.Show(messageAlertaddDictionary, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    CustomButton btn = new CustomButton();
                    btn.TextOnTheButton = add.Dictionary;
                    btn.Normalizate();
                    btn.Clicked += new EventHandler(CheckIfCheckedExists);
                    x += DictionariesPanel.Controls[DictionariesPanel.Controls.Count-1].Width + 10;
                    btn.Location = new Point(x, 3);
                    DictionariesPanel.Controls.Add(btn);
                }
            }

        }
    }
    public class Translate
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
