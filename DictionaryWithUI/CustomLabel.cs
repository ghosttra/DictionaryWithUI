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
    public partial class CustomLabel : UserControl
    {
        public CustomLabel()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get { return labeltext.Text; }
            set { labeltext.Text = value; }
        }
    }
}
