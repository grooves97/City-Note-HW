using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlockNote
{
    public partial class SlackNote : Form
    {
        public SlackNote()
        {
            InitializeComponent();
        }

        private void textBoxDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char digit = e.KeyChar;

            if(!Char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
            }
        }
    }
}
