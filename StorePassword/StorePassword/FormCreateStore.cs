using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StorePassword
{
    public partial class FormCreateStore : Form
    {
        string filename;
        string password;
        public FormCreateStore()
        {
            InitializeComponent();
            saveFileDialog1.ShowDialog();
            filename = saveFileDialog1.FileName;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            password = maskedTextBoxPassword.Text; 
            this.Close();
        }

        private void FormCreateStore_Load(object sender, EventArgs e)
        {
            Form1 f2 = (Form1)this.Owner;
            System.IO.Stream stream = System.IO.File.Create(filename);
            stream.Close();
            textBoxPathFile.Text = filename;
        }

    }
}
