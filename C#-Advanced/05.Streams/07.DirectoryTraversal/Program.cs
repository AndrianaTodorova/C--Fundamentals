using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;



namespace _07.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            Dictionary<string, List<FileInfo>> filesDict = new Dictionary<string, List<FileInfo>>();
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var extension = fileInfo.Extension;

                if (!filesDict.ContainsKey(extension))
                {
                    filesDict[extension] = new List<FileInfo>();
                }
                filesDict[extension].Add(fileInfo);

            }
            filesDict = filesDict.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullFileName = desktop + "/report.txt";

            using (var writer = new StreamWriter(fullFileName))
            {
                foreach (var pair in filesDict)
                {
                    string extension = pair.Key;
                    writer.WriteLine(extension);
                    var fileInfos = pair.Value;

                    foreach (var fileInform in fileInfos)
                    {
                        double size = (double)fileInform.Length / 1024;
                        writer.WriteLine($"--{fileInform.Name} - {size:f3}kb");
                    }
                }
            }
        }
    }
}
