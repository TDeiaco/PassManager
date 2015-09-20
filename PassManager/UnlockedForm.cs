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
    public partial class UnlockedForm : Form
    {
        public UnlockedForm()
        {
            InitializeComponent();
        }

        private void UnlockedForm_Load(object sender, EventArgs e)
        {
            //Extract all password items and add to the UnlockedForm
            //listview
            ListViewItem newItem1 = new ListViewItem();
            ListViewItem newItem2 = new ListViewItem();
            ListViewItem newItem3 = new ListViewItem();
            newItem1.Text = "New Item 1";
            newItem2.Text = "New Item 2";
            newItem3.Text = "New Item 3";
            passwords_list.Items.Add(newItem1);
            passwords_list.Items.Add(newItem2);
            passwords_list.Items.Add(newItem3);
        }

        private void passwords_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Open the add password dialog
            AddPasswordForm addPassword = new AddPasswordForm();
            addPassword.Show();
        }
    }
}
