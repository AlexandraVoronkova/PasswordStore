using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePassword
{
    public class PasswordGeneration
    {
        public string GetPass(int lenPassword)
        {
            int[] arr = new int[lenPassword];
            Random rnd = new Random();
            string Password = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(50, 122);
                Password += (char)arr[i];
            }
            return Password;
        }
    }
}
