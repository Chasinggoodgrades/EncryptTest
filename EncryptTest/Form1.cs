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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Generate Button
            textBox1.Text = Generate.GeneratePassword();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Save As Button
            Save.SavePassword(textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Encrypt Button
        }
    }

    public class Encrypt
    {
        public static string EncryptString(string input)
        {
            // Encrypt the input string
            return input;
        }
    }

    public class Decrypt
    {
        public static string DecryptString(string input)
        {
            // Decrypt the input string
            return input;
        }
    }

    public class Generate
    {
        public static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@$&";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 12)
                             .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

    public class Save
    {
        public static void SavePassword(string password)
        {
            // Save the password to a file
            FileStream fileStream = new FileStream("password.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            streamWriter.Write(password);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }

}
