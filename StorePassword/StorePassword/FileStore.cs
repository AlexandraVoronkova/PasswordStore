using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace StorePassword
{
    public class FileStore : Store
    {
        private string pathFile;

        public override string PathFile
        {
            get
            {
                return pathFile;
            }
            set
            {
                pathFile = value;
            }
        }
        public FileStore(string p)
        {
            PathFile = p;
            ListRecord = StoreLoadFromFile();
        }
        public override void DeleteRecord(int indexRecord)
        {
            ListRecord.RemoveAt(indexRecord);
        }
        public override void AddRecord(Record record)
        {
            ListRecord.Add(record);
        }
        public override void ChangeRecord(int indexRecord, Record record)
        {
            ListRecord.Insert(indexRecord, record);
            ListRecord.RemoveAt(indexRecord + 1);
        }
        public override void EncryptStore(string password)
        {
            CryptoProviderAES crypto = new CryptoProviderAES();
            BinaryReader inStream = new BinaryReader(new FileStream(pathFile, FileMode.Open));
            byte[] text = inStream.ReadBytes((int)inStream.BaseStream.Length);
            inStream.Close();
            MemoryStream ms = new MemoryStream();
            MemoryStream msFrom = new MemoryStream(text);
            crypto.Encrypt(password, msFrom, ms);
            System.IO.File.WriteAllBytes(pathFile, ms.ToArray());
        }
        public List<Record> StoreLoadFromFile()
        {
            string[] arr = System.IO.File.ReadAllLines(this.PathFile);
            List<Record> ListRecord = new List<Record>();
            for (int i = 0; i < arr.Length; i++)
            {
                Record record = new Record();
                string[] str = arr[i].Split("#".ToCharArray());
                record.NameRecord = str[0];
                record.Login = str[1];
                record.Password = str[2];
                ListRecord.Add(record);
            }
            return ListRecord;
        }
        public override void StoreInputFile(string password)
        {
            using (StreamWriter writer = new StreamWriter(this.PathFile))
            {
                for (int i = 0; i < this.ListRecord.Count; i++)
                {
                    writer.Write(this.ListRecord[i].NameRecord);
                    writer.Write('#');
                    writer.Write(this.ListRecord[i].Login);
                    writer.Write('#');
                    writer.Write(this.ListRecord[i].Password);
                    writer.WriteLine();
                }
            }
            EncryptStore(password);
        }
    }
}
