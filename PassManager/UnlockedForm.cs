using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassManager;

namespace PassManager
{
    public partial class UnlockedForm : Form
    {

        Safe _accountSafe;

        public Safe AccountSafe
        {
            get { return _accountSafe; }
            set { _accountSafe = value; }
        }
        
        public UnlockedForm()
        {
            //safe = new Safe();
            InitializeComponent();
        }


        public UnlockedForm(Safe s)
        {
            _accountSafe = new Safe();
            _accountSafe = s;
            InitializeComponent();
        }

        private void UnlockedForm_Load(object sender, EventArgs e)
        {
            //Extract all password items and add to the UnlockedForm
            //listview
            foreach(UserPassPair userPass in _accountSafe.Bank)
            {
                ListViewItem newPass = new ListViewItem();
                newPass.Text = userPass.Username + "       " + userPass.Password;
                passwords_list.Items.Add(newPass);

            }
        }

        private void passwords_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Open the add password dialog
            AddPasswordForm addPassword = new AddPasswordForm(_accountSafe);
            addPassword.Show();

            ListViewItem newPass = new ListViewItem();
            newPass.Text = _accountSafe.Bank[_accountSafe.Bank.Count -1].Username + "       " + _accountSafe.Bank[_accountSafe.Bank.Count -1].Password;
            passwords_list.Items.Add(newPass);
        }
    }
}
