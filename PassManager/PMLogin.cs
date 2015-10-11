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
    public partial class Splash : Form
    {

        Safe safe;

        public Splash()
        {
            InitializeComponent();
            safe = new Safe("boobies1");
        }


        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create and show NewAccount dialog
            NewAccount new_account = new NewAccount(safe);
            new_account.Show();
        }

        private void PMLoginButton_Click(object sender, EventArgs e)
        {
            safe = new Safe("boobies1");
            safe.AddPassword("fartnuggets", "1234");
            safe.AddPassword("ballsack", "1234");
            safe.AddPassword("Wilzniac", "1234");


           // safe.EncryptSafe();
           // safe.DecryptSafe();
            safe.WritePMFFile("Taylor Deiaco", "tayDeiaco");
            safe.LoadAccount("tayDeiaco", "password");
        }

    }
}
