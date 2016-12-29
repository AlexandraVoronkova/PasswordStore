using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorePassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonOpenStore_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBoxPathFile.Text = openFileDialog1.FileName;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            CryptoProvadercs crypto = new CryptoProvadercs();
            crypto.Decrypt(password, textBoxPathFile.Text);
            Form f2 = new FormStore(textBoxPathFile.Text, password);
            f2.ShowDialog();
        }
        private void buttonCreateStore_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.Stream stream = System.IO.File.Create(filename);
            stream.Close();
            string password = textBoxPassword.Text;
            Form f2 = new FormStore(filename, password);
            f2.ShowDialog();
        }
    }
}
