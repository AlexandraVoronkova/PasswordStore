using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace StorePassword
{
    interface CryptoProvider
    {
        Stream Encrypt(string passw, Stream fromStream, Stream toStream);
        Stream Decrypt(string passw, Stream fromStream, Stream toStream);
    }
}
