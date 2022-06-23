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
                    translatorToolStripMenuItem.Text = Properties.ua_pack.Translator;
                    vievToolStripMenuItem.Text = Properties.ua_pack.View;
                    openToolStripMenuItem.Text = Properties.ua_pack.Open;
                    saveToolStripMenuItem.Text = Properties.ua_pack.Save;
                }
            }
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
                    var word = translates.FindAll(pred => pred.Language == SelectedButton.TextOnTheButton.Split('|')[0] && translates.FindAll(pred1 => pred1.translates.ContainsKey(SelectedButton.TextOnTheButton.Split('|')[1])).Count != 0);
                    if (word != null)
                        foreach (var i in word)
                            WordsFirstLanguage.Items.Add(i.Word);
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
            translates.Clear();
            DictionariesPanel.Controls.Clear();
            x = 0;
            TranslateXMLSerialization.Load(translates);
            foreach (var translate in translates)
            {
                foreach (var languages in translate.translates.Keys)
                {
                    if (DictionariesPanel.Controls.Count > 0)
                    {
                        for (int i = 0; i < DictionariesPanel.Controls.Count; i++)
                            if (translate.Language + '|' + languages != (DictionariesPanel.Controls[i] as CustomButton).TextOnTheButton)
                                AddNewBtn(translate.Language + '|' + languages);
                            else break;
                    }
                    else
                        AddNewBtn(translate.Language + '|' + languages);
                }
            }
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
            if (FirstLanguageTextBox.Text != "" && TranslatedTextBox.Text != "")
            {
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
                    List<string> templist = new List<string> { TranslatedTextBox.Text };
                    string thisLanguage = (Controls["DictionariesPanel"].Controls[index] as CustomButton).TextOnTheButton.Split('|')[0];
                    var temporarytranslate = translates.Find(pred => pred.Language == thisLanguage && pred.Word == FirstLanguageTextBox.Text);
                    if (temporarytranslate != null)
                    {
                        try
                        {
                            temporarytranslate.translates.Add((Controls["DictionariesPanel"].Controls[index] as CustomButton).TextOnTheButton.Split('|')[1], templist);
                        }
                        catch (Exception)
                        {
                            temporarytranslate.translates[(Controls["DictionariesPanel"].Controls[index] as CustomButton).TextOnTheButton.Split('|')[1]].Add(TranslatedTextBox.Text);
                        }
                    }
                    else
                    {
                        Translate translate = new Translate();
                        translate.Language = thisLanguage;
                        translate.Word = FirstLanguageTextBox.Text;
                        translate.translates.Add((Controls["DictionariesPanel"].Controls[index] as CustomButton).TextOnTheButton.Split('|')[1], templist);
                        translates.Add(translate);
                    }
                    MessageBox.Show("Word added!");
                }
                else
                    MessageBox.Show(MessageBoxText, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
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
            TranslatedWords.SelectedIndex = -1;
            TranslatedWords.Items.Clear();
            if (SelectedButton != null)
            {
                var temporary = translates.FindAll(pred => pred.Language == SelectedButton.TextOnTheButton.Split('|')[0] && pred.translates.Keys.ToList().Find(pred1 => pred1 == SelectedButton.TextOnTheButton.Split('|')[1]) != null);
                if (temporary.Count > 0)
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
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (translates.Count < 1) return;
            TranslateXMLSerialization.Save(translates);
        }

        static int x = 0;
        public string messageAlertaddDictionary { get; set; }
        private void AddNewBtn(string TextOnTheButton)
        {
            CustomButton btn = new CustomButton();
            btn.TextOnTheButton = TextOnTheButton;
            btn.Normalizate();
            btn.Clicked += new EventHandler(CheckIfCheckedExists);
            if (DictionariesPanel.Controls.Count != 0)
                x += DictionariesPanel.Controls[DictionariesPanel.Controls.Count - 1].Width + 10;
            btn.Location = new Point(x, 3);
            DictionariesPanel.Controls.Add(btn);
        }
        private void addDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDictionaryForm add = new AddDictionaryForm(languages);
            add.ShowDialog();
            if (add.Dictionary != null)
            {
                if (DictionariesPanel.Controls.Count == 0)
                {
                    AddNewBtn(add.Dictionary);
                }
                else
                    foreach (var item in DictionariesPanel.Controls)
                    {
                        if ((item as CustomButton).TextOnTheButton == add.Dictionary)
                            MessageBox.Show(messageAlertaddDictionary, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            AddNewBtn(add.Dictionary);
                            break;
                        }
                    }
                Translate translate = new Translate(add.Dictionary.Split('|')[0], "", new Dictionary<string, List<string>> { { add.Dictionary.Split('|')[1], new List<string>() { "" } } });
                translates.Add(translate);
            }

        }
        string deleteDictionaryErrorMessage = "Please, choose a dictionary!";
        private void deleteDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedButton != null)
            {
                var keys = translates.FindAll(pred => pred.Language == SelectedButton.TextOnTheButton.Split('|')[0] && translates.FindAll(pred1 => pred1.translates.ContainsKey(SelectedButton.TextOnTheButton.Split('|')[1])).Count != 0);
                if (keys.Count != 0)
                {
                    foreach (var key in keys)
                    {
                        int index = translates.FindIndex(pred => pred == key);
                        translates[index].translates.Remove(SelectedButton.TextOnTheButton.Split('|')[1]);
                        if (translates[index].translates.Count == 0)
                        {
                            translates.Remove(key);
                        }
                    }
                }
                if (DictionariesPanel.Controls.Count > 1)
                    DictionariesPanel.Controls.Remove(SelectedButton);
            }
            else
                MessageBox.Show(deleteDictionaryErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeletewordBtn_Clicked(object sender, EventArgs e)
        {
            foreach (var item in WordsShowPanel.Controls)
            {
                if (item is ListBox)
                {
                    if ((item as ListBox).SelectedIndex != -1 && (item as ListBox).Tag.ToString() == "1")
                    {
                        translates.Remove(translates.Find(pred => pred.Word == (item as ListBox).SelectedItem.ToString()));
                        (item as ListBox).Items.Remove((item as ListBox).SelectedItem);
                        break;
                    }
                    else if ((item as ListBox).SelectedIndex != -1 && (item as ListBox).Tag.ToString() == "2")
                    {
                        var a = translates.Find(pred => pred.Word == WordsFirstLanguage.SelectedItem.ToString());
                        translates.Find(pred => pred == a).translates[SelectedButton.TextOnTheButton.Split('|')[1]].Remove((item as ListBox).SelectedItem.ToString());
                        break;
                    }
                }
            }
            WordsFirstLanguage_Click(sender, e);
            DeletewordBtn.Checked = false;
        }

        private void exportWordToSeparateFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Translate translate = new Translate();
            if (SelectedButton != null)
            {
                if (WordsFirstLanguage.SelectedItem != null)
                {
                    translate.Word = WordsFirstLanguage.SelectedItem.ToString();
                    translate.Language = SelectedButton.TextOnTheButton.Split('|')[0];
                    translate.translates = translates[translates.IndexOf(translates.Find(p => p.Word == translate.Word))].translates;
                    var sfd = new SaveFileDialog();
                    sfd.Filter = "txt files (*.txt)|*.txt";
                    sfd.FileName = translate.Word + ".txt";
                    sfd.ShowDialog();
                    string path = sfd.FileName;
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine($"The word: {WordsFirstLanguage.SelectedItem} | {translate.Language}\nTranslates into:");
                        foreach (var item in translate.translates)
                        {
                            foreach (var item1 in item.Value)
                                sw.WriteLine($"{item1} | {item.Key}");
                        }

                    }
                }
            }
        }

        private void FindWordTextBox_TextChanged(object sender, EventArgs e)
        {
            ResultComboBox.Items.Clear();
            if (FindWordTextBox.Text.Length > 0)
            {
                foreach (var i in translates.FindAll(pred => pred.Word == FindWordTextBox.Text))
                {
                    var list = i.translates.Values.ToList();
                    foreach (var l in list)
                    {
                        ResultComboBox.Items.AddRange(l.ToArray());
                    }
                }
            }
        }

        private void Dictionary_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Do you want to save your dictionary?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
                TranslateXMLSerialization.Save(translates);
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

