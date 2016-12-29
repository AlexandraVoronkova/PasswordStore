using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePassword
{
    public class FileStore
    {
        public List<Record> ListRecord = new List<Record>();
        public string PathFile { get; set; }
        public FileStore(string p)
        {
            PathFile = p;
            ListRecord = StoreLoadFromFile();
        }
        public void DeleteRecord(int indexRecord)
        {
            ListRecord.RemoveAt(indexRecord);
        }
        public void AddRecord(Record record)
        {
            ListRecord.Add(record);
        }
        public void ChangeRecord(int indexRecord, Record record)
        {
            ListRecord.Insert(indexRecord, record);
            ListRecord.RemoveAt(indexRecord + 1);
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
    }
}
