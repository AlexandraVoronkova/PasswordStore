using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace StorePassword
{
    class CryptoProviderAES : CryptoProvider
    {
        const int keyAESLen = 16;
        byte[] keyAES = new byte[keyAESLen];
        public Stream Encrypt(string passw, Stream fromStream, Stream toStream)
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
            CryptoStream csEncrypt = new CryptoStream(toStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
            BinaryWriter outStream = new BinaryWriter(csEncrypt);
            BinaryReader inStream = new BinaryReader(fromStream);
            byte[] text = inStream.ReadBytes((int)inStream.BaseStream.Length);
            inStream.Close();
            outStream.Write(text);
            csEncrypt.Close();
            return toStream;
        }

        public byte[] Encrypt(string passw, byte[] text)
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
            MemoryStream m = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(m, aes.CreateEncryptor(), CryptoStreamMode.Write);
            BinaryWriter outStream = new BinaryWriter(csEncrypt);
            outStream.Write(text);

            m.Position = 0;
            byte[] data = new byte[m.Length];
            m.Read(data, 0, (int)data.Length);
            outStream.Close();
            csEncrypt.Close();
            return data;
        }

        public Stream Decrypt(string passw, Stream fromStream, Stream toStream)
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
            BinaryReader inStream = new BinaryReader(fromStream);
            byte[] text = inStream.ReadBytes((int)inStream.BaseStream.Length);
            inStream.Close();

            CryptoStream csEncrypt = new CryptoStream(toStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
            BinaryWriter outStream = new BinaryWriter(csEncrypt);
            try
            {
                outStream.Write(text);
                outStream.Close();
                csEncrypt.Close();
            }
            catch
            {
                outStream.Close();
                csEncrypt.Close();
                BinaryWriter writer = new BinaryWriter(fromStream);
                writer.Write(text);
                writer.Close();
            }
            return toStream;
        }
    }
}
