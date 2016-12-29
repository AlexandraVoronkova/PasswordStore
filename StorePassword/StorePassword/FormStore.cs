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
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace StorePassword
{
    public partial class FormStore : Form
    {
        FileStore fileStore;
        string password;
        public FormStore(string pathFile, string password)
        {
            InitializeComponent();
            fileStore = new FileStore(pathFile);
            dataGridView1.DataSource = this.fileStore.ListRecord;
            this.password = password;
        }
        public string copy = "";
        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rows = dataGridView1.SelectedRows[0];
                copy = rows.Cells[2].Value.ToString();
                Clipboard.SetText(copy);
            }
            catch
            {
                MessageBox.Show("Ошибка! Запись пуста");
            }
        }
        private void nameUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rows = dataGridView1.SelectedRows[0];
                copy = rows.Cells[1].Value.ToString();
                Clipboard.SetText(copy);
            }
            catch
            {
                MessageBox.Show("Ошибка! Запись пуста");
            }
        }
        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecord f3 = new FormRecord();
            f3.Owner = this;
            f3.ShowDialog();
            this.fileStore.AddRecord(f3.record);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.fileStore.ListRecord;
        }
        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecord f3 = new FormRecord();
            f3.Owner = this;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            f3.textBox1.Text = row.Cells[0].Value.ToString();
            f3.textBox2.Text = row.Cells[1].Value.ToString();
            f3.textBox3.Text = row.Cells[2].Value.ToString();
            f3.ShowDialog();
            int index = dataGridView1.CurrentRow.Index;
            this.fileStore.ChangeRecord(index, f3.record);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.fileStore.ListRecord;
        }
        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            this.fileStore.DeleteRecord(index);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.fileStore.ListRecord;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(this.fileStore.PathFile))
            {
                for (int i = 0; i < this.fileStore.ListRecord.Count; i++)
                {
                    writer.Write(this.fileStore.ListRecord[i].NameRecord);
                    writer.Write('#');
                    writer.Write(this.fileStore.ListRecord[i].Login);
                    writer.Write('#');
                    writer.Write(this.fileStore.ListRecord[i].Password);
                    writer.WriteLine();
                }
            }
            CryptoProvadercs crypto = new CryptoProvadercs();
            crypto.Encrypt(this.password, this.fileStore.PathFile);
        }
    }
}
