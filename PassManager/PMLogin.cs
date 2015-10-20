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
        UnlockedForm _unlockedForm;

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
            safe.AddPassword("testusername1", "1234");
            safe.AddPassword("testusername2", "5678");
            safe.AddPassword("testusername3", "91011");

            LoginPasswordTextbox.Text = "boobies1";
           // safe.EncryptSafe();
           // safe.DecryptSafe();
            safe.WritePMFFile("Taylor Deiaco", "tayDeiaco");
            safe.LoadPMFFile("tayDeiaco.pmf", LoginPasswordTextbox.Text);

            _unlockedForm = new UnlockedForm(safe);
            _unlockedForm.Show();
        }

    }
}
