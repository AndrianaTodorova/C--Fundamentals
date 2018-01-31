using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sentences = new StreamReader("text.txt"))
            {
                using (StreamReader words = new StreamReader("words.txt"))
                {
                    using (StreamWriter result = new StreamWriter("result.txt"))
                    {
                        Dictionary<string, int> dict = new Dictionary<string, int>();
                        string[] text = sentences.ReadToEnd().ToLower().Split(new[] { ',', '.', ':', '!', '?', '-', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                        string[] word = words.ReadToEnd().Split(new[] { '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
                        int counter = 0;
                        for (int i = 0; i < word.Length; i++)
                        {
                            for (int j = 0; j < text.Length; j++)
                            {
                                if (text[j] == word[i])
                                {
                                    counter++;
                                }
                            }
                            dict.Add(word[i], counter);
                            counter = 0;
                        }
                        foreach (var item in dict.OrderByDescending(x => x.Value))
                        {
                            result.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
