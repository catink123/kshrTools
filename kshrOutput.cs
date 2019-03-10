using System;

namespace kshrTools
{
    static class kshrOutput
    {
        static private void sendMessage (string message, string msgchar, ConsoleColor color) {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            string[] splitMessage = message.Split("\n");
            foreach (string msg in splitMessage) {
                if (Array.IndexOf(splitMessage, msg) == 0)
                    Console.WriteLine("{0}{0} " + msg, msgchar);
                else
                    Console.WriteLine("   " + msg);
            }
            Console.ForegroundColor = previousColor;
        }

        static private void sendMessage (string message, string sender, string msgchar, ConsoleColor color) {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            string[] splitMessage = message.Split("\n");
            foreach (string msg in splitMessage) {
                if (Array.IndexOf(splitMessage, msg) == 0)
                    Console.WriteLine("{0}{1}{0} " + msg, msgchar, sender);
                else
                    Console.WriteLine("   " + msg);
            }
            Console.ForegroundColor = previousColor;
        }
        static public void info (string message)
        {
            sendMessage(message, ":", ConsoleColor.Blue);
        }

        static public void info (string message, string sender)
        {
            sendMessage(message, sender, ":", ConsoleColor.Blue);
        }

        static public void error (string message)
        {
            sendMessage(message, "!", ConsoleColor.Red);
        }

        static public void error (string message, string sender)
        {
            sendMessage(message, sender, "!", ConsoleColor.Red);
        }

        static public void warning (string message)
        {
            sendMessage(message, ".", ConsoleColor.Yellow);
        }

        static public void warning (string message, string sender)
        {
            sendMessage(message, sender, ".", ConsoleColor.Yellow);
        }

        static public void success (string message)
        {
            sendMessage(message, "#", ConsoleColor.Green);
        }

        static public void success (string message, string sender)
        {
            sendMessage(message, sender, "#", ConsoleColor.Green);
        }
    }
}
