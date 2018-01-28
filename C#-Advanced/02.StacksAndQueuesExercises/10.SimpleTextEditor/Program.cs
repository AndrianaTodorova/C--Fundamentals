using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> oldVersions = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] operations = Console.ReadLine().Split(' ').ToArray();

                switch (operations[0])
                {
                    case "1":
                        oldVersions.Push(sb.ToString());
                        sb.Append(operations[1]);
                        break;
                    case "2":
                        oldVersions.Push(sb.ToString());
                        sb.Remove(sb.Length-int.Parse(operations[1]), int.Parse(operations[1]));
                        break;
                    case "3":
                        Console.WriteLine(sb[int.Parse(operations[1])-1]);
                        break;
                    case "4":
                        sb = new StringBuilder(oldVersions.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
