using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager
{
    public partial class AddPasswordForm : Form
    {
        Safe _safe;

        public Safe Safe
        {
            get { return _safe; }
            set { _safe = value; }
        }

        public AddPasswordForm()
        {
            InitializeComponent();
        }

        public AddPasswordForm(Safe s)
        {
            _safe = s;
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _safe.AddPassword(new UserPassPair(NewPasswordUsername_textbox.Text, NewPasswordPassword_textbox.Text));

        }
    }
}
