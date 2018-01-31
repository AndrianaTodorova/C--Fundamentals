using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var source = new FileStream("copyMe.png", FileMode.Open))
            {
                using (var destination = new FileStream("result.png", FileMode.Create))
                {
                    byte[] buf = new byte[10240];
                    while (true)
                    {
                        int readBytes = source.Read(buf, 0, buf.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buf, 0, readBytes);
                    }
                }
            }
        }
    }
}
