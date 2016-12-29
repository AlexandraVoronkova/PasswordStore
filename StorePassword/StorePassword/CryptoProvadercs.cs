using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace StorePassword
{
    class CryptoProvadercs
    {
        const int keyAESLen = 16;
        byte[] keyAES = new byte[keyAESLen];
        public void Encrypt(string passw, string pathFile)
        {
            Encoding enc = Encoding.Unicode;
            SHA512 sha = new SHA512Managed();
            byte[] key = sha.ComputeHash(enc.GetBytes(passw));
            byte[] iv ={
                          0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07,
                          0x08, 0x09,0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x00
                       };
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = (byte[])key.Take(aes.BlockSize / 8).ToArray();
            aes.Mode = CipherMode.CFB;
            aes.IV = (byte[])iv.ToArray();
            BinaryReader inStream = new BinaryReader(new FileStream(pathFile, FileMode.Open));
            byte[] text = inStream.ReadBytes((int)inStream.BaseStream.Length);
            inStream.Close();
            FileStream f = new FileStream(pathFile, FileMode.Open);
            CryptoStream csEncrypt = new CryptoStream(f, aes.CreateEncryptor(), CryptoStreamMode.Write);
            BinaryWriter outStream = new BinaryWriter(csEncrypt);
            outStream.Write(text);
            outStream.Close();
            csEncrypt.Close();
        }

        public void Decrypt(string passw, string pathFile)
        {
            Encoding enc = Encoding.Unicode;
            SHA512 sha = new SHA512Managed();
            byte[] key = sha.ComputeHash(enc.GetBytes(passw));
            byte[] iv ={
                          0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07,
                          0x08, 0x09,0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x00
                      };
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = (byte[])key.Take(aes.BlockSize / 8).ToArray();
            aes.Mode = CipherMode.CFB;
            aes.IV = (byte[])iv.ToArray();
            BinaryReader inStream = new BinaryReader(new FileStream(pathFile, FileMode.Open));
            byte[] text = inStream.ReadBytes((int)inStream.BaseStream.Length);
            inStream.Close();
            FileStream f = new FileStream(pathFile, FileMode.Create);
            CryptoStream csEncrypt = new CryptoStream(f, aes.CreateDecryptor(), CryptoStreamMode.Write);
            BinaryWriter outStream = new BinaryWriter(csEncrypt);
            outStream.Write(text);
            outStream.Close();
            csEncrypt.Close();
        }
    }
}
