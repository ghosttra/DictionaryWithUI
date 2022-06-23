using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryWithUI
{
    public partial class AddDictionaryForm : Form
    {
        public AddDictionaryForm(List<string> languages)
        {
            InitializeComponent();
            foreach (var combbox in this.Controls)
            {
                if (combbox is ComboBox)
                {
                    (combbox as ComboBox).Items.AddRange(languages.ToArray());
                }
            }
        }
        static int timesComboBoxWasChanged = 0;
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            timesComboBoxWasChanged++;
            if (timesComboBoxWasChanged > 2)
            {
                timesComboBoxWasChanged = 1;
                NewDictionaryLabel.LabelText = "";
                secondLanguageCombBox.Text = "";
            }
            if (NewDictionaryLabel.LabelText.Length != 0)
            {
                NewDictionaryLabel.LabelText += "|";
            }
            NewDictionaryLabel.LabelText += (sender as ComboBox).Text;
            NewDictionaryLabel.Normalizate();
            NewDictionaryLabel.Location = new Point((Width - NewDictionaryLabel.Width) / 2, NewDictionaryLabel.Location.Y);
            secondLanguageCombBox.Enabled = !secondLanguageCombBox.Enabled;
            firstLanguageCombBox.Enabled = !firstLanguageCombBox.Enabled;
            if (firstLanguageCombBox.Text == secondLanguageCombBox.Text)
            {
                foreach (var combbox in this.Controls)
                    if (combbox is ComboBox)
                        (combbox as ComboBox).Text = "";
                NewDictionaryLabel.LabelText = "";
                secondLanguageCombBox.Enabled = false;
                firstLanguageCombBox.Enabled = true;
            }
           
        }
        public string Dictionary { get; set; }
        private void AddDictionaryBtn_Clicked(object sender, EventArgs e)
        {
            if (NewDictionaryLabel.LabelText.Contains("|"))
            {
                Dictionary = NewDictionaryLabel.LabelText;
                Close();
            }
                
        }
    }
}
