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
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
            DictionarymenuStrip.ForeColor = Color.White;
            customButton1.Clicked += new EventHandler(customButton2_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls["panel1"].Controls.Count; i++)
            {
                (Controls["panel1"].Controls[i] as CustomButton).Normalizate();
            }
            int x = 0;
            string[] strings = { "dkjfghjdgjdgd", "4568435enkjgdjhgsjerghewsf", "4598648ujgdfkgdghedrgfdgd", "54786y8ghdgkdhgjsdf" };
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                CustomButton btn = new CustomButton();
                btn.TextOnTheButton = strings[rnd.Next(0, strings.Length)];
                btn.Normalizate();
                x += Controls["panel1"].Controls[i].Width + 10;
                
                btn.Location = new Point(x, 3);
                Controls["panel1"].Controls.Add(btn);
            }

        }
        CustomButton SelectedButton = null;
        private void CheckIfCheckedExists(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < Controls["panel1"].Controls.Count; i++)
            {

                if ((Controls["panel1"].Controls[i] as CustomButton).Checked)
                {
                    counter++;
                    if (SelectedButton == null)
                    {
                        SelectedButton = (Controls["panel1"].Controls[i] as CustomButton);
                        break;
                    }
                    else if ((Controls["panel1"].Controls[i] as CustomButton) != SelectedButton)
                    {
                        panel1.Capture = false;
                        SelectedButton.Checked = false;
                        SelectedButton.Normalizate();
                        SelectedButton = (Controls["panel1"].Controls[i] as CustomButton);
                        break;
                    }
                }
              
            }
            if (counter == 0)
                SelectedButton = null;
        }


        private void customButton2_Click(object sender, EventArgs e)
        {
            button1.Enabled = !button1.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
