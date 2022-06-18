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
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
        }
        public string TextOnTheButton
        {
            get { return buttonText.Text; }
            set { buttonText.Text = value; }
        }
        public bool Checked { get; set; }
        static int EdgeSize = Properties.Resources.purplecustbuttonLEFTedge.Width;
        public void Normalizate()
        {
            buttonText.AutoSize = true;
            Width = EdgeSize * 2 + buttonText.Width;
            buttonText.AutoSize = false;
            pictureBoxLeftEdge.Image = Properties.Resources.graycustbuttonLEFTedge;
            pictureBoxRightEdge.Image = Properties.Resources.graycustbuttonRIGHTedge;
            buttonText.BackColor = Color.FromArgb(79, 100, 111);
        }
        private void MouseOnButton(object sender, EventArgs e)
        {
            if (!Checked)
            {
                pictureBoxLeftEdge.Image = Properties.Resources.purplecustbuttonLEFTedge;
                pictureBoxRightEdge.Image = Properties.Resources.purplecustbuttonRIGHTedge;
                buttonText.BackColor = Color.FromArgb(183, 173, 207);
            }
        }

        private void MouseLeaveButton(object sender, EventArgs e)
        {
            if (!Checked)
            {
                pictureBoxLeftEdge.Image = Properties.Resources.graycustbuttonLEFTedge;
                pictureBoxRightEdge.Image = Properties.Resources.graycustbuttonRIGHTedge;
                buttonText.BackColor = Color.FromArgb(79, 100, 111);
            }
        }
        public event EventHandler Clicked;
        private void buttonText_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            Clicked?.Invoke(sender,e);
        }
    }
}
