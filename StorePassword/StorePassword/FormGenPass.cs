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
    public partial class FormGenPass : Form
    {
        public static int count;
        public FormGenPass()
        {
            InitializeComponent();
        }
        private void buttonGenPass_Click(object sender, EventArgs e)
        {
            PasswordGeneration PassGeneration = new PasswordGeneration();
            var password = PassGeneration.GetPass(count);
            textBox1.Text = password;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            count = trackBar1.Value;
            trackBar1.TickFrequency = 1;
            label1.Text = trackBar1.Value.ToString();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            FormRecord.strPass = this.textBox1.Text;
            this.Close();
        }
        private void buttonEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
