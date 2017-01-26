using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StorePassword;

namespace PasswordTests
{
    public class PasswordGenertionTests
    {
        [Test]
        public void GetPassLen7()
        {
            //Arrange настроить все, что необходимо
            int len = 7;
            int expected = 7;
            //Act выполнить действия над системой которую тестируем
            PasswordGeneration passGener = new PasswordGeneration();
            string password = passGener.GetPass(len);
            int actual = password.Length;
            //Assert проверить правильно ли закончилась работа системы или нет
            Assert.AreEqual(expected, actual);
        }
    }
    public class FileStoreTests
    {
        [Test]
        public void CreateFileStore()
        {
            Store store = new FileStore("4.txt");
            Assert.IsNotNull(store);
        }
        [Test]
        public void CreateRecord()
        {
            Record record = new Record();
            Assert.IsNotNull(record);
        }
        Store store;
        Record record;
        [SetUp]
        public void BeforeTests()
        {
            store = new FileStore("4.txt");
            record = new Record();
            record.Login = "login";
            record.NameRecord = "name";
            record.Password = "passw";
        }
        [Test]
        public void AddRecordList()
        {
            store.AddRecord(record);
            Assert.IsTrue(store.ListRecord.Count == 1);
        }
        [Test]
        public void DeleteRecordList()
        {
            store.AddRecord(record);
            store.DeleteRecord(0);
            Assert.IsTrue(store.ListRecord.Count == 0);
        }
        [Test]
        public void ChangeRecordList()
        {
            store.AddRecord(record);
            Record record1 = new Record();
            record1.Login = "login1";
            record1.NameRecord = "name1";
            record1.Password = "passw1";
            int expected = store.ListRecord.Count;
            store.ChangeRecord(0, record1);
            int actual = store.ListRecord.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}

