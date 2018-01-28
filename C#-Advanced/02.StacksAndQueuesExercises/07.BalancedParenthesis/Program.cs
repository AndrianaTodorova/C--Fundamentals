using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> leftScopes = new Stack<char>();
            //Stack<char> rightScopes = new Stack<char>();
            //if (input[0] == ')' || input[0] == '}' || input[0] == ']')
            //{
            //    Console.WriteLine("NO");
            //    return;
            //}

            for (int i = 0; i < input.Length; i++)
            {

                char scope = input[i];
                if (scope == '{' || scope == '(' || scope == '[')
                {
                    leftScopes.Push(scope);

                }
                else
                {
                    if (leftScopes.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }       
                    var currentLeftChar = leftScopes.Peek();
                    if (currentLeftChar == '(' && scope == ')')
                    {
                        leftScopes.Pop();
                    }
                    else if (currentLeftChar == '{' && scope == '}')
                    {
                        leftScopes.Pop();
                    }
                    else if (currentLeftChar == '[' && scope == ']')
                    {
                        leftScopes.Pop();
                    }
                }
                //else
                //{
                //    rightScopes.Push(scope);

                //}

            }
            //bool isSymetric = true;
            //if (leftScopes.Count != rightScopes.Count)
            //{
            //    Console.WriteLine("NO");
            //    return;

            //}
            //while (leftScopes.Count > 0 && rightScopes.Count > 0)
            //{
            //    char currentLeftChar = leftScopes.Dequeue();
            //    char currentRightChar = rightScopes.Pop();

            //    if (currentLeftChar == '(' && currentRightChar == ')')
            //    {
            //        continue;
            //    }
            //    else if (currentLeftChar == '{' && currentRightChar == '}')
            //    {
            //        continue;
            //    }
            //    else if (currentLeftChar == '[' && currentRightChar == ']')
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        isSymetric = false;
            //        break;
            //    }


            //}

            //if (isSymetric)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            if (leftScopes.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

    }
}
