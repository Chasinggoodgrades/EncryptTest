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


namespace EncryptTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void GenerateButton(object sender, EventArgs e)
        {
            // Generate Button
            passwordBox.Text = Functions.GeneratePassword();
            var keyTuple = Functions.GenerateKey();
            actualSecretKeyBox.Text = keyTuple.Key;
            encryptedPWBox.Text = Functions.EncryptString(passwordBox.Text, keyTuple.ByteKey);
            determineSecretKeyBox.Text = Functions.FindKey(encryptedPWBox.Text);
        }

        private void SaveAsButton(object sender, EventArgs e)
        {
            // Save As Button
            Functions.SavePassword(passwordBox.Text);
        }

        private void EncryptButton(object sender, EventArgs e)
        {
            // Encrypt Button
            //actualSecretKeyBox.Text = Functions.GenerateKey();
            //encryptedPWBox.Text = Functions.EncryptString(passwordBox.Text);

        }

        private void FindKeyButton(object sender, EventArgs e)
        {
            determineSecretKeyBox.Text = Functions.FindKey(encryptedPWBox.Text);
        }
    }
}
