using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PassManager
{
    //*********************
    // File formate ideas:
    //
    public partial class NewAccount : Form
    {
        Safe safe;
        public NewAccount(Safe safe)
        {
            this.safe = safe;
            InitializeComponent();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            //TODO: Create new encrypted SQL database and save the file. Use the 
            //filename to access the user account.

            
         /*   safe.AddPassword(NewAccountUsernameTextbox.Text.ToString() +
                             NewAccountPasswordTextbox.Text.ToString());

            safe.EncryptSafe(NewAccountPasswordTextbox.Text.ToString());
            safe.DecryptSafe(NewAccountPasswordTextbox.Text.ToString()); */

            safe.CreateAccount(NewAccountAccountNameTextbox.Text.ToString(),
                                NewAccountUsernameTextbox.Text.ToString(),
                                NewAccountPasswordTextbox.Text.ToString());


        }


    }
}
