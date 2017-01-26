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
            string password = maskedTextBox1.Text;
            try
            {
                CryptoProviderAES crypto = new CryptoProviderAES();
                BinaryReader inStream = new BinaryReader(new FileStream( textBoxPathFile.Text, FileMode.Open));
                byte[] text = inStream.ReadBytes((int)inStream.BaseStream.Length);
                inStream.Close();
                MemoryStream ms = new MemoryStream();
                MemoryStream msFrom = new MemoryStream(text);
                crypto.Decrypt(password,msFrom,ms);
                Console.WriteLine(BitConverter.ToString(ms.ToArray()));
                System.IO.File.WriteAllBytes(textBoxPathFile.Text, ms.ToArray());
            }
            catch
            {
                MessageBox.Show("Неверный пароль");
                return;
            }
            Form f2 = new FormStore(textBoxPathFile.Text, password);
            f2.ShowDialog();
        }
        private void buttonCreateStore_Click(object sender, EventArgs e)
        {
            FormCreateStore create = new FormCreateStore();
            create.Owner = this;
            create.ShowDialog();
        }
    }
}
