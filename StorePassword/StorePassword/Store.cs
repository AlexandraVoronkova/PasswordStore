using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePassword
{
    abstract public class Store
    {
        public List<Record> ListRecord = new List<Record>();
        abstract public void DeleteRecord(int indexRecord);
        abstract public void AddRecord(Record record);
        abstract public void ChangeRecord(int indexRecord, Record record);
        abstract public void StoreInputFile(string password);
        abstract public void EncryptStore(string keyCrypto);
        public virtual string PathFile { get; set; }
    }
}
