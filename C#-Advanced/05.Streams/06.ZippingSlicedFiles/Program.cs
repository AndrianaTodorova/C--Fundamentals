using System;
using System.IO;
using System.IO.Compression;

namespace _06.ZippingSlicedFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "sliceMe.mp4";
            string destination = "";
            int parts = 5;
            Zip(sourceFile, destination, parts);
        }
        static void Zip(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream reader = new FileStream(sourceFile, FileMode.Open))
            {
                string extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);
                long pieceSice = (long)Math.Ceiling((double)reader.Length / parts);
                long currentPieceSize = 0;
                for (int i = 0; i < parts; i++)
                {
                    if (destinationDirectory == string.Empty)
                    {
                        destinationDirectory = "./";
                    }
                    string currentPart = destinationDirectory + $"Part - {i}.{extension}.gz";

                    using (GZipStream writer = new GZipStream(new FileStream(currentPart, FileMode.Create),CompressionLevel.Optimal))
                    {
                        byte[] buffer = new byte[4096];

                        while (reader.Read(buffer, 0, buffer.Length) == 4096)
                        {
                            writer.Write(buffer, 0, buffer.Length);
                            currentPieceSize += 4096;
                            if (currentPieceSize >= pieceSice)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
