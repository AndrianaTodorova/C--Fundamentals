using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
       
        static void Main(string[] args)
        {
          
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                int lineNumber = 0;
                string line = string.Empty;
             
                while (line != null)
                {
                    line = reader.ReadLine();
                   
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(line);
                        break;
                    }
                    lineNumber++;
                }
            }

        }
    }
}
