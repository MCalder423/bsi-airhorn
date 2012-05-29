using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirhornSoundEditor
{
    public partial class dlgAssignKey : Form
    {
        public Keys AssignedKey;

        public dlgAssignKey()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dlgAssignKey_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dlgAssignKey_KeyUp(object sender, KeyEventArgs e)
        {
            AssignedKey = e.KeyData;
            this.Close();
        }
    }
}
