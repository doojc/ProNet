﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Action and Func ***\n");

            // Use the Action<> delegate to point to DisplayMessage.
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            // Restore color.
            Console.ForegroundColor = previous;
        }

        // Target for the Func<> delegate
        static int Add(int x, int y)
        {
            return x + y;
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
